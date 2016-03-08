using BookStoreApp.Repository.Interface;
using BookStoreApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BookStoreApp.Controllers
{
    public class BookController : Controller
    {
		private IRepository repo;
		public BookController(IRepository _repo)
		{
			this.repo = _repo;
		}
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
		public async Task<bool> Create(Books book)
		{
			if (ModelState.IsValid)
			{
				return await repo.AddBook(book);
			}
			return false;
		}

    }
}