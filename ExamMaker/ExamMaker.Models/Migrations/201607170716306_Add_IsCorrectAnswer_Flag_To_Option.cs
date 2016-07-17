namespace ExamMaker.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_IsCorrectAnswer_Flag_To_Option : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Options", "IsCorrectAnswer", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Options", "IsCorrectAnswer");
        }
    }
}
