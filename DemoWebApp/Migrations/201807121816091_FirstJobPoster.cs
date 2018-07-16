namespace DemoWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstJobPoster : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplyForms",
                c => new
                    {
                        ApllyFormID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Location = c.String(),
                        Experience = c.String(),
                        Technologies = c.String(),
                        Salary = c.Int(nullable: false),
                        JobPosterID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ApllyFormID)
                .ForeignKey("dbo.JobPosters", t => t.JobPosterID, cascadeDelete: true)
                .Index(t => t.JobPosterID);
            
            CreateTable(
                "dbo.JobPosters",
                c => new
                    {
                        JobPosterID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Salary = c.Int(nullable: false),
                        Contract = c.String(),
                        Experience = c.String(),
                        Description = c.String(),
                        AppliesCounter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JobPosterID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplyForms", "JobPosterID", "dbo.JobPosters");
            DropIndex("dbo.ApplyForms", new[] { "JobPosterID" });
            DropTable("dbo.JobPosters");
            DropTable("dbo.ApplyForms");
        }
    }
}
