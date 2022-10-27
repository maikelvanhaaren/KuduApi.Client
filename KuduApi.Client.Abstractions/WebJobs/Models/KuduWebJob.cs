using System.Text.Json.Serialization;
using KuduApi.Client.Abstractions.WebJobs.Serializations;

namespace KuduApi.Client.Abstractions.WebJobs.Models
{
    [JsonConverter(typeof(KuduWebJobConverter))]
    public abstract class KuduWebJob
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("run_command")]
        public string RunCommand { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("extra_info_url")]
        public string ExtraInfoUrl { get; set; }

        [JsonPropertyName("type")]
        public KuduWebJobType Type { get; set; }

        [JsonPropertyName("error")]
        public object Error { get; set; }

        [JsonPropertyName("using_sdk")]
        public bool UsingSdk { get; set; }

        [JsonPropertyName("settings")]
        public KuduWebJobSettings Settings { get; set; }
    }
}