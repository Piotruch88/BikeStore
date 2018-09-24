namespace BikeStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteorderID : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProductOrders", "OrderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductOrders", "OrderId", c => c.Int(nullable: false));
        }
    }
}
