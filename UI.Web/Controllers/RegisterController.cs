using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    //[AllowAnonymous]
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterDal());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            //WriterValidator wv = new WriterValidator();
            //ValidationResult validationResult = new ValidationResult();
            //validationResult = wv.Validate(writer);
            //if (validationResult.IsValid)
            //{
            //    writer.WriterStatus = true;
            //    wm.TAdd(writer);
            //    return RedirectToAction("Index", "Blog");
            //}
            //else
            //{
            //    foreach (var item in validationResult.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
                return View();
           // }
        }
    }
}