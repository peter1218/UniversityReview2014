namespace UniversityReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UniversityReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                        Body = c.String(),
                        ReviewerName = c.String(),
                        UniversityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Universities", t => t.UniversityId, cascadeDelete: true)
                .Index(t => t.UniversityId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.UniversityReviews", new[] { "UniversityId" });
            DropForeignKey("dbo.UniversityReviews", "UniversityId", "dbo.Universities");
            DropTable("dbo.UniversityReviews");
            DropTable("dbo.Universities");
        }
    }
}
