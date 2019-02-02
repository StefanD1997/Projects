using MVCGames.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCGames.DAL
{
    public class GameContext : DbContext
    {
        public GameContext() : base("GamesConnection")
        {

        }

        public DbSet<Games> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}