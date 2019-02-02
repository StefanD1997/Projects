using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GamesDemoMvc.Models
{
    public class Game
    {
        [Required]
        public int gameID { get; set; }

        [DisplayName("Picture")]
        public byte[] gamePicture { get; set; }

        [DisplayName("Categories")]
        [MaxLength(100, ErrorMessage = "Too many categories")]
        public string gameCategories { get; set; }

        [DisplayName("Price in Dollars")]
        public Nullable<int> gamePrice { get; set; }

        [DisplayName("Name")]
        [Required, MaxLength(50, ErrorMessage = "Name is too long")]
        public string gameName { get; set; }

        [DisplayName("Release Date")]
        public System.DateTime gameReleaseDate { get; set; }
    }

    public enum Search
    {
        Categories,
        Name
    }
}