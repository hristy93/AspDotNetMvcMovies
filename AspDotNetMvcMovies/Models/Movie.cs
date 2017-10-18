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
        //private enum GenreType
        //{
        //    Action,
        //    Drama,
        //    ScienceFiction,
        //}

        public int ID { get; set; }
        public string Title { get; set; }
        [DisplayName("Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        //[EnumDataType(typeof(GenreType), ErrorMessage = "Choose from Action, Drama or ScienceFiction")]
        public string Genre { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}