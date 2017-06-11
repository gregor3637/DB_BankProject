namespace TeamProjectEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedrequiredprop : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "AddressText", c => c.String(nullable: false));
            AlterColumn("dbo.AgeTypes", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Towns", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Towns", "Name", c => c.String());
            AlterColumn("dbo.AgeTypes", "Type", c => c.String());
            AlterColumn("dbo.Addresses", "AddressText", c => c.String());
        }
    }
}
