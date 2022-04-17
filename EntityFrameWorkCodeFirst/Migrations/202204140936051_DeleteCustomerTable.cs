namespace EntityFrameWorkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCustomerTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerTitle = c.String(),
                        CustomerName = c.String(),
                        CustomerSurname = c.String(),
                        CustomerCity = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
        }
    }
}
