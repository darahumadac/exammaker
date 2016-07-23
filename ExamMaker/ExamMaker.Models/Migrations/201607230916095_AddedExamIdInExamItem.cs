namespace ExamMaker.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedExamIdInExamItem : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ExamItems", "Exam_ExamId", "dbo.Exams");
            DropIndex("dbo.ExamItems", new[] { "Exam_ExamId" });
            RenameColumn(table: "dbo.ExamItems", name: "Exam_ExamId", newName: "ExamId");
            AlterColumn("dbo.ExamItems", "ExamId", c => c.Int(nullable: false));
            CreateIndex("dbo.ExamItems", "ExamId");
            AddForeignKey("dbo.ExamItems", "ExamId", "dbo.Exams", "ExamId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExamItems", "ExamId", "dbo.Exams");
            DropIndex("dbo.ExamItems", new[] { "ExamId" });
            AlterColumn("dbo.ExamItems", "ExamId", c => c.Int());
            RenameColumn(table: "dbo.ExamItems", name: "ExamId", newName: "Exam_ExamId");
            CreateIndex("dbo.ExamItems", "Exam_ExamId");
            AddForeignKey("dbo.ExamItems", "Exam_ExamId", "dbo.Exams", "ExamId");
        }
    }
}
