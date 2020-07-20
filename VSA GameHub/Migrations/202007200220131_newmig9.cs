namespace VSA_GameHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmig9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditToUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        creditCard = c.Long(nullable: false),
                        userId = c.String(),
                        userName = c.String(),
                        userBalance = c.Int(nullable: false),
                        addedCredit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CreditToUsers");
        }
    }
}
