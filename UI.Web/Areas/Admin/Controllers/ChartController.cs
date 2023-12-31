﻿using Microsoft.AspNetCore.Mvc;
using UI.Web.Areas.Admin.Models;

namespace UI.Web.Areas.Admin.Controllers
{
    //[Area("Admin")]
    //[Authorize(Roles = "Admin")]

    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryname = "Teknoloji",
                categorycount = 10,
            });
            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 14,
            });
            list.Add(new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 5,
            });
            return Json(new { jsonlist = list });

        }
    }
}