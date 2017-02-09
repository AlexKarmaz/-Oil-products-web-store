namespace OilProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        orderDetailsId = c.Int(nullable: false, identity: true),
                        orderId = c.Int(nullable: false),
                        productId = c.Int(nullable: false),
                        quantity = c.Int(nullable: false),
                        UnitPrice = c.Int(nullable: false),
                        discount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.orderDetailsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderDetails");
        }
    }
}
