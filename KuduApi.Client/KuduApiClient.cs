using KuduApi.Client.Abstractions;
using KuduApi.Client.Abstractions.Commands;
using KuduApi.Client.Abstractions.Deployments;
using KuduApi.Client.Abstractions.Environment;
using KuduApi.Client.Abstractions.WebJobs;
using KuduApi.Client.Commands;
using KuduApi.Client.Deployments;
using KuduApi.Client.Environment;
using KuduApi.Client.WebJobs;
using RestSharp;

namespace KuduApi.Client
{
    internal class KuduApiClient : IKuduApiClient
    {
        public KuduApiClient(RestClient restClient)
        {
            WebJobs = new KuduWebJobApiClient(restClient);
            Commands = new KuduCommandApiClient(restClient);
            Deployments = new KuduDeploymentApiClient(restClient);
            Environment = new KuduEnvironmentApiClient(restClient);
        }

        public IKuduWebJobApiClient WebJobs { get; }
        public IKuduCommandApiClient Commands { get; }
        public IKuduDeploymentApiClient Deployments { get; }
        public IKuduEnvironmentApiClient Environment { get; }
    }
}