using Abp.Web.Mvc.Views;

namespace BlogNG.Web.Views
{
    public abstract class BlogNGWebViewPageBase : BlogNGWebViewPageBase<dynamic>
    {

    }

    public abstract class BlogNGWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BlogNGWebViewPageBase()
        {
            LocalizationSourceName = "BlogNG";
        }
    }
}