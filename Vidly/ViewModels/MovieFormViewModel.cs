using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime? ReleasedDateTime { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Range must be between 1 and 20")]
        public int? NumberInStock { get; set; }
        [Required]
        public int? GenreId { get; set; }
        public string Title
        {
            get
            {
                return Id == 0 ? "New Movie" : "Edit Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleasedDateTime = movie.ReleasedDateTime;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}