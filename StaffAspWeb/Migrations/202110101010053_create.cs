namespace StaffAspWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Staffclasses",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Organismic_code = c.Int(nullable: false),
                        Salary = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.StaffId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Staffclasses");
        }
    }
}
