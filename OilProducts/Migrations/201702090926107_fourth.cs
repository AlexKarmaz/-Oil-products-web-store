namespace OilProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeliveryCompanies",
                c => new
                    {
                        deliveryCompanyId = c.Int(nullable: false, identity: true),
                        companyName = c.Int(nullable: false),
                        companyEmail = c.String(nullable: false),
                        companyPhone = c.String(nullable: false),
                        logo = c.String(),
                    })
                .PrimaryKey(t => t.deliveryCompanyId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        paymentsId = c.Int(nullable: false, identity: true),
                        orderId = c.Int(nullable: false),
                        paymentAmount = c.Double(nullable: false),
                        paymentDate = c.DateTime(nullable: false),
                        cardNumber = c.Long(nullable: false),
                        cardHoldersName = c.String(nullable: false),
                        cardExpDate = c.String(nullable: false),
                        cardAutorizationNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.paymentsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Payments");
            DropTable("dbo.DeliveryCompanies");
        }
    }
}
