using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    public class AdminController : Controller
    {
       // [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
