using System.Threading.Tasks;
using Abp.Application.Services;
using ecomercialapp.Sessions.Dto;

namespace ecomercialapp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
