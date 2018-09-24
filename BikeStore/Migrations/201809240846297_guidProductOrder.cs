namespace BikeStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class guidProductOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductOrders", "OrderGuid", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductOrders", "OrderGuid");
        }
    }
}
