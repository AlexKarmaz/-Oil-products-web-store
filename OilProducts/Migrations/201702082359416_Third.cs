namespace OilProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "shipDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "shipDate", c => c.DateTime(nullable: false));
        }
    }
}
