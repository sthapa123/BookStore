using BookStoreApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BookStoreApp.Controllers
{
	public class HomeController : Controller
	{
		private IRepository repo;
		public HomeController(IRepository _repo)
		{
			this.repo = _repo;
		}
		public async Task<ActionResult> Index()
		{
			var books = await repo.GetBooks();
			return View(books);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}