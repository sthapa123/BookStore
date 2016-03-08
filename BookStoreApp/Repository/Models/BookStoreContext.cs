namespace BookStoreApp.Repository.Models
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class BookStoreContext : DbContext
	{
		public BookStoreContext()
			: base("name=BookStoreContext")
		{

		}
		public DbSet<Books> Book { get; set; }
		public DbSet<Orders> Order { get; set; }
		public DbSet<Authors> Author { get; set; }
		public DbSet<Genres> Genre { get; set; }
		public DbSet<Carts> Cart { get; set; }
		public DbSet<OrderDetails> OrderDetail { get; set; }
	}
}