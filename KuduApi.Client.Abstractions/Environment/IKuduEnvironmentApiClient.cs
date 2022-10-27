using System.Threading.Tasks;
using KuduApi.Client.Abstractions.Environment.Models;

namespace KuduApi.Client.Abstractions.Environment
{
    public interface IKuduEnvironmentApiClient
    {
        /// <summary>
        /// Get the Kudu version
        /// </summary>
        /// <returns></returns>
        Task<KuduEnvironment> Get();
    }
}