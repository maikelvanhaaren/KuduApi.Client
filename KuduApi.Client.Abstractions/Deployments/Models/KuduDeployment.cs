using System;
using System.Text.Json.Serialization;

namespace KuduApi.Client.Abstractions.Deployments.Models
{
    public class KuduDeployment
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("status_text")]
        public string StatusText { get; set; }

        [JsonPropertyName("author_email")]
        public string AuthorEmail { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("deployer")]
        public string Deployer { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("progress")]
        public string Progress { get; set; }

        [JsonPropertyName("received_time")]
        public DateTime ReceivedTime { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("end_time")]
        public DateTime EndTime { get; set; }

        [JsonPropertyName("last_success_end_time")]
        public DateTime LastSuccessEndTime { get; set; }

        [JsonPropertyName("complete")]
        public bool Complete { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("is_temp")]
        public bool IsTemp { get; set; }

        [JsonPropertyName("is_readonly")]
        public bool IsReadonly { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("log_url")]
        public string LogUrl { get; set; }

        [JsonPropertyName("site_name")]
        public string SiteName { get; set; }

        [JsonPropertyName("provisioningState")]
        public string ProvisioningState { get; set; }
    }
}