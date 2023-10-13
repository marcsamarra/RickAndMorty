namespace RickAndMorty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeespisodetoepisode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Episodes", "episode", c => c.String());
            DropColumn("dbo.Episodes", "espisode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Episodes", "espisode", c => c.String());
            DropColumn("dbo.Episodes", "episode");
        }
    }
}
