// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Version2018_09_01
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ActivityLogAlertsOperations.
    /// </summary>
    public static partial class ActivityLogAlertsOperationsExtensions
    {
            /// <summary>
            /// Create a new activity log alert or update an existing one.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='activityLogAlertName'>
            /// The name of the activity log alert.
            /// </param>
            /// <param name='activityLogAlert'>
            /// The activity log alert to create or use for the update.
            /// </param>
            public static ActivityLogAlertResource CreateOrUpdate(this IActivityLogAlertsOperations operations, string resourceGroupName, string activityLogAlertName, ActivityLogAlertResource activityLogAlert)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, activityLogAlertName, activityLogAlert).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new activity log alert or update an existing one.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='activityLogAlertName'>
            /// The name of the activity log alert.
            /// </param>
            /// <param name='activityLogAlert'>
            /// The activity log alert to create or use for the update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActivityLogAlertResource> CreateOrUpdateAsync(this IActivityLogAlertsOperations operations, string resourceGroupName, string activityLogAlertName, ActivityLogAlertResource activityLogAlert, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, activityLogAlertName, activityLogAlert, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get an activity log alert.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='activityLogAlertName'>
            /// The name of the activity log alert.
            /// </param>
            public static ActivityLogAlertResource Get(this IActivityLogAlertsOperations operations, string resourceGroupName, string activityLogAlertName)
            {
                return operations.GetAsync(resourceGroupName, activityLogAlertName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an activity log alert.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='activityLogAlertName'>
            /// The name of the activity log alert.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActivityLogAlertResource> GetAsync(this IActivityLogAlertsOperations operations, string resourceGroupName, string activityLogAlertName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, activityLogAlertName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an activity log alert.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='activityLogAlertName'>
            /// The name of the activity log alert.
            /// </param>
            public static void Delete(this IActivityLogAlertsOperations operations, string resourceGroupName, string activityLogAlertName)
            {
                operations.DeleteAsync(resourceGroupName, activityLogAlertName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an activity log alert.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='activityLogAlertName'>
            /// The name of the activity log alert.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IActivityLogAlertsOperations operations, string resourceGroupName, string activityLogAlertName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, activityLogAlertName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates an existing ActivityLogAlertResource's tags. To update other fields
            /// use the CreateOrUpdate method.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='activityLogAlertName'>
            /// The name of the activity log alert.
            /// </param>
            /// <param name='activityLogAlertPatch'>
            /// Parameters supplied to the operation.
            /// </param>
            public static ActivityLogAlertResource Update(this IActivityLogAlertsOperations operations, string resourceGroupName, string activityLogAlertName, ActivityLogAlertPatchBody activityLogAlertPatch)
            {
                return operations.UpdateAsync(resourceGroupName, activityLogAlertName, activityLogAlertPatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing ActivityLogAlertResource's tags. To update other fields
            /// use the CreateOrUpdate method.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='activityLogAlertName'>
            /// The name of the activity log alert.
            /// </param>
            /// <param name='activityLogAlertPatch'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActivityLogAlertResource> UpdateAsync(this IActivityLogAlertsOperations operations, string resourceGroupName, string activityLogAlertName, ActivityLogAlertPatchBody activityLogAlertPatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, activityLogAlertName, activityLogAlertPatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of all activity log alerts in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<ActivityLogAlertResource> ListBySubscriptionId(this IActivityLogAlertsOperations operations)
            {
                return operations.ListBySubscriptionIdAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of all activity log alerts in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ActivityLogAlertResource>> ListBySubscriptionIdAsync(this IActivityLogAlertsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionIdWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of all activity log alerts in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IEnumerable<ActivityLogAlertResource> ListByResourceGroup(this IActivityLogAlertsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of all activity log alerts in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ActivityLogAlertResource>> ListByResourceGroupAsync(this IActivityLogAlertsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
