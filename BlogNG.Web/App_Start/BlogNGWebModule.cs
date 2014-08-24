using System;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using Abp.Dependency;
using Abp.Localization;
using Abp.Modules;
using Abp.Startup;
using BlogNG.Web.Localization.BlogNG;

namespace BlogNG.Web
{
    public class BlogNGWebModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(BlogNGDataModule),
                       typeof(BlogNGApplicationModule),
                       typeof(BlogNGWebApiModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            LocalizationHelper.RegisterSource<BlogNGLocalizationSource>();

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
