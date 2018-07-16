namespace DemoWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePropertyAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobPosters", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobPosters", "IsDeleted");
        }
    }
}
