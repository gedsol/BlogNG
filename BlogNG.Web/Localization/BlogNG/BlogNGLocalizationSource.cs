using System.Web;
using Abp.Localization.Sources.Xml;

namespace BlogNG.Web.Localization.BlogNG
{
    public class BlogNGLocalizationSource : XmlLocalizationSource
    {
        public BlogNGLocalizationSource()
            : base("BlogNG", HttpContext.Current.Server.MapPath("/Localization/BlogNG"))
        {
        }
    }
}