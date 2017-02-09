namespace OilProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productsId = c.Int(nullable: false, identity: true),
                        productName = c.String(nullable: false),
                        price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
