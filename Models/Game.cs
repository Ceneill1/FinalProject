using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Game
    {
        public int GameId {get; set;}


        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title {get; set;}

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Genre {get; set;}


        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price {get; set;}


        [Required]
        [StringLength(5)]
        public string Rating {get; set;}

    }
}