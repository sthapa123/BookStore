using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Repository.Models
{
	public class Genres:ModelBase
	{
		[Required]
		[Key]
		public int GenreId { get; set; }
    	[Required(ErrorMessage ="Genre is not be null")]
		public string Name { get; set; }
		[StringLength(100)]
		public string Description { get; set; }
	}
}
