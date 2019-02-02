namespace MVCGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryGames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Category");
        }
    }
}
