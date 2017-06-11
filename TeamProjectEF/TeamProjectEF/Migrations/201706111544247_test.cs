namespace TeamProjectEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.IdentityCards", "AddressID", "dbo.Addresses");
            DropIndex("dbo.IdentityCards", new[] { "AddressID" });
            RenameColumn(table: "dbo.IdentityCards", name: "AddressID", newName: "Address_ID");
            AddColumn("dbo.Addresses", "Town_ID", c => c.Int());
            AlterColumn("dbo.IdentityCards", "Address_ID", c => c.Int());
            CreateIndex("dbo.IdentityCards", "Address_ID");
            CreateIndex("dbo.Addresses", "Town_ID");
            AddForeignKey("dbo.Addresses", "Town_ID", "dbo.Towns", "ID");
            AddForeignKey("dbo.IdentityCards", "Address_ID", "dbo.Addresses", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityCards", "Address_ID", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "Town_ID", "dbo.Towns");
            DropIndex("dbo.Addresses", new[] { "Town_ID" });
            DropIndex("dbo.IdentityCards", new[] { "Address_ID" });
            AlterColumn("dbo.IdentityCards", "Address_ID", c => c.Int(nullable: false));
            DropColumn("dbo.Addresses", "Town_ID");
            RenameColumn(table: "dbo.IdentityCards", name: "Address_ID", newName: "AddressID");
            CreateIndex("dbo.IdentityCards", "AddressID");
            AddForeignKey("dbo.IdentityCards", "AddressID", "dbo.Addresses", "ID", cascadeDelete: true);
        }
    }
}
