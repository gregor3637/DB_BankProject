namespace TeamProjectEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class additionalrestrictions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "AddressText", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.AgeTypes", "Type", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Towns", "Name", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Towns", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.AgeTypes", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Addresses", "AddressText", c => c.String(nullable: false));
        }
    }
}
