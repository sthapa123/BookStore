using BookStoreApp.Repository.Interface;
using BookStoreApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace BookStoreApp.Repository.Implementation
{
	public class EfRepository:IRepository
	{
		private BookStoreContext db = new BookStoreContext();

		public async Task<IEnumerable<Books>> GetBooks(string genre)
		{
			return await db.Book.Where(r=>r.Genre.Name==genre).ToListAsync();
		}
		public IEnumerable<Genres> GetGenres()
		{
			return db.Genre.ToList();
		}
		public async Task<bool> AddBook(Books books)
		{
			var book = new Books
			{
				Title = books.Title,
				Price = books.Price,
				BookUrl = books.BookUrl,
				GenreId = books.GenreId,
				AuthorId = books.AuthorId,
				OrderDetail = books.OrderDetail
			};
			db.Book.Add(book);
			db.Entry(book).State = EntityState.Added;
			try
			{
				await db.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
