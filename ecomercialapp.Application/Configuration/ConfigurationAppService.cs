using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ecomercialapp.Configuration.Dto;

namespace ecomercialapp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ecomercialappAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
