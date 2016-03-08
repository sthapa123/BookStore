using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Repository.Models
{
	public class Books
	{
		[ScaffoldColumn(false)]//Düzenlenmesini istemediğimiz model özelliği için kullanılır. Böylece bu alan EditorForModel kullandığımızda gizlenecektir. 
		[Key]
		public int BookId { get; set; }

		[DisplayName("Author")]
		public int AuthorId { get; set; }
		[DisplayName("Genre")]
		public int GenreId { get; set; }
		[Required(ErrorMessage = "A book title is required ")]
		[StringLength(160)]
		public string Title { get; set; }
		[Required(ErrorMessage = "the price of book is required")]
		[Range(0.01, 100, ErrorMessage = "price must be in this range")]
		public decimal Price { get; set; }
		[DisplayName("Book Url")]//Modelin view de gösterilecek ismidir.
		public string BookUrl { get; set; }
		public virtual Authors Author { get; set; }
		public virtual Genres Genre { get; set; }
		public virtual List<OrderDetails> OrderDetail { get; set; }
	}
}
