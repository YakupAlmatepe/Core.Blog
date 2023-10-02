using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.ViewComponents.Writer
{
	public class WriterAboutOnDasboard : ViewComponent
	{
		WriterManager wm = new WriterManager(new EFWriterDal());
		private readonly UserManager<AppUser> _userManager;

		public WriterAboutOnDasboard(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			var usermail = user.Email;
			var writerId = wm.GetAllTs().Where(x => x.WriterMail == usermail).Select(x => x.WriterID).FirstOrDefault();
			//var values = wm.GetWriterByID(writerId);
			//return View(values);bu uygulanacak
			return View();
		}
	}
}