namespace KuduApi.Client.Abstractions.WebJobs.Models
{
    public enum KuduWebJobStatus
    {
        Initializing,
        Starting,
        Running,
        PendingRestart,
        Stopped,
        Aborted,
        Success,
        Failed,
    }
}