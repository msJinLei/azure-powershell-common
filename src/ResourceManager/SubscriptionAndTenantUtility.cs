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

using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using System;
using System.Linq;

namespace Microsoft.Azure.Commands.ResourceManager.Common.Utilities
{
    public class SubscriptionAndTenantUtility
    {
        public static string GetCommonTenant(IAzureAccount account)
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
    }
}
