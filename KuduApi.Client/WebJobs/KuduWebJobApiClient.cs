using System.Collections.Generic;
using System.Threading.Tasks;
using KuduApi.Client.Abstractions.WebJobs;
using KuduApi.Client.Abstractions.WebJobs.Models;
using RestSharp;

namespace KuduApi.Client.WebJobs
{
    internal class KuduWebJobApiClient : IKuduWebJobApiClient
    {
        private readonly RestClient _restClient;

        public KuduWebJobApiClient(RestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<ICollection<KuduWebJob>> GetAll()
        {
            var request = new RestRequest("webjobs");
            var result = await _restClient.GetAsync<List<KuduWebJob>>(request);
            return result ?? new List<KuduWebJob>();
        }

        public async Task<ICollection<KuduTriggeredWebJob>> GetAllTriggered()
        {
            var request = new RestRequest("triggeredwebjobs");
            var result = await _restClient.GetAsync<List<KuduTriggeredWebJob>>(request);
            return result ?? new List<KuduTriggeredWebJob>();
        }

        public async Task<KuduTriggeredWebJob> GetTriggered(string webJobName)
        {
            var request = new RestRequest($"triggeredwebjobs/{webJobName}/");
            return await _restClient.GetAsync<KuduTriggeredWebJob>(request);
        }

        public async Task DeleteTriggered(string webJobName)
        {
            var request = new RestRequest($"triggeredwebjobs/{webJobName}/delete", Method.Delete);
            await _restClient.ExecuteAsync(request);
        }

        public Task RunTriggered(string webJobName)
        {
            return RunTriggered(webJobName, arguments: null);
        }

        public async Task RunTriggered(string webJobName, string arguments)
        {
            var request = new RestRequest($"triggeredwebjobs/{webJobName}/run", Method.Post);
            if(arguments != null)
                request.AddParameter("arguments", arguments);
            await _restClient.ExecuteAsync(request);
        }

        public async Task<KuduTriggeredWebJobHistory> GetTriggeredRunHistory(string webJobName)
        {
            var request = new RestRequest($"triggeredwebjobs/{webJobName}/history");
            var result = await _restClient
                .GetAsync<KuduTriggeredWebJobHistory>(request);

            return result;
        }

        public async Task<KuduWebJobSettings> GetTriggeredSettings(string webJobName)
        {
            var request = new RestRequest($"triggeredwebjobs/{webJobName}/settings");
            return await _restClient.GetAsync<KuduWebJobSettings>(request);
        }

        public async Task UpdateTriggeredSettings(string webJobName, KuduTriggeredWebJobSettingsUpdateRequest updateRequest)
        {
            var request = new RestRequest($"triggeredwebjobs/{webJobName}/settings", Method.Put)
                .AddJsonBody(updateRequest);
            await _restClient.ExecuteAsync(request);
        }

        public async Task<ICollection<KuduContinuousWebJob>> GetAllContinuous()
        {
            var request = new RestRequest("continuouswebjobs");
            var result = await _restClient
                .GetAsync<List<KuduContinuousWebJob>>(request);

            return result ?? new List<KuduContinuousWebJob>();
        }

        public async Task<KuduContinuousWebJob> GetContinuous(string webJobName)
        {
            var request = new RestRequest($"continuouswebjobs/{webJobName}/");
            return await _restClient.GetAsync<KuduContinuousWebJob>(request);
        }

        public async Task DeleteContinuous(string webJobName)
        {
            var request = new RestRequest($"continuouswebjobs/{webJobName}/delete", Method.Delete);
            await _restClient.ExecuteAsync(request);
        }

        public async Task StartContinuous(string webJobName)
        {
            var request = new RestRequest($"continuouswebjobs/{webJobName}/start", Method.Post);
            await _restClient.ExecuteAsync(request);
        }

        public async Task StopContinuous(string webJobName)
        {
            var request = new RestRequest($"continuouswebjobs/{webJobName}/stop", Method.Post);
            await _restClient.ExecuteAsync(request);
        }

        public async Task<KuduWebJobSettings> GetContinuousSettings(string webJobName)
        {
            var request = new RestRequest($"continuouswebjobs/{webJobName}/settings");
            return await _restClient.GetAsync<KuduWebJobSettings>(request);
        }

        public async Task UpdateContinuousSettings(string webJobName, KuduContinuousWebJobSettingsUpdateRequest updateRequest)
        {
            var request = new RestRequest($"continuouswebjobs/{webJobName}/settings", Method.Put)
                .AddJsonBody(updateRequest);
            await _restClient.ExecuteAsync(request);
        }
    }
}