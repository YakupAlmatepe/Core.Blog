using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
   // [AllowAnonymous]
    public class CategoryController : Controller
    {
        


        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        public IActionResult Index()
        {
            var values = cm.GetAllTs();
            return View(values);
        }
    }
}