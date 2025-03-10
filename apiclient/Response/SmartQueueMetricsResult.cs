using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Voximplant.API.Response {

    /// <summary>
    /// The [GetSmartQueueRealtimeMetrics] function result.
    /// </summary>
    public class SmartQueueMetricsResult
    {
        /// <summary>
        /// The report type(s). Possible values are calls_blocked_percentage, count_blocked_calls, average_abandonment_rate, count_abandonment_calls, service_level, occupancy_rate, sum_agents_online_time, sum_agents_ready_time, sum_agents_dialing_time, sum_agents_in_service_time, sum_agents_afterservice_time, sum_agents_dnd_time, sum_agents_banned_time, min_time_in_queue,max_time_in_queue, average_time_in_queue, min_answer_speed, max_answer_speed, average_answer_speed, min_handle_time, max_handle_time, average_handle_time, count_handled_calls, min_after_call_worktime, max_after_call_worktime, average_after_call_worktime, sum_agents_custom_1_time ... sum_agents_custom_10_time, call_count_assigned_to_queue, im_count_assigned_to_queue
        /// </summary>
        [JsonProperty("report_type")]
        public string ReportType { get; private set; }

        /// <summary>
        /// Grouping by agent or queue
        /// </summary>
        [JsonProperty("groups")]
        public SmartQueueMetricsGroups[] Groups { get; private set; }

    }
}