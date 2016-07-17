namespace ExamMaker.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Item_Number_To_ExamItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExamItems", "ItemNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExamItems", "ItemNumber");
        }
    }
}
