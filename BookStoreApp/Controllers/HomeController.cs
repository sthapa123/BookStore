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
		public ActionResult Index()
		{
			return View();
		}
	}
}