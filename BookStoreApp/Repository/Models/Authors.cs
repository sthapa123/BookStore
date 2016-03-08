using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Repository.Models
{
	public class Authors:ModelBase
	{
		[Required]
		[Key]
		public int AuthorId { get; set; }
		[Required(ErrorMessage ="Author is not be null")]
		public string Name { get; set; }
	}
}
