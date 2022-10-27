using System.Text.Json.Serialization;

namespace KuduApi.Client.Abstractions.WebJobs.Models
{
    public class KuduContinuousWebJobSettingsUpdateRequest
    {
        [JsonPropertyName("is_singleton")]
        public bool IsSingleton { get; set; }
    }
    public class KuduTriggeredWebJobSettingsUpdateRequest
    {
        [JsonPropertyName("schedule")]
        public string Schedule { get; set; }
    } 
    
    public class KuduWebJobSettings
    {
        
        [JsonPropertyName("is_in_place")]
        public bool IsInPlace { get; set; }

        [JsonPropertyName("schedule")]
        public string Schedule { get; set; }

        [JsonPropertyName("is_singleton")]
        public bool IsSingleton { get; set; }
    }
}