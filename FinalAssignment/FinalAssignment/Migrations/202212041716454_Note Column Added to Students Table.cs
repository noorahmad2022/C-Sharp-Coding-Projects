namespace FinalAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoteColumnAddedtoStudentsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Note");
        }
    }
}
