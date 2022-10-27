using System.Text.Json.Serialization;

namespace KuduApi.Client.Abstractions.Commands.Models
{
    public class KuduCommandResponse
    {
        [JsonPropertyName("ExitCode")]
        public int ExitCode { get; set; }
        [JsonPropertyName("Output")]
        public string Output { get; set; }
        [JsonPropertyName("Error")]
        public string Error { get; set; }
    }
}