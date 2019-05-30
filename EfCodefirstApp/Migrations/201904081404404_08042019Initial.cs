namespace EfCodefirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _08042019Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "CRM.Adresler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adres1 = c.String(maxLength: 100),
                        Adres2 = c.String(maxLength: 100),
                        il = c.String(maxLength: 15),
                        ilce = c.String(maxLength: 15),
                        PostaKodu = c.String(maxLength: 10),
                        refMusteriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Musteriler", t => t.refMusteriId, cascadeDelete: true)
                .Index(t => t.refMusteriId);
            
            CreateTable(
                "dbo.Musteriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 30),
                        Soyad = c.String(nullable: false, maxLength: 30),
                        Unvan = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("CRM.Adresler", "refMusteriId", "dbo.Musteriler");
            DropIndex("CRM.Adresler", new[] { "refMusteriId" });
            DropTable("dbo.Musteriler");
            DropTable("CRM.Adresler");
        }
    }
}
