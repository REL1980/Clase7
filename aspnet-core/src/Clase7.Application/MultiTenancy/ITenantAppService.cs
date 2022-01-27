using Abp.Application.Services;
using Clase7.MultiTenancy.Dto;

namespace Clase7.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

