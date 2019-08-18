using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
	public class Movie
	{
		public int ID { get; set; }

		[StringLength(60, MinimumLength = 3, ErrorMessage = "TitleStringLength")]
		[Required(ErrorMessage = "Required")]
		public string Title { get; set; }

		[Display(Name = "Release Date")]
		[DataType(DataType.Date)]
		[Required(ErrorMessage = "Required")]
		public DateTime ReleaseDate { get; set; }

		[Range(1, 100, ErrorMessage = "PriceRange")]
		[DataType(DataType.Currency)]
		[Column(TypeName = "decimal(18, 2)")]
		[Required(ErrorMessage = "Required")]
		public decimal Price { get; set; }

		[RegularExpression(@"^([A-Z]+[a-zA-Z""'\s-]*)|([А-Я]+[а-яА-Я""'\s-]*)$", ErrorMessage = "Regular")]
		[StringLength(30, ErrorMessage = "GenreStringLength")]
		[Required(ErrorMessage = "Required")]
		public string Genre { get; set; }

		[RegularExpression(@"^([A-Z]+[a-zA-Z0-9""'\s-]*)|([А-Я]+[а-яА-Я0-9""'\s-]*)$", ErrorMessage = "Regular")]
		[StringLength(5, ErrorMessage = "RatingStringLength")]
		[Required(ErrorMessage = "Required")]
		public string Rating { get; set; }
	}
}