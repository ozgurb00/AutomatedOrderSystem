namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCustomerNameColumnInOrdersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CustomerName", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "CustomerName");
        }
    }
}
