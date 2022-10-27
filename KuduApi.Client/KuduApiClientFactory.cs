using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using KuduApi.Client.Abstractions;
using KuduApi.Client.Abstractions.Exceptions;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.Json;

namespace KuduApi.Client
{
    public class KuduApiClientFactory
    {
        public static IKuduApiClient Create(KuduApiClientSettings settings)
        {
            if(!settings.IsValid())
                throw new KuduApiClientException("Invalid settings.");
            
            var restClientOptions = new RestClientOptions()
            {
                BaseUrl = new Uri(settings.Endpoint),
            };

            var httpClient = settings.HttpClient ?? new HttpClient();
            
            var restClient = new RestClient(httpClient, restClientOptions);

            restClient.UseSystemTextJson(new JsonSerializerOptions()
            {
                Converters = {
                    new JsonStringEnumConverter()
                }
            });
            
            restClient.Authenticator = new HttpBasicAuthenticator(settings.DeploymentUsername, settings.DeploymentPassword);
            
            return new KuduApiClient(restClient);
        }
    }
}