using System.Threading.Tasks;
using KuduApi.Client.Abstractions.Commands.Models;

namespace KuduApi.Client.Abstractions.Commands
{
    public interface IKuduCommandApiClient
    {
        Task<KuduCommandResponse> Execute(KuduCommandRequest command);
    }
}