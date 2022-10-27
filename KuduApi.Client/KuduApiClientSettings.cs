using System;
using System.Net.Http;

namespace KuduApi.Client
{
    public class KuduApiClientSettings
    {
        public string Endpoint { get; set; }
        public string DeploymentUsername { get; set; }
        public string DeploymentPassword { get; set; }
        public HttpClient HttpClient { get; set; }

        public bool IsValid()
        {
            if (!Uri.TryCreate(Endpoint, UriKind.Absolute, out _))
                return false;

            if (string.IsNullOrWhiteSpace(DeploymentUsername))
                return false;

            if (string.IsNullOrWhiteSpace(DeploymentPassword))
                return false;

            return true;
        }
    }
}