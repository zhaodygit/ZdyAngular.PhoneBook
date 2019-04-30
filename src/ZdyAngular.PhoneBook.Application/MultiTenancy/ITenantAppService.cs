using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ZdyAngular.PhoneBook.MultiTenancy.Dto;

namespace ZdyAngular.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

