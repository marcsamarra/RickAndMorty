namespace RickAndMorty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Episodes",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(),
                        air_date = c.String(),
                        episode = c.String(),
                        url = c.String(),
                        created = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Episodes");
        }
    }
}
