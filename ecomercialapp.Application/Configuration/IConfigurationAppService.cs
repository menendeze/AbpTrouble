using System.Threading.Tasks;
using Abp.Application.Services;
using ecomercialapp.Configuration.Dto;

namespace ecomercialapp.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}