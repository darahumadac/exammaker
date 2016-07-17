namespace ExamMaker.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_ExamMaker_DB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        ExamId = c.Int(nullable: false, identity: true),
                        ExamName = c.String(nullable: false, maxLength: 60),
                        Type = c.Int(nullable: false),
                        ScheduledExamDate = c.DateTime(nullable: false),
                        ExamPassword = c.String(maxLength: 16),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExamId);
            
            CreateTable(
                "dbo.ExamItems",
                c => new
                    {
                        ExamItemId = c.Int(nullable: false, identity: true),
                        ItemType = c.Int(nullable: false),
                        Question = c.String(),
                        Answer = c.String(),
                        Exam_ExamId = c.Int(),
                    })
                .PrimaryKey(t => t.ExamItemId)
                .ForeignKey("dbo.Exams", t => t.Exam_ExamId)
                .Index(t => t.Exam_ExamId);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        OptionId = c.Int(nullable: false, identity: true),
                        OptionName = c.String(),
                        ExamItem_ExamItemId = c.Int(),
                    })
                .PrimaryKey(t => t.OptionId)
                .ForeignKey("dbo.ExamItems", t => t.ExamItem_ExamItemId)
                .Index(t => t.ExamItem_ExamItemId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExamItems", "Exam_ExamId", "dbo.Exams");
            DropForeignKey("dbo.Options", "ExamItem_ExamItemId", "dbo.ExamItems");
            DropIndex("dbo.Options", new[] { "ExamItem_ExamItemId" });
            DropIndex("dbo.ExamItems", new[] { "Exam_ExamId" });
            DropTable("dbo.Users");
            DropTable("dbo.Options");
            DropTable("dbo.ExamItems");
            DropTable("dbo.Exams");
        }
    }
}
