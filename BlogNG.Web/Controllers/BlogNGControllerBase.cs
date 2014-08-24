using Abp.Web.Mvc.Controllers;

namespace BlogNG.Web.Controllers
{
    public abstract class BlogNGControllerBase : AbpController
    {
        protected BlogNGControllerBase()
        {
            LocalizationSourceName = "BlogNG";
        }
    }
}