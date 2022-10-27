using System.Threading.Tasks;
using KuduApi.Client.Abstractions.Commands;
using KuduApi.Client.Abstractions.Commands.Models;
using RestSharp;

namespace KuduApi.Client.Commands
{
    internal class KuduCommandApiClient : IKuduCommandApiClient
    {
        private readonly RestClient _restClient;

        public KuduCommandApiClient(RestClient restClient)
        {
            _restClient = restClient;
        }
        
        public async Task<KuduCommandResponse> Execute(KuduCommandRequest command)
        {
            var request = new RestRequest("command")
                .AddJsonBody(command);
            return await _restClient.PostAsync<KuduCommandResponse>(request);
        }
    }
}