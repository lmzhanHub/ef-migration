using Ef.Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Project.Configurations
{
    public class EmployeeEntityConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeEntityConfiguration()
        {
            HasKey(e => e.EId).Property(e => e.EId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.Name).HasMaxLength(20);
            this.Property(e => e.Salary).HasPrecision(5, 2);
            this.Property(e => e.DepartmentId);
        }
    }
}
