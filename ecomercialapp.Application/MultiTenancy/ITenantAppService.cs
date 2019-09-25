using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ecomercialapp.MultiTenancy.Dto;

namespace ecomercialapp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
