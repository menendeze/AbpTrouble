using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ecomercialapp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ecomercialappControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}