namespace ExamMaker.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_UserId_To_Exam : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Exams", "User_UserId", "dbo.Users");
            DropIndex("dbo.Exams", new[] { "User_UserId" });
            RenameColumn(table: "dbo.Exams", name: "User_UserId", newName: "UserId");
            AlterColumn("dbo.Exams", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Exams", "UserId");
            AddForeignKey("dbo.Exams", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exams", "UserId", "dbo.Users");
            DropIndex("dbo.Exams", new[] { "UserId" });
            AlterColumn("dbo.Exams", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Exams", name: "UserId", newName: "User_UserId");
            CreateIndex("dbo.Exams", "User_UserId");
            AddForeignKey("dbo.Exams", "User_UserId", "dbo.Users", "UserId");
        }
    }
}
