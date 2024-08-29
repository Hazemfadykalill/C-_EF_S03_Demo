using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S03_Demo.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<StudentCourses> StudentCoursesList { get; set; }
    }
}
