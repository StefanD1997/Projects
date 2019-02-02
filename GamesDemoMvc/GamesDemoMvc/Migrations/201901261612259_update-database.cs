namespace GamesDemoMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Game", "gamePicture", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Game", "gamePicture", c => c.String());
        }
    }
}
