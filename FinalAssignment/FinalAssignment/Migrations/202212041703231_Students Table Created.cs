namespace FinalAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentsTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        studentID = c.Int(nullable: false, identity: true),
                        firstName = c.String(nullable: false),
                        lastName = c.String(nullable: false),
                        finalScore = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.studentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
