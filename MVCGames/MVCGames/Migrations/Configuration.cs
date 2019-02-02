namespace MVCGames.Migrations
{
    using MVCGames.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCGames.DAL.GameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVCGames.DAL.GameContext";
        }

        protected override void Seed(MVCGames.DAL.GameContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Categories.AddOrUpdate(x => x.ID,
                new Category() { ID = 1, Name = "MMORPG" },
                new Category() { ID = 2, Name = "FPS"},
                new Category() { ID = 3, Name = "RPG"}
                );

            context.Games.AddOrUpdate(x => x.ID,
                new Games() { ID = 1, Name = "Call Of Duty", ReleaseDate = DateTime.Now, Price = 60, Category = "FPS" },
                new Games() { ID = 2, Name = "Call Of Duty 2", ReleaseDate = DateTime.Now, Price = 50, Category = "FPS" }
                );
        }
    }
}
