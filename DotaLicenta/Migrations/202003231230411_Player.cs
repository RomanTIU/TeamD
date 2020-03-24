namespace DotaLicenta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Player : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Players", "SurName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Players", "Email", c => c.String());
            AddColumn("dbo.Players", "Adress", c => c.String());
            AddColumn("dbo.Players", "Country", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Players", "NickName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Players", "Nationality", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "Nationality", c => c.String());
            AlterColumn("dbo.Players", "NickName", c => c.String());
            DropColumn("dbo.Players", "Country");
            DropColumn("dbo.Players", "Adress");
            DropColumn("dbo.Players", "Email");
            DropColumn("dbo.Players", "SurName");
            DropColumn("dbo.Players", "FirstName");
        }
    }
}
