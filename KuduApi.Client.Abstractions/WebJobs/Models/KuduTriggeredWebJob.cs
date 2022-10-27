using System.Text.Json.Serialization;

namespace KuduApi.Client.Abstractions.WebJobs.Models
{
    public class KuduTriggeredWebJob : KuduWebJob
    {
        [JsonPropertyName("latest_run")]
        public KuduTriggeredWebJobRun Run { get; set; }

        [JsonPropertyName("history_url")]
        public string HistoryUrl { get; set; }

        [JsonPropertyName("scheduler_logs_url")]
        public string SchedulerLogsUrl { get; set; }
    }
}