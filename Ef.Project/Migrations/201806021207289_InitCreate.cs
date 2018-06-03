namespace Ef.Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20, storeType: "nvarchar"),
                        Salary = c.Decimal(nullable: false, precision: 7, scale: 2),
                    })
                .PrimaryKey(t => t.EId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
