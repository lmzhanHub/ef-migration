using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Project.Entities
{
    public class Department
    {

        public Department()
        {
            this.Employees = new List<Employee>();
        }
        public int Id { get; set;}

        public string DepartmentName { get; set; }

   
        public virtual List<Employee> Employees { get; set; }

    }
}
