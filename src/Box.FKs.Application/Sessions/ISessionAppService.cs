using System.Threading.Tasks;
using Abp.Application.Services;
using Box.FKs.Sessions.Dto;

namespace Box.FKs.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
