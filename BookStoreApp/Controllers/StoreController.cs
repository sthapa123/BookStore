using BookStoreApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreApp.Controllers
{
    public class StoreController : Controller
    {
		private IRepository repo;
		public StoreController(IRepository _repo)
		{
			this.repo = _repo;
		}
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult GenreList()
		{
			var genres = repo.GetGenres();//this method is not using async because Child Action is not supported async
			return PartialView(genres);
		}
    }
}