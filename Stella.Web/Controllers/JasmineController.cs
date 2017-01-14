using System;
using System.Web.Mvc;

namespace Stella.Web.Controllers
{
    public class JasmineController : Controller
    {
#if DEBUG
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
#endif
    }
}
