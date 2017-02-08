namespace TheRecordStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedCreatedandDetailFromBand : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Bands", "Details");
            DropColumn("dbo.Bands", "Created");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bands", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Bands", "Details", c => c.String());
        }
    }
}
