namespace TeamProjectEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AddressText = c.String(),
                        Town_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Towns", t => t.Town_ID)
                .Index(t => t.Town_ID);
            
            CreateTable(
                "dbo.IdentityCards",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        EGN = c.Int(nullable: false),
                        FirstName = c.String(maxLength: 40),
                        MiddleName = c.String(maxLength: 40),
                        LastName = c.String(maxLength: 40),
                        Age = c.Int(nullable: false),
                        DistinctiveElements = c.String(storeType: "ntext"),
                        Address_ID = c.Int(nullable: false),
                        AgeType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.Address_ID, cascadeDelete: true)
                .ForeignKey("dbo.AgeTypes", t => t.AgeType_ID)
                .ForeignKey("dbo.People", t => t.ID)
                .Index(t => t.ID)
                .Index(t => t.Address_ID)
                .Index(t => t.AgeType_ID);
            
            CreateTable(
                "dbo.AgeTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        AccountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "Town_ID", "dbo.Towns");
            DropForeignKey("dbo.IdentityCards", "ID", "dbo.People");
            DropForeignKey("dbo.IdentityCards", "AgeType_ID", "dbo.AgeTypes");
            DropForeignKey("dbo.IdentityCards", "Address_ID", "dbo.Addresses");
            DropIndex("dbo.IdentityCards", new[] { "AgeType_ID" });
            DropIndex("dbo.IdentityCards", new[] { "Address_ID" });
            DropIndex("dbo.IdentityCards", new[] { "ID" });
            DropIndex("dbo.Addresses", new[] { "Town_ID" });
            DropTable("dbo.Towns");
            DropTable("dbo.People");
            DropTable("dbo.AgeTypes");
            DropTable("dbo.IdentityCards");
            DropTable("dbo.Addresses");
        }
    }
}
