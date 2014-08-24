using System.Web.Mvc;

namespace BlogNG.Web.Controllers
{
    public class HomeController : BlogNGControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}