namespace TeamProjectEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeegntype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hobbies", "Name", c => c.String());
            AlterColumn("dbo.IdentityCards", "EGN", c => c.String(maxLength: 42));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.IdentityCards", "EGN", c => c.Int(nullable: false));
            DropColumn("dbo.Hobbies", "Name");
        }
    }
}
