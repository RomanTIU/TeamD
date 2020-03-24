namespace DotaLicenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSumf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "ImagePath", c => c.String());
            AddColumn("dbo.Teams", "ImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "ImagePath");
            DropColumn("dbo.Players", "ImagePath");
        }
    }
}
