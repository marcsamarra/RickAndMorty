namespace RickAndMorty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class episodeCharacter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EpisodeCharacters",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Idepisode = c.Long(nullable: false),
                        Character = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EpisodeCharacters");
        }
    }
}
