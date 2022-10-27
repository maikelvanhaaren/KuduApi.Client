using KuduApi.Client.Abstractions.Commands;
using KuduApi.Client.Abstractions.Deployments;
using KuduApi.Client.Abstractions.Environment;
using KuduApi.Client.Abstractions.WebJobs;

namespace KuduApi.Client.Abstractions
{
    public interface IKuduApiClient
    {
        IKuduWebJobApiClient WebJobs { get; }
        IKuduCommandApiClient Commands { get; }
        IKuduDeploymentApiClient Deployments { get; }
        IKuduEnvironmentApiClient Environment { get; }
    }
}