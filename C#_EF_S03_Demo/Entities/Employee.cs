using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S03_Demo.Entities
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public int Dept_Id { get; set; }
        public virtual Department Department { get; set; }
    }
}
