using System;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
    public class Quote
    {
        public int QuoteId {get; set;}

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

        public string Date {get; set;}
        
        public DateTime CreatedAt {get; set;}


    }
}