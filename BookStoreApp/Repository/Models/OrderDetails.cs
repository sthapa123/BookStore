using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Repository.Models
{
	public class OrderDetails:ModelBase
	{
		[Key]
		public int OrderDetailId { get; set; }
		public int OrderId { get; set; }
		public int BookId { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public virtual Books Book { get; set; }
		public virtual Orders Order { get; set; }
	}
}
