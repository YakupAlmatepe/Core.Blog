using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    public class _AdminsLayout : Controller
    {
        [AllowAnonymous]
        public IActionResult AdminsLayout()
        {
            return View();
        }
        public PartialViewResult AdminNavbarPartial()
        {
            return PartialView();
        }
    }
}