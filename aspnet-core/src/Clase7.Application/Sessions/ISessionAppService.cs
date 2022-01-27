using System.Threading.Tasks;
using Abp.Application.Services;
using Clase7.Sessions.Dto;

namespace Clase7.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
