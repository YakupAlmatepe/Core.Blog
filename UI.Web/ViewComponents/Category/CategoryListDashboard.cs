﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.ViewComponents.Category
{
	public class CategoryListDashboard : ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EFCategoryDal());

		public IViewComponentResult Invoke()
		{
			var values = cm.GetAllTs();
			return View(values);
		}
	}
}