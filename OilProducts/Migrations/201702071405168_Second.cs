namespace OilProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "firstName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "lastName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "companyName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "country", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "state", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "city", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "postalCode", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "phoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "email", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "shipName", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "shipCountry", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "shipState", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "shipCity", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "shipPostalCode", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "shipAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "shipPhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "shipPhoneNumber", c => c.String());
            AlterColumn("dbo.Orders", "shipAddress", c => c.String());
            AlterColumn("dbo.Orders", "shipPostalCode", c => c.String());
            AlterColumn("dbo.Orders", "shipCity", c => c.String());
            AlterColumn("dbo.Orders", "shipState", c => c.String());
            AlterColumn("dbo.Orders", "shipCountry", c => c.String());
            AlterColumn("dbo.Orders", "shipName", c => c.String());
            AlterColumn("dbo.Customers", "email", c => c.String());
            AlterColumn("dbo.Customers", "phoneNumber", c => c.String());
            AlterColumn("dbo.Customers", "address", c => c.String());
            AlterColumn("dbo.Customers", "postalCode", c => c.String());
            AlterColumn("dbo.Customers", "city", c => c.String());
            AlterColumn("dbo.Customers", "state", c => c.String());
            AlterColumn("dbo.Customers", "country", c => c.String());
            AlterColumn("dbo.Customers", "companyName", c => c.String());
            AlterColumn("dbo.Customers", "lastName", c => c.String());
            AlterColumn("dbo.Customers", "firstName", c => c.String());
        }
    }
}
