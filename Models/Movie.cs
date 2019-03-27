using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDbMVC.Models
{
	public class Movie
	{
		public Movie()
		{
			Rating = 0;
			Active = true;
			Created = new DateTime();
			Modified = new DateTime();

		}
		[Key]
		public int Id { get; set; }

		[StringLength(100)]
		[Required]
		public string Title { get; set; }
		
		[Required]
		public int CategoryId { get; set; }

		[StringLength(500)]
		public string Plot { get; set; }

		public string Tags { get; set; }

		public int? Rating { get; set; }

		public bool Active { get; set; }

		public string CoverImage { get; set; }

		[DataType(DataType.Date)]
		public DateTime Created { get; set; }

		[DataType(DataType.Date)]
		public DateTime Modified { get; set; }
		
	}
}
