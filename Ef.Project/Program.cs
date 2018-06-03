using Ef.Project.Databases;
using Ef.Project.Entities;
using Ef.Project.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CompanyContext>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CompanyContext, Configuration>());

            using (CompanyContext context = new CompanyContext())
            {
                //context.Database.Initialize(false);
                context.Employees.Add(new Employee()
                {
                    Department = new Department() { DepartmentName = "Test2" },
                    //DepartmentId = 1,
                    Name = "晓明",
                    Salary = 50000.00m
                });
                context.SaveChanges();
                }
            }
    }
}
