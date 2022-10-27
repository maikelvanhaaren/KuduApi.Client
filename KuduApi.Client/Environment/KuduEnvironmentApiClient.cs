using System.Threading.Tasks;
using KuduApi.Client.Abstractions.Environment;
using KuduApi.Client.Abstractions.Environment.Models;
using RestSharp;

namespace KuduApi.Client.Environment
{
    internal class KuduEnvironmentApiClient : IKuduEnvironmentApiClient
    {
        private readonly RestClient _restClient;

        public KuduEnvironmentApiClient(RestClient restClient)
        {
            _restClient = restClient;
        }
        
        public Task<KuduEnvironment> Get()
        {
            var request = new RestRequest("environment");
            return _restClient.GetAsync<KuduEnvironment>(request);
        }
    }
}