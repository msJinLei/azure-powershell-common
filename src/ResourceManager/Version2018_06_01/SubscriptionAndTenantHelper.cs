// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.ResourceManager.Common.Paging;
using Microsoft.Azure.Internal.Subscriptions.Version2018_06_01;
using Microsoft.Azure.Internal.Subscriptions.Version2018_06_01.Models;
using Microsoft.Rest;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Azure.Commands.ResourceManager.Common.Utilities.Absbract;

namespace Microsoft.Azure.Commands.ResourceManager.Common.Utilities.Version2018_06_01
{
    public class SubscriptionAndTenantHelper : ISubscriptionAndTenantHelper
    {
        //private IAzureAccount account;
        //private IAzureEnvironment environment;
        //private IAzureTenant tenant;
        //public SubscriptionAndTenantHelper(IAzureAccount account, IAzureEnvironment environment, IAzureTenant tenant)
        //{
        //    this.account = account;
        //    this.environment = environment;
        //    this.tenant = tenant;
        //}

        private static IAccessToken AcquireAccessToken(IAzureAccount account, IAzureEnvironment environment, string tenantId)
        {
            return AzureSession.Instance.AuthenticationFactory.Authenticate(
               account,
               environment,
               tenantId,
               null,
               ShowDialog.Never,
               null);
        }

        internal static Dictionary<string, AzureSubscription> GetTenantsForSubscriptions(List<string> subscriptionIds, IAzureContext defaultContext)
        {
            Dictionary<string, AzureSubscription> result = new Dictionary<string, AzureSubscription>();

            if (subscriptionIds != null && subscriptionIds.Count != 0)
            {
                //First get all the tenants, then get subscriptions in each tenant till we exhaust the subscriotions sent in
                //Or we exhaust the tenants
                var subscriptionHelper = new SubscriptionAndTenantHelper();
                var accessTokenForCommon = AcquireAccessToken(defaultContext.Account, defaultContext.Environment, GetCommonTenant(defaultContext.Account));
                IEnumerable<AzureTenant> tenants = subscriptionHelper.ListAccountTenants(accessTokenForCommon, defaultContext.Environment);

                HashSet<string> subscriptionIdSet = new HashSet<string>(subscriptionIds);

                foreach (var tenant in tenants)
                {
                    if (subscriptionIdSet.Count <= 0)
                    {
                        break;
                    }

                    var tId = tenant.GetId().ToString();
                    var accessToken = AcquireAccessToken(defaultContext.Account, defaultContext.Environment, tId);
                    var subscriptions = subscriptionHelper.ListAllSubscriptionsForTenant(accessToken, defaultContext.Account, defaultContext.Environment, CreateTenantFromString(tId, accessToken.TenantId));

                    subscriptions?.ForEach((s) =>
                     {
                         var sId = s.GetId().ToString();
                         if (subscriptionIdSet.Contains(sId))
                         {
                             result.Add(sId, s);
                             subscriptionIdSet.Remove(sId);
                         }
                     });
                }
            }

            return result;
        }

        private static string GetCommonTenant(IAzureAccount account)
        {
            string result = AzureEnvironmentConstants.CommonAdTenant;
            if (account.IsPropertySet(AzureAccount.Property.Tenants))
            {
                var candidate = account.GetTenants().FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(candidate))
                {
                    result = candidate;
                }
            }

            return result;
        }

        private static AzureSubscription ToAzureSubscription(Subscription other, IAzureAccount account, IAzureEnvironment environment, IAzureTenant tenant)
        {
            var subscription = new AzureSubscription();
            subscription.SetAccount(account.Id);
            subscription.SetEnvironment(environment != null ? environment.Name : EnvironmentName.AzureCloud);
            subscription.Id = other.SubscriptionId;
            subscription.Name = other.DisplayName;
            subscription.State = other.State.ToString();
            subscription.SetProperty(AzureSubscription.Property.Tenants, tenant.Id);
            return subscription;
        }

        public static AzureTenant CreateTenantFromString(string tenantOrDomain, string accessTokenTenantId)
        {
            AzureTenant result = new AzureTenant();
            Guid id;
            if (Guid.TryParse(tenantOrDomain, out id))
            {
                result.Id = tenantOrDomain;
            }
            else
            {
                result.Id = accessTokenTenantId;
                result.Directory = tenantOrDomain;
            }

            return result;
        }

        private static GenericPageEnumerable<Subscription> ListAllSubscriptions(ISubscriptionClient client)
        {
            return new GenericPageEnumerable<Subscription>(client.Subscriptions.List, client.Subscriptions.ListNext, ulong.MaxValue, 0);
        }

        public List<AzureTenant> ListAccountTenants(IAccessToken accoessToken, IAzureEnvironment environment)
        {
            List<AzureTenant> result = new List<AzureTenant>();

            SubscriptionClient subscriptionClient = null;
            try
            {
                subscriptionClient = AzureSession.Instance.ClientFactory.CreateCustomArmClient<SubscriptionClient>(
                    environment.GetEndpointAsUri(AzureEnvironment.Endpoint.ResourceManager),
                    new TokenCredentials(accoessToken.AccessToken) as ServiceClientCredentials,
                    AzureSession.Instance.ClientFactory.GetCustomHandlers());

                var tenants = subscriptionClient.Tenants.List();
                if (tenants != null)
                {
                    result = new List<AzureTenant>();
                    tenants.ForEach((t) =>
                    {
                        result.Add(new AzureTenant { Id = t.TenantId, Directory = accoessToken.GetDomain() });
                    });
                }
            }
            finally
            {
                // In test mode, we are reusing the client since disposing of it will
                // fail some tests (due to HttpClient being null)
                if (subscriptionClient != null && !TestMockSupport.RunningMocked)
                {
                    subscriptionClient.Dispose();
                }
            }

            return result;
        }

        public IEnumerable<AzureSubscription> ListAllSubscriptionsForTenant(IAccessToken accessToken, IAzureAccount account, IAzureEnvironment environment, IAzureTenant tenant)
        //fixme: call CreateTenantFromString using token tenant and default tenant
        {
            SubscriptionClient subscriptionClient = null;
            subscriptionClient = AzureSession.Instance.ClientFactory.CreateCustomArmClient<SubscriptionClient>(
                    environment.GetEndpointAsUri(AzureEnvironment.Endpoint.ResourceManager),
                    new TokenCredentials(accessToken.AccessToken) as ServiceClientCredentials,
                    AzureSession.Instance.ClientFactory.GetCustomHandlers());

            return new GenericPageEnumerable<Subscription>(subscriptionClient.Subscriptions.List, subscriptionClient.Subscriptions.ListNext, ulong.MaxValue, 0)?
                .Select(s => ToAzureSubscription(s, account, environment, tenant));
        }

        public IAzureSubscription GetSubscriptionById(string subscriptionId, IAccessToken accessToken, IAzureAccount account, IAzureEnvironment environment, IAzureTenant tenant)
        {
            using (var subscriptionClient = AzureSession.Instance.ClientFactory.CreateCustomArmClient<SubscriptionClient>(
                environment.GetEndpointAsUri(AzureEnvironment.Endpoint.ResourceManager),
                new TokenCredentials(accessToken.AccessToken) as ServiceClientCredentials,
                AzureSession.Instance.ClientFactory.GetCustomHandlers()))
            {
                var subscription = subscriptionClient.Subscriptions.Get(subscriptionId);
                if (null != subscription)
                {
                    ToAzureSubscription(subscription, account, environment, tenant);
                }
            }

            return null;
        }

        public IEnumerable<IAzureSubscription> ListAllSubscriptions(IAccessToken accessToken, IAzureAccount account, IAzureEnvironment environment, IAzureTenant tenant)
        {
            IEnumerable<IAzureSubscription> subscriptions = new List<IAzureSubscription>();
            using (var subscriptionClient = AzureSession.Instance.ClientFactory.CreateCustomArmClient<SubscriptionClient>(
                environment.GetEndpointAsUri(AzureEnvironment.Endpoint.ResourceManager),
                new TokenCredentials(accessToken.AccessToken) as ServiceClientCredentials,
                AzureSession.Instance.ClientFactory.GetCustomHandlers()))
            {
                subscriptions = (ListAllSubscriptions(subscriptionClient).ToList() ??
                        new List<Subscription>())
                    .Where(s => "enabled".Equals(s.State.ToString(), StringComparison.OrdinalIgnoreCase) ||
                                "warned".Equals(s.State.ToString(), StringComparison.OrdinalIgnoreCase))
                    .Select(s => ToAzureSubscription(s, account, environment, tenant));

            }
            return subscriptions;
        }
    }
}
