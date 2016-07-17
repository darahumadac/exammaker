namespace ExamMaker.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Exams_To_User : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exams", "User_UserId", c => c.Int());
            CreateIndex("dbo.Exams", "User_UserId");
            AddForeignKey("dbo.Exams", "User_UserId", "dbo.Users", "UserId");
            DropColumn("dbo.Exams", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exams", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Exams", "User_UserId", "dbo.Users");
            DropIndex("dbo.Exams", new[] { "User_UserId" });
            DropColumn("dbo.Exams", "User_UserId");
        }
    }
}
