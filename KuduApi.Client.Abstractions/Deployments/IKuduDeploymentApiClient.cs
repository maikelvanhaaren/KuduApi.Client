using System.Collections.Generic;
using System.Threading.Tasks;
using KuduApi.Client.Abstractions.Deployments.Models;

namespace KuduApi.Client.Abstractions.Deployments
{
    public interface IKuduDeploymentApiClient
    {
        /// <summary>
        /// Get the list of all deployments
        /// </summary>
        /// <returns></returns>
        Task<ICollection<KuduDeployment>> GetAll();
        
        /// <summary>
        /// Get a deployment
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <returns></returns>
        Task<KuduDeployment> Get(string deploymentId);
        
        /// <summary>
        /// Get the list of log entries for a deployment
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <returns></returns>
        Task<ICollection<KuduDeploymentLog>> GetLog(string deploymentId);
    }
}