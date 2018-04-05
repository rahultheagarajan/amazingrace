namespace AmazingRace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        StaffID = c.Int(nullable: false, identity: true),
                        StaffName = c.String(nullable: false),
                        EmailID = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StaffID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Staff");
        }
    }
}
