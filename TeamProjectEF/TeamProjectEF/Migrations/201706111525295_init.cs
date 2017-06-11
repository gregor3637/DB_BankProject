namespace TeamProjectEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AgeTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.IdentityCards",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        EGN = c.Int(nullable: false),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        AddressID = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        AgeType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AgeTypes", t => t.AgeType_ID)
                .ForeignKey("dbo.People", t => t.ID)
                .Index(t => t.ID)
                .Index(t => t.AgeType_ID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityCards", "ID", "dbo.People");
            DropForeignKey("dbo.IdentityCards", "AgeType_ID", "dbo.AgeTypes");
            DropIndex("dbo.IdentityCards", new[] { "AgeType_ID" });
            DropIndex("dbo.IdentityCards", new[] { "ID" });
            DropTable("dbo.People");
            DropTable("dbo.IdentityCards");
            DropTable("dbo.AgeTypes");
        }
    }
}
