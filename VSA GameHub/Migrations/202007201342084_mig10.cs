namespace VSA_GameHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Games", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Games", "PosterUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Games", "Company", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "Adress", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "Country", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "City", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Country", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Adress", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Surname", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Name", c => c.String());
            AlterColumn("dbo.Games", "Company", c => c.String());
            AlterColumn("dbo.Games", "PosterUrl", c => c.String());
            AlterColumn("dbo.Games", "Description", c => c.String());
            AlterColumn("dbo.Games", "Name", c => c.String());
        }
    }
}
