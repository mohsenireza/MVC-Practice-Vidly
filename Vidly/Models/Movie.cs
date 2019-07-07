using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime ReleasedDateTime { get; set; }
        public DateTime AddedDateTime { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Range must be between 1 and 20")]
        public int NumberInStock { get; set; }
        public Genre Genre { get; set; }
        [Required]
        public int GenreId { get; set; }
    }
}