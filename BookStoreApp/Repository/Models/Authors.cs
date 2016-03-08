using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Repository.Models
{
	public class Authors
	{
		[Required]
		[Key]
		public int AuthorId { get; set; }
		public string Name { get; set; }
	}
}
