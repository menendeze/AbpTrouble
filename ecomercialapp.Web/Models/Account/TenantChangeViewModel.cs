using Abp.AutoMapper;
using ecomercialapp.Sessions.Dto;

namespace ecomercialapp.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}