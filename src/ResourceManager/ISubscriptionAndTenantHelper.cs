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
using System.Collections.Generic;


namespace Microsoft.Azure.Commands.ResourceManager.Common.Utilities.Absbract
{
    public partial interface ISubscriptionAndTenantHelper
    {
        List<AzureTenant> ListAccountTenants(IAccessToken accoessToken, IAzureEnvironment environment);

        IEnumerable<AzureSubscription> ListAllSubscriptionsForTenant(IAccessToken accessToken, IAzureAccount account, IAzureEnvironment environment, IAzureTenant tenant);

        IAzureSubscription GetSubscriptionById(string subscriptionId, IAccessToken accessToken, IAzureAccount account, IAzureEnvironment environment, IAzureTenant tenant);

        IEnumerable<IAzureSubscription> ListAllSubscriptions(IAccessToken accessToken, IAzureAccount account, IAzureEnvironment environment, IAzureTenant tenant);
    }
}
