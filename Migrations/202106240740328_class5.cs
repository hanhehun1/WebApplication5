namespace WebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class class5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CategoryID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "CategoryID");
        }
    }
}
