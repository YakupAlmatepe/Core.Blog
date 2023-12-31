﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Areas.Admin.Controllers
{
    //[Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class AdminBlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EFBlogDal());
        public IActionResult Index()
        {
            var values = blogManager.GetAllWithCategoryWriter();
            return View(values);
        }
    }
}