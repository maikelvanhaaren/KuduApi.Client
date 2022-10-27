using System;
using System.Text.Json.Serialization;

namespace KuduApi.Client.Abstractions.Deployments.Models
{
    public class KuduDeploymentLog
    {
        [JsonPropertyName("log_time")]
        public DateTime LogTime { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("details_url")]
        public object DetailsUrl { get; set; }
    }
}