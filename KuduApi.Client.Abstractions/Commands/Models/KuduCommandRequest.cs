using System.Text.Json.Serialization;

namespace KuduApi.Client.Abstractions.Commands.Models
{
    public class KuduCommandRequest
    {
        [JsonPropertyName("command")]
        public string Command { get; set; }
        [JsonPropertyName("dir")]
        public string Directory { get; set; }
    }
}