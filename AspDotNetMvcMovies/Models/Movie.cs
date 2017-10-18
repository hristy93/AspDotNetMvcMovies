using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspDotNetMvcMovies.Models
{
    public class Movie
    {
        private const string _wordRegularExpression = @"^[A-Z]+[a-zA-Z''-'\s]*$";

        public int ID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [DisplayName("Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(_wordRegularExpression)]
        [Required]
        [StringLength(20)]
        public string Genre { get; set; }
        [DataType(DataType.Currency)]
        [Range(1, 100)]
        public decimal Price { get; set; }
        [RegularExpression(_wordRegularExpression)]
        [StringLength(5)]
        public string Rating { get; set; }
    }
}