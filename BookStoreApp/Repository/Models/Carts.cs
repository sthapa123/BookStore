using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Repository.Models
{
	public class Carts:ModelBase
	{
		[Key]
		public int RecordId { get; set; }
		public int CartId { get; set; }
		public int BookId { get; set; }
		public int Count { get; set; }
		public virtual List<Books> Book { get; set; }
	}
}
