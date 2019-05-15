namespace Festivals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artist",
                c => new
                    {
                        ArtistID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre = c.String(),
                    })
                .PrimaryKey(t => t.ArtistID);
            
            CreateTable(
                "dbo.Desfasurator",
                c => new
                    {
                        DesfasuratorID = c.Int(nullable: false, identity: true),
                        FestivalID = c.Int(nullable: false),
                        ArtistID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DesfasuratorID)
                .ForeignKey("dbo.Artist", t => t.ArtistID, cascadeDelete: true)
                .ForeignKey("dbo.Festival", t => t.FestivalID, cascadeDelete: true)
                .Index(t => t.FestivalID)
                .Index(t => t.ArtistID);
            
            CreateTable(
                "dbo.Festival",
                c => new
                    {
                        FestivalID = c.Int(nullable: false),
                        NameFestival = c.String(),
                        Locatie = c.String(),
                        Start = c.DateTime(nullable: false),
                        Finish = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FestivalID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Desfasurator", "FestivalID", "dbo.Festival");
            DropForeignKey("dbo.Desfasurator", "ArtistID", "dbo.Artist");
            DropIndex("dbo.Desfasurator", new[] { "ArtistID" });
            DropIndex("dbo.Desfasurator", new[] { "FestivalID" });
            DropTable("dbo.Festival");
            DropTable("dbo.Desfasurator");
            DropTable("dbo.Artist");
        }
    }
}
