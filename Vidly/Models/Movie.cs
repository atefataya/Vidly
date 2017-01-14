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
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        public int NumberInStock { get; set; }
        [Required]
        public GenreType GenreType { get; set; }

        public byte GenreId { get; set; }

        

   
    }
    // we need to create a controller with action random movies/random
}