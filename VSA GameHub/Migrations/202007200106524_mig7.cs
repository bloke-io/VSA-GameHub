namespace VSA_GameHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GameToUsers", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GameToUsers", "UserId", c => c.Int(nullable: false));
        }
    }
}
