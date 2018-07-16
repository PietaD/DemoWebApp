namespace DemoWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelChange : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ApplyForms");
            DropColumn("dbo.ApplyForms", "ApplyFormID");
            AddColumn("dbo.ApplyForms", "ApllyFormID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ApplyForms", "ApllyFormID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ApplyForms", "ApplyFormID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.ApplyForms");
            DropColumn("dbo.ApplyForms", "ApllyFormID");
            AddPrimaryKey("dbo.ApplyForms", "ApplyFormID");
        }
    }
}
