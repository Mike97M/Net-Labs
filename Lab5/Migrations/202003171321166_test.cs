namespace Lab5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "BazaDeDate.Business",
                c => new
                    {
                        BusinessId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LicenseNumber = c.String(),
                    })
                .PrimaryKey(t => t.BusinessId);
            
            CreateTable(
                "BazaDeDate.eCommerce",
                c => new
                    {
                        BusinessId = c.Int(nullable: false),
                        URL = c.String(),
                    })
                .PrimaryKey(t => t.BusinessId)
                .ForeignKey("BazaDeDate.Business", t => t.BusinessId)
                .Index(t => t.BusinessId);
            
            CreateTable(
                "BazaDeDate.Retail",
                c => new
                    {
                        BusinessId = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZIPCode = c.String(),
                    })
                .PrimaryKey(t => t.BusinessId)
                .ForeignKey("BazaDeDate.Business", t => t.BusinessId)
                .Index(t => t.BusinessId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("BazaDeDate.Retail", "BusinessId", "BazaDeDate.Business");
            DropForeignKey("BazaDeDate.eCommerce", "BusinessId", "BazaDeDate.Business");
            DropIndex("BazaDeDate.Retail", new[] { "BusinessId" });
            DropIndex("BazaDeDate.eCommerce", new[] { "BusinessId" });
            DropTable("BazaDeDate.Retail");
            DropTable("BazaDeDate.eCommerce");
            DropTable("BazaDeDate.Business");
        }
    }
}
