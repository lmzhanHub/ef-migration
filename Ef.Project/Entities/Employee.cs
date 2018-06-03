using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Project.Entities
{
    public class Employee
    {
        public int EId { get; set; }
        public string Name {get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public decimal Salary { get; set; }
    }

   
}
