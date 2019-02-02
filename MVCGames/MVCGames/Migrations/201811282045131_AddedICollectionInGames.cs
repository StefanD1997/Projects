namespace MVCGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedICollectionInGames : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Games_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Games", t => t.Games_ID)
                .Index(t => t.Games_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Games_ID", "dbo.Games");
            DropIndex("dbo.Categories", new[] { "Games_ID" });
            DropTable("dbo.Categories");
        }
    }
}
