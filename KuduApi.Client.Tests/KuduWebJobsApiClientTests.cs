using System.Threading.Tasks;
using NUnit.Framework;

namespace KuduApi.Client.Tests
{
    public class KuduWebJobsApiClientTests
    {
        [Test]
        public Task Test1()
        {
            //
            // var s = new KuduApiClientSettings()
            // {
            //     Endpoint = "",
            //     DeploymentUsername = "",
            //     DeploymentPassword = "",
            //     HttpClient = new HttpClient(),
            // };
            //
            // var kuduApiClient = KuduApiClientFactory.Create(s);
            //
            // var ac = await kuduApiClient.Commands.Execute(new KuduCommandRequest()
            // {
            //     Command = "echo Hello World",
            // });
            //
            // var actual2 = await kuduApiClient.Deployments
            //     .GetAll()
            //     .ConfigureAwait(false);
            //
            // var actual = await kuduApiClient.WebJobs
            //     .GetAll()
            //     .ConfigureAwait(false);
            //
            // var test = await kuduApiClient.WebJobs.GetTriggeredRunHistory(actual.First().Name).ConfigureAwait(false);
            //
            Assert.Pass();

            return Task.CompletedTask;
        }
    }
}