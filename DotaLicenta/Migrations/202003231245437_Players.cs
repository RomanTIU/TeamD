namespace DotaLicenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Players : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "City", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Players", "AboutMe", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "AboutMe");
            DropColumn("dbo.Players", "City");
        }
    }
}
