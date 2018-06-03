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
    public class DepartmentEntityConfiguration: EntityTypeConfiguration<Department>
    {
        public DepartmentEntityConfiguration()
        {
            HasKey(e => e.Id).Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.DepartmentName).HasMaxLength(20);
            this.HasMany(e => e.Employees).WithRequired(e=>e.Department);
        }
    }
}
