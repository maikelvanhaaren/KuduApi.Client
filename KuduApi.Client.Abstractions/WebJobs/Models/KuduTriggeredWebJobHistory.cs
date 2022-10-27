using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace KuduApi.Client.Abstractions.WebJobs.Models
{
    public class KuduTriggeredWebJobHistory
    {
        [JsonPropertyName("runs")]
        public ICollection<KuduTriggeredWebJobRun> Runs { get; set; }
    }
}