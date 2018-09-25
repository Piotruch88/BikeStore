namespace BikeStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_ProductType : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "ProductType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductType", c => c.Int(nullable: false));
        }
    }
}
