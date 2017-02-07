namespace TheRecordStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedSpellingInBancs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bands", "Genre", c => c.String());
            DropColumn("dbo.Bands", "Gerne");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bands", "Gerne", c => c.String());
            DropColumn("dbo.Bands", "Genre");
        }
    }
}
