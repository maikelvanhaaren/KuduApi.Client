using System.Text.Json.Serialization;

namespace KuduApi.Client.Abstractions.WebJobs.Models
{
    public class KuduContinuousWebJob : KuduWebJob
    {
        [JsonPropertyName("status")]
        public KuduWebJobStatus Status { get; set; }

        [JsonPropertyName("detailed_status")]
        public string DetailedStatus { get; set; }

        [JsonPropertyName("log_url")]
        public string LogUrl { get; set; }
    }
}