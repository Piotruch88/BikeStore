namespace BikeStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orders_products_order : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeCreate = c.DateTime(nullable: false),
                        UserIdPlacing = c.String(nullable: false),
                        Addres = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductOrders");
            DropTable("dbo.Orders");
        }
    }
}
