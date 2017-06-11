namespace TeamProjectEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IdentityCards",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        EGN = c.Int(nullable: false),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Address_ID = c.Int(),
                        AgeType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.Address_ID)
                .ForeignKey("dbo.AgeTypes", t => t.AgeType_ID)
                .ForeignKey("dbo.People", t => t.ID)
                .Index(t => t.ID)
                .Index(t => t.Address_ID)
                .Index(t => t.AgeType_ID);
            
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
                "dbo.Towns",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
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
                        AccountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityCards", "ID", "dbo.People");
            DropForeignKey("dbo.IdentityCards", "AgeType_ID", "dbo.AgeTypes");
            DropForeignKey("dbo.Addresses", "Town_ID", "dbo.Towns");
            DropForeignKey("dbo.IdentityCards", "Address_ID", "dbo.Addresses");
            DropIndex("dbo.Addresses", new[] { "Town_ID" });
            DropIndex("dbo.IdentityCards", new[] { "AgeType_ID" });
            DropIndex("dbo.IdentityCards", new[] { "Address_ID" });
            DropIndex("dbo.IdentityCards", new[] { "ID" });
            DropTable("dbo.People");
            DropTable("dbo.AgeTypes");
            DropTable("dbo.Towns");
            DropTable("dbo.Addresses");
            DropTable("dbo.IdentityCards");
        }
    }
}
