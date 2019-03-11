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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for MetricBaselineOperations.
    /// </summary>
    public static partial class MetricBaselineOperationsExtensions
    {
            /// <summary>
            /// **Gets the baseline values for a specific metric**.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource. It has the following structure:
            /// subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceName}.
            /// For example:
            /// subscriptions/b368ca2f-e298-46b7-b0ab-012281956afa/resourceGroups/vms/providers/Microsoft.Compute/virtualMachines/vm1
            /// </param>
            /// <param name='metricName'>
            /// The name of the metric to retrieve the baseline for.
            /// </param>
            /// <param name='timespan'>
            /// The timespan of the query. It is a string with the following format
            /// 'startDateTime_ISO/endDateTime_ISO'.
            /// </param>
            /// <param name='interval'>
            /// The interval (i.e. timegrain) of the query.
            /// </param>
            /// <param name='aggregation'>
            /// The aggregation type of the metric to retrieve the baseline for.
            /// </param>
            /// <param name='sensitivities'>
            /// The list of sensitivities (comma separated) to retrieve.
            /// </param>
            /// <param name='resultType'>
            /// Allows retrieving only metadata of the baseline. On data request all
            /// information is retrieved. Possible values include: 'Data', 'Metadata'
            /// </param>
            public static BaselineResponse Get(this IMetricBaselineOperations operations, string resourceUri, string metricName, string timespan = default(string), System.TimeSpan? interval = default(System.TimeSpan?), string aggregation = default(string), string sensitivities = default(string), ResultType? resultType = default(ResultType?))
            {
                return operations.GetAsync(resourceUri, metricName, timespan, interval, aggregation, sensitivities, resultType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// **Gets the baseline values for a specific metric**.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource. It has the following structure:
            /// subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceName}.
            /// For example:
            /// subscriptions/b368ca2f-e298-46b7-b0ab-012281956afa/resourceGroups/vms/providers/Microsoft.Compute/virtualMachines/vm1
            /// </param>
            /// <param name='metricName'>
            /// The name of the metric to retrieve the baseline for.
            /// </param>
            /// <param name='timespan'>
            /// The timespan of the query. It is a string with the following format
            /// 'startDateTime_ISO/endDateTime_ISO'.
            /// </param>
            /// <param name='interval'>
            /// The interval (i.e. timegrain) of the query.
            /// </param>
            /// <param name='aggregation'>
            /// The aggregation type of the metric to retrieve the baseline for.
            /// </param>
            /// <param name='sensitivities'>
            /// The list of sensitivities (comma separated) to retrieve.
            /// </param>
            /// <param name='resultType'>
            /// Allows retrieving only metadata of the baseline. On data request all
            /// information is retrieved. Possible values include: 'Data', 'Metadata'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BaselineResponse> GetAsync(this IMetricBaselineOperations operations, string resourceUri, string metricName, string timespan = default(string), System.TimeSpan? interval = default(System.TimeSpan?), string aggregation = default(string), string sensitivities = default(string), ResultType? resultType = default(ResultType?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceUri, metricName, timespan, interval, aggregation, sensitivities, resultType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// **Lists the baseline values for a resource**.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource. It has the following structure:
            /// subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceName}.
            /// For example:
            /// subscriptions/b368ca2f-e298-46b7-b0ab-012281956afa/resourceGroups/vms/providers/Microsoft.Compute/virtualMachines/vm1
            /// </param>
            /// <param name='timeSeriesInformation'>
            /// Information that need to be specified to calculate a baseline on a time
            /// series.
            /// </param>
            public static CalculateBaselineResponse CalculateBaseline(this IMetricBaselineOperations operations, string resourceUri, TimeSeriesInformation timeSeriesInformation)
            {
                return operations.CalculateBaselineAsync(resourceUri, timeSeriesInformation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// **Lists the baseline values for a resource**.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource. It has the following structure:
            /// subscriptions/{subscriptionName}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceName}.
            /// For example:
            /// subscriptions/b368ca2f-e298-46b7-b0ab-012281956afa/resourceGroups/vms/providers/Microsoft.Compute/virtualMachines/vm1
            /// </param>
            /// <param name='timeSeriesInformation'>
            /// Information that need to be specified to calculate a baseline on a time
            /// series.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CalculateBaselineResponse> CalculateBaselineAsync(this IMetricBaselineOperations operations, string resourceUri, TimeSeriesInformation timeSeriesInformation, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CalculateBaselineWithHttpMessagesAsync(resourceUri, timeSeriesInformation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
