using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Runtime.Intrinsics.X86;

namespace UI.Web.Controllers
{
   
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogDal());
        WriterManager wm = new WriterManager(new EFWriterDal());
        private readonly UserManager<AppUser> _userManager;

        public BlogController(UserManager<AppUser> userManager)
        {

            _userManager = userManager;
        }



        public IActionResult Index()//blogların sayfalandığı index
        {
            var values = bm.GetAllWithCategoryWriter();
            return View(); //return View(values); dönecek
        }
        [AllowAnonymous]
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            var values = bm.GetListLinqBlog(id);
            return View(values);
        }
        public async Task<IActionResult> BlogListByWriterAsync()
        {
            //WriterManager wm = new WriterManager(new EFWriterDal());
            var userId = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = bm.GetListIncludedByWriter(userId.Id);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager cm = new CategoryManager(new EFCategoryDal());
            List<SelectListItem> categories = (from x in cm.GetAllTs()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.cv = categories;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BlogAdd(Blog blog)
        {
            //BlogValidator wv = new BlogValidator();
            //ValidationResult validationResult = new ValidationResult();
            //validationResult = wv.Validate(blog);
            //if (validationResult.IsValid)
            //{
            //    blog.BlogStatus = true;
            //    blog.BlogDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            //    var userId = await _userManager.FindByNameAsync(User.Identity.Name);
            //    blog.AppUserID = userId.Id;
            //    bm.TAdd(blog);
            //    return RedirectToAction("BlogListByWriter", "Blog");
            //}
            //else
            //{
            //    foreach (var item in validationResult.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
                return View();
            }
        }
    //public IActionResult BlogDelete(int id)
    //{
    //    var values = bm.GetTById(id);
    //    bm.TDelete(values);
    //    return RedirectToAction("BlogListByWriter", "Blog");
    //}
    //[HttpGet]
    //public IActionResult BlogUpdate(int id)
    //{
    //    CategoryManager cm = new CategoryManager(new EFCategoryDal());
    //    List<SelectListItem> categories = (from x in cm.GetAllTs()
    //                                       select new SelectListItem
    //                                       {
    //                                           Text = x.CategoryName,
    //                                           Value = x.CategoryID.ToString()
    //                                       }).ToList();
    //    ViewBag.cv = categories;
    //    var blogvalue = bm.GetTById(id);
    //    return View(blogvalue);
    //}
    //[HttpPost]
    //public IActionResult BlogUpdate(Blog blog)
    //{
    //    BlogManager bm = new BlogManager(new EFBlogDal());
    //    bm.TUpdate(blog);
    //    //  return RedirectToAction("BlogListByWriter", "Blog");
    //    return ("C");

    //}
    // }
}
