using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ecomercialapp.Roles.Dto;
using ecomercialapp.Users.Dto;

namespace ecomercialapp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}