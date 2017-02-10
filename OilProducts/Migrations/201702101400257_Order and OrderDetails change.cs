namespace OilProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderandOrderDetailschange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderDetails", "productName", c => c.String(nullable: false));
            AddColumn("dbo.Orders", "productId", c => c.Int(nullable: false));
            DropColumn("dbo.OrderDetails", "productId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderDetails", "productId", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "productId");
            DropColumn("dbo.OrderDetails", "productName");
        }
    }
}
