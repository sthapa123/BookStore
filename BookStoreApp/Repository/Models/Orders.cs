using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Repository.Models
{
	public class Orders:ModelBase
	{
		[ScaffoldColumn(false)]
		[Key]
		public int OrderId { get; set; }
		[ScaffoldColumn(false)]
		public DateTime OrderDate { get; set; }
		[ScaffoldColumn(false)]
		public string userName { get; set; }
		[Required(ErrorMessage = "FirstName is required")]
		[DisplayName("Firs tName")]
		public string firstName { get; set; }
		[Required(ErrorMessage = "Last Name is required")]
		[DisplayName("Last Name")]
		public string lastName { get; set; }
		[Required(ErrorMessage = "Address is required")]
		[StringLength(70)]
		public string Address { get; set; }
		[Required(ErrorMessage = "City is required")]
		[StringLength(40)]
		public string City { get; set; }
		[Required(ErrorMessage = "State is required")]
		[StringLength(40)]
		public string State { get; set; }
		[Required(ErrorMessage = "Postal code is required")]
		[StringLength(10)]
		[DisplayName("Postal code")]
		public string postalCode { get; set; }
		[Required(ErrorMessage = "Country is required")]
		[StringLength(40)]
		public string Country { get; set; }
		[Required(ErrorMessage = "Phone is required")]
		[StringLength(24)]
		public string phoneNumber { get; set; }
		[Required(ErrorMessage = "Email address is required")]
		[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
			ErrorMessage = "Email is is not valid.")]
		public string emailAddress { get; set; }
		[ScaffoldColumn(false)]
		public int Total { get; set; }

		public virtual List<OrderDetails> OrderDetails { get; set; }
	}
}
