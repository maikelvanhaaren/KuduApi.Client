using System.Collections.Generic;
using System.Threading.Tasks;
using KuduApi.Client.Abstractions.WebJobs.Models;

namespace KuduApi.Client.Abstractions.WebJobs
{
    public interface IKuduWebJobApiClient
    {
        /// <summary>
        /// List all web jobs
        /// </summary>
        /// <returns></returns>
        Task<ICollection<KuduWebJob>> GetAll();

        /// <summary>
        /// List all triggered jobs
        /// </summary>
        /// <returns></returns>
        Task<ICollection<KuduTriggeredWebJob>> GetAllTriggered();

        /// <summary>
        /// Get a specific triggered job by name
        /// </summary>
        /// <param name="webJobName"></param>
        /// <returns></returns>
        Task<KuduTriggeredWebJob> GetTriggered(string webJobName);

        // /// <summary>
        // /// Using a zip file containing the files for it, or just a single file (e.g foo.exe).
        // /// </summary>
        // /// <param name="webJobName"></param>
        // /// <param name="content"></param>
        // /// <returns></returns>
        // Task UploadTriggered(string webJobName, object content);

        /// <summary>
        /// Delete a triggered job
        /// </summary>
        /// <param name="webJobName"></param>
        /// <returns></returns>
        Task DeleteTriggered(string webJobName);

        /// <summary>
        /// Invoke a triggered web job
        /// </summary>
        /// <param name="webJobName"></param>
        /// <returns></returns>
        Task RunTriggered(string webJobName);

        /// <summary>
        /// Invoke a triggered web job
        /// </summary>
        /// <param name="webJobName"></param>
        /// <param name="arguments">To run with arguments use the arguments parameters that will be added to the script when invoked. It also gets passed to the WebJob as the WEBJOBS_COMMAND_ARGUMENTS environment variable.</param>
        /// <returns></returns>
        Task RunTriggered(string webJobName, string arguments);

        /// <summary>
        /// List all triggered job runs history
        /// </summary>
        /// <param name="webJobName"></param>
        /// <returns></returns>
        Task<KuduTriggeredWebJobHistory> GetTriggeredRunHistory(string webJobName);
        
        /// <summary>
        /// Get settings from a triggered job
        /// </summary>
        /// <param name="webJobName"></param>
        /// <returns></returns>
        Task<KuduWebJobSettings> GetTriggeredSettings(string webJobName);
        
        /// <summary>
        /// Update settings for a triggered job
        /// </summary>
        /// <param name="webJobName"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        Task UpdateTriggeredSettings(string webJobName, KuduTriggeredWebJobSettingsUpdateRequest request);

        /// <summary>
        /// List all continuous jobs
        /// </summary>
        /// <returns></returns>
        Task<ICollection<KuduContinuousWebJob>> GetAllContinuous();
        
        /// <summary>
        /// Get a specific continuous job by name
        /// </summary>
        /// <returns></returns>
        Task<KuduContinuousWebJob> GetContinuous(string webJobName);
        
        // /// <summary>
        // /// Upload a continuous job as zip
        // /// </summary>
        // /// <returns></returns>
        // Task UploadContinuous(string webJobName, object @object);
        
        /// <summary>
        /// Delete a continuous job
        /// </summary>
        /// <param name="webJobName"></param>
        /// <returns></returns>
        Task DeleteContinuous(string webJobName);
        
        /// <summary>
        /// Start a continuous job
        /// </summary>
        /// <param name="webJobName"></param>
        /// <returns></returns>
        Task StartContinuous(string webJobName);
        
        /// <summary>
        /// Stop a continuous job
        /// </summary> 
        /// <param name="webJobName"></param>
        /// <returns></returns>
        Task StopContinuous(string webJobName);
        
        /// <summary>
        /// Get settings from a continuous job
        /// </summary>
        /// <param name="webJobName"></param>
        /// <returns></returns>
        Task<KuduWebJobSettings> GetContinuousSettings(string webJobName);
        
        /// <summary>
        /// Update settings for a continuous job
        /// </summary>
        /// <param name="webJobName"></param>
        /// <param name="updateRequest"></param>
        /// <returns></returns>
        Task UpdateContinuousSettings(string webJobName, KuduContinuousWebJobSettingsUpdateRequest updateRequest);

    }
}