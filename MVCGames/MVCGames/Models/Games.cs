using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGames.Models
{
    public class Games
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}