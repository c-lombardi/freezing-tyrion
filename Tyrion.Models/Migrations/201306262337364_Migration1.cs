namespace Tyrion.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistId = c.Int(nullable: false, identity: true),
                        ArtistName = c.String(),
                    })
                .PrimaryKey(t => t.ArtistId);
            
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        AlbumName = c.String(),
                        AlbumArtist = c.String(),
                        ArtistId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlbumId)
                .ForeignKey("dbo.Artists", t => t.ArtistId, cascadeDelete: true)
                .Index(t => t.ArtistId);
            
            CreateTable(
                "dbo.AudioFiles",
                c => new
                    {
                        AudioFileId = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                        Title = c.String(),
                        AlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AudioFileId)
                .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                .Index(t => t.AlbumId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.AudioFiles", new[] { "AlbumId" });
            DropIndex("dbo.Albums", new[] { "ArtistId" });
            DropForeignKey("dbo.AudioFiles", "AlbumId", "dbo.Albums");
            DropForeignKey("dbo.Albums", "ArtistId", "dbo.Artists");
            DropTable("dbo.AudioFiles");
            DropTable("dbo.Albums");
            DropTable("dbo.Artists");
        }
    }
}
