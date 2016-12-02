namespace UniversityRanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rankings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        WorldRank = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        NationalRank = c.Int(nullable: false),
                        QualityOfEducation = c.Int(nullable: false),
                        AlumniEmployment = c.Int(nullable: false),
                        QualityOfFaculty = c.Int(nullable: false),
                        Publications = c.Int(nullable: false),
                        Influence = c.Int(nullable: false),
                        Citations = c.Int(nullable: false),
                        Patents = c.Int(nullable: false),
                        BroadImpact = c.Int(nullable: false),
                        Score = c.Double(nullable: false),
                        University_ID = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Universities", t => t.University_ID)
                .Index(t => t.University_ID);
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameOfUniversity = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rankings", "University_ID", "dbo.Universities");
            DropIndex("dbo.Rankings", new[] { "University_ID" });
            DropTable("dbo.Universities");
            DropTable("dbo.Rankings");
        }
    }
}
