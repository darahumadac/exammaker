namespace ExamMaker.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Description_To_Options : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Options", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Options", "Description");
        }
    }
}
