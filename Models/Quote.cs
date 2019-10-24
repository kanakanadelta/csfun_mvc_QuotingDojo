using System;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
    public class Quote
    {
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        [Display(Name = "Your Name:")]
        public string Name{get;set;}

        [Required]
        [MinLength(3)]
        [MaxLength(120)]
        [Display(Name = "Your Quote:")]
        public string Comment{get;set;}

        public string DisplayDate {get; set;}
        public DateTime DateValue {get; set;}

    }
}