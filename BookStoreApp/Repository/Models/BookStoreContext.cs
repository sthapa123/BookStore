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
			//lazy loading enabled is true;EF is default lazyloading true
			//this.Configuration.LazyLoadingEnabled = true;
			//There are four different database initialization strategies:
			/*CreateDatabaseIfNotExists*/
			//Database.SetInitializer<BookStoreEntities>(new CreateDatabaseIfNotExists<BookStoreEntities>());
			/*DropCreateDatabaseIfModelChanges*/
			//Database.SetInitializer<BookStoreEntities>(new DropCreateDatabaseIfModelChanges<BookStoreEntities>());
			/*DropCreateDatabaseAlways*/
			//Database.SetInitializer<BookStoreEntities>(new DropCreateDatabaseAlways<BookStoreEntities>());
			/*Custom DB Initializer*/
			//Database.SetInitializer<BookStoreEntities>(new BookStoreInitializer());
		}
		public DbSet<Books> Book { get; set; }
		public DbSet<Orders> Order { get; set; }
		public DbSet<Authors> Author { get; set; }
		public DbSet<Genres> Genre { get; set; }
		public DbSet<Carts> Cart { get; set; }
		public DbSet<OrderDetails> OrderDetail { get; set; }
	}
}