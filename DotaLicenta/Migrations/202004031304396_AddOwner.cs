namespace DotaLicenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOwner : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Owner", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Owner");
        }
    }
}
