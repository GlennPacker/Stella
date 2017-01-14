using System.Web.Mvc;

namespace Stella.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
			return View("Index");
        }

		public ActionResult Planets()
		{
			return View("Planets");
		}

		public ActionResult DirPlanet()
		{
			return View("DirPlanet");
		}
	}
}