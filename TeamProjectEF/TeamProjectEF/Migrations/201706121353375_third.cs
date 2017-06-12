namespace TeamProjectEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.IdentityCards", "MiddleName", c => c.String(maxLength: 42));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.IdentityCards", "MiddleName", c => c.String(maxLength: 40));
        }
    }
}
