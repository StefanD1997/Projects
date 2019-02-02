namespace GamesDemoMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Game",
                c => new
                    {
                        gameID = c.Int(nullable: false, identity: true),
                        gamePicture = c.String(),
                        gameCategories = c.String(),
                        gamePrice = c.Int(),
                        gameName = c.String(),
                        gameReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.gameID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Game");
        }
    }
}
