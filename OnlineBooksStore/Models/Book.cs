﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBooksStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
      
        [Required]
        public DateTime ReleaseDate { get; set; }
        
        public DateTime DateAdded { get; set; }
        
        public byte NumberInStock { get; set; }

        [Required]

        public Genre Genre { get; set; }

        public byte GenreId { get; set; }
    }
}