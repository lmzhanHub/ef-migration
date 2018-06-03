using Ef.Project.Configurations;
using Ef.Project.Entities;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Project.Databases
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CompanyContext : DbContext
    {
        public CompanyContext() :base("CompanyDb")
        {

        }

        public DbSet<Employee> Employees { get; set; }


        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeEntityConfiguration());

        }
        

    }
}
