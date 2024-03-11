using Abp.Application.Services;
using Box.FKs.MultiTenancy.Dto;

namespace Box.FKs.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

