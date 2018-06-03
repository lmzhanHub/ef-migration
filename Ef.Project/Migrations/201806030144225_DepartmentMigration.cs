namespace Ef.Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(maxLength:20,storeType:"nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "DepartmentId", c => c.Int(nullable: false));
            AddForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);

            Sql("CREATE index `employee_department_id` on `employees` (`DepartmentId` DESC)");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropColumn("dbo.Employees", "DepartmentId");
            DropTable("dbo.Departments");
        }
    }
}
