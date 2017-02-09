namespace OilProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customersId = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        companyName = c.String(),
                        country = c.String(),
                        state = c.String(),
                        city = c.String(),
                        postalCode = c.String(),
                        address = c.String(),
                        phoneNumber = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.customersId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ordersId = c.Int(nullable: false, identity: true),
                        customerId = c.Int(nullable: false),
                        deliveryCompanyId = c.Int(nullable: false),
                        orderDate = c.DateTime(nullable: false),
                        orderNumber = c.Int(nullable: false),
                        shipName = c.String(),
                        shipCountry = c.String(),
                        shipState = c.String(),
                        shipCity = c.String(),
                        shipPostalCode = c.String(),
                        shipAddress = c.String(),
                        shipPhoneNumber = c.String(),
                        shipDate = c.DateTime(nullable: false),
                        shippingMethodId = c.Int(nullable: false),
                        freightCharge = c.Int(nullable: false),
                        totalPrice = c.Double(nullable: false),
                        paymentsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ordersId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
