using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        public int WeddingID { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters.")]
        [Display(Name = "Wedder One")]
        public string WedderOne { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters.")]
        [Display(Name = "Wedder Two")]
        public string WedderTwo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Address must be at least 2 characters.")]
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserID { get; set; }
        public User Creator { get; set; }
        public List<Attendance> Attendees { get; set; }
    }
}