namespace EntityFrameWorkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCustomerNameToCustomerTitleInCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerTitle", c => c.String());
            Sql("Update Customers set CustomerTitle=CustomerName");
            DropColumn("dbo.Customers", "CustomerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerName", c => c.String());
            Sql("Update Customers set CustomerName=CustomerTitle");
            DropColumn("dbo.Customers", "CustomerTitle");
        }
    }
}
