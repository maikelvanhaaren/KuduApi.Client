using System;
using System.Text.Json.Serialization;

namespace KuduApi.Client.Abstractions.WebJobs.Models
{
    public class KuduTriggeredWebJobRun
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("status")]
        public KuduWebJobStatus Status { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("end_time")]
        public DateTime EndTime { get; set; }

        [JsonPropertyName("duration")]
        public TimeSpan Duration { get; set; }

        [JsonPropertyName("output_url")]
        public string OutputUrl { get; set; }

        [JsonPropertyName("error_url")]
        public string ErrorUrl { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("job_name")]
        public string JobName { get; set; }

        [JsonPropertyName("trigger")]
        public string Trigger { get; set; }
    }
}