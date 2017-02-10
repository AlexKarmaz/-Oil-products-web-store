namespace OilProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBankPayments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShippingMethods",
                c => new
                    {
                        shippingMethodsId = c.Int(nullable: false, identity: true),
                        shippingMethodName = c.String(nullable: false),
                        taxeRate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.shippingMethodsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShippingMethods");
        }
    }
}
