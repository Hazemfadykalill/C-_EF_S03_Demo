using C__EF_S03_Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S03_Demo.Configurations
{
    internal class StudentCoursesConfiguration : IEntityTypeConfiguration<StudentCourses>
    {
        public void Configure(EntityTypeBuilder<StudentCourses> builder)
        {
            // Define the primary key
            builder.HasKey(sc => new { sc.Course_Id, sc.Student_Id });

            // Configure the relationships
            builder.HasOne(sc => sc.Course)
                   .WithMany(c => c.StudentCoursesList)
                   .HasForeignKey(sc => sc.Course_Id);

            builder.HasOne(sc => sc.Student)
                   .WithMany(s => s.StudentCoursesList)
                   .HasForeignKey(sc => sc.Student_Id);

            // Configure other properties if needed
            builder.Property(sc => sc.Grade).IsRequired();  
        }
    }
}
