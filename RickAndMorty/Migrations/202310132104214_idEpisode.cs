namespace RickAndMorty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idEpisode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Episodes", "idEpisode", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Episodes", "idEpisode");
        }
    }
}
