using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S03_Demo.Entities
{
    public class StudentCourses
    {
        public int Course_Id { get; set; }
        public int Student_Id { get; set; }
        public double Grade { get; set; }
        public virtual  Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
