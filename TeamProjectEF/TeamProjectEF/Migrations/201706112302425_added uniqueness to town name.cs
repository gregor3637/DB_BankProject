namespace TeamProjectEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeduniquenesstotownname : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Towns", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Towns", new[] { "Name" });
        }
    }
}
