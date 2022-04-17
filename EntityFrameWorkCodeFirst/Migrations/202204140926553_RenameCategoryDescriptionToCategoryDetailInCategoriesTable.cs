namespace EntityFrameWorkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCategoryDescriptionToCategoryDetailInCategoriesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryDetail", c => c.String());
            Sql("update Categories set CategoryDetail=CategoryDescription");
            DropColumn("dbo.Categories", "CategoryDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryDescription", c => c.String());
            Sql("update Categories set CategoryDescription=CategoryDetail");
            DropColumn("dbo.Categories", "CategoryDetail");
        }
    }
}
