﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovieProject.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [Display(Name = "Release Date"),DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        [Required]
        public string Genre { get; set; }
        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        [Required]
        public string Rating { get; set; }
        [StringLength(200)]
        [Display(Name = "Image Url")]
        public string Image { get; set; }

        public ICollection<MovieRole> MovieRoles { get; set; }
    }
}