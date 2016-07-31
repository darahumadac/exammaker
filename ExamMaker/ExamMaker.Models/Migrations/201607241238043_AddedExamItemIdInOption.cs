namespace ExamMaker.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedExamItemIdInOption : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Options", "ExamItem_ExamItemId", "dbo.ExamItems");
            DropIndex("dbo.Options", new[] { "ExamItem_ExamItemId" });
            RenameColumn(table: "dbo.Options", name: "ExamItem_ExamItemId", newName: "ExamItemId");
            AlterColumn("dbo.Options", "ExamItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.Options", "ExamItemId");
            AddForeignKey("dbo.Options", "ExamItemId", "dbo.ExamItems", "ExamItemId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Options", "ExamItemId", "dbo.ExamItems");
            DropIndex("dbo.Options", new[] { "ExamItemId" });
            AlterColumn("dbo.Options", "ExamItemId", c => c.Int());
            RenameColumn(table: "dbo.Options", name: "ExamItemId", newName: "ExamItem_ExamItemId");
            CreateIndex("dbo.Options", "ExamItem_ExamItemId");
            AddForeignKey("dbo.Options", "ExamItem_ExamItemId", "dbo.ExamItems", "ExamItemId");
        }
    }
}
