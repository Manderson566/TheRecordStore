namespace TheRecordStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restored : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AlbumName = c.String(),
                        AlbumRelease = c.DateTime(nullable: false),
                        BandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bands", t => t.BandId, cascadeDelete: true)
                .Index(t => t.BandId);
            
            CreateTable(
                "dbo.Bands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BandName = c.String(),
                        Genre = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Details = c.String(),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "BandId", "dbo.Bands");
            DropIndex("dbo.Albums", new[] { "BandId" });
            DropTable("dbo.Bands");
            DropTable("dbo.Albums");
        }
    }
}
