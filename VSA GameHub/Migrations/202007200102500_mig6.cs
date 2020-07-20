namespace VSA_GameHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameToUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameName = c.String(),
                        UserName = c.String(),
                        GameId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GameToUsers");
        }
    }
}
