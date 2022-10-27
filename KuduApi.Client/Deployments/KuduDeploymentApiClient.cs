using System.Collections.Generic;
using System.Threading.Tasks;
using KuduApi.Client.Abstractions.Deployments;
using KuduApi.Client.Abstractions.Deployments.Models;
using RestSharp;

namespace KuduApi.Client.Deployments
{
    internal class KuduDeploymentApiClient : IKuduDeploymentApiClient
    {
        private readonly RestClient _restClient;

        public KuduDeploymentApiClient(RestClient restClient)
        {
            _restClient = restClient;
        }
        
        public async Task<ICollection<KuduDeployment>> GetAll()
        {
            var request = new RestRequest("deployments");
            var result = await _restClient.GetAsync<List<KuduDeployment>>(request);
            return result ?? new List<KuduDeployment>();
        }

        public async Task<KuduDeployment> Get(string deploymentId)
        {
            var request = new RestRequest($"deployments/{deploymentId}");
            return await _restClient.GetAsync<KuduDeployment>(request);
        }

        public async Task<ICollection<KuduDeploymentLog>> GetLog(string deploymentId)
        {
            var request = new RestRequest($"deployments/{deploymentId}/log");
            var result = await _restClient.GetAsync<List<KuduDeploymentLog>>(request);
            return result ?? new List<KuduDeploymentLog>();
        }
    }
}