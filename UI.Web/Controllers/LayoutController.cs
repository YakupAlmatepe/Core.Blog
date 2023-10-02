using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    public class LayoutController : Controller
    {

      //  [AllowAnonymous]

        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
        public PartialViewResult Partial2()
        {
            return PartialView();
        }
        public PartialViewResult Partial3()
        {
            return PartialView();
        }
    }
}