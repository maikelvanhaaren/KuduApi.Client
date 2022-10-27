using System;
using System.Text.Json.Serialization;

namespace KuduApi.Client.Abstractions.Environment.Models
{
    public class KuduEnvironment
    {
        [JsonPropertyName("version")]
        public string Version { get; set; }
        [JsonPropertyName("siteLastModified")]
        public DateTime SiteLastModified { get; set; }
    }
}