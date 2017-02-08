namespace TheRecordStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReaddedCreatedtoBandcs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bands", "Created", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bands", "Created");
        }
    }
}
