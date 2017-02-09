namespace OilProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class companyNametoString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DeliveryCompanies", "companyName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DeliveryCompanies", "companyName", c => c.Int(nullable: false));
        }
    }
}
