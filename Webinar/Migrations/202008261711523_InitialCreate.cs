namespace Webinar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Student_ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Document = c.String(nullable: false, maxLength: 10),
                        Phone = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Student_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
