namespace EntityFrameWorkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCustomerCityColumnInCustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerCity", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerCity");
        }
    }
}
