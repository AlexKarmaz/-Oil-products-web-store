namespace OilProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class taxeRatetoString : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankPayments",
                c => new
                    {
                        bankPaymentsId = c.Int(nullable: false, identity: true),
                        orderId = c.Int(nullable: false),
                        paymentAmount = c.Double(nullable: false),
                        paymentDate = c.DateTime(nullable: false),
                        nameBank = c.String(nullable: false),
                        swift = c.String(nullable: false),
                        accountNumber = c.String(nullable: false),
                        passportSeries = c.String(nullable: false),
                        passportId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.bankPaymentsId);
            
            AlterColumn("dbo.ShippingMethods", "taxeRate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ShippingMethods", "taxeRate", c => c.Double(nullable: false));
            DropTable("dbo.BankPayments");
        }
    }
}
