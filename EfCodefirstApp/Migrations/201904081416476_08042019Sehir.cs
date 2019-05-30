namespace EfCodefirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _08042019Sehir : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ils",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sehir = c.String(),
                        PlakaKodu = c.String(),
                        TelefonKodu = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ils");
        }
    }
}
