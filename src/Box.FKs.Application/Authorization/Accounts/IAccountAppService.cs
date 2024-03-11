using System.Threading.Tasks;
using Abp.Application.Services;
using Box.FKs.Authorization.Accounts.Dto;

namespace Box.FKs.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
