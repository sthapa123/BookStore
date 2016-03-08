using BookStoreApp.Repository.Interface;
using BookStoreApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Repository.Implementation
{
	public class EfRepository:IRepository
	{
		private BookStoreContext db = new BookStoreContext();

		public async Task<IEnumerable<Books>> GetBooks()
		{
			return await db.Book.ToListAsync();
		}
		public IEnumerable<Genres> GetGenres()
		{
			return db.Genre.ToList();
		}
	}
}
