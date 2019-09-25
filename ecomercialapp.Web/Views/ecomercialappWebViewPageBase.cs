using Abp.Web.Mvc.Views;

namespace ecomercialapp.Web.Views
{
    public abstract class ecomercialappWebViewPageBase : ecomercialappWebViewPageBase<dynamic>
    {

    }

    public abstract class ecomercialappWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ecomercialappWebViewPageBase()
        {
            LocalizationSourceName = ecomercialappConsts.LocalizationSourceName;
        }
    }
}