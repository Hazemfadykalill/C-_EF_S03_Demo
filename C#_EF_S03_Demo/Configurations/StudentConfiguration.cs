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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).UseIdentityColumn(1, 3);





            builder.Property(s => s.Name)
                .IsRequired()  // Name is required
                .HasMaxLength(100); // Sets a maximum length of 100 characters

            // Relationships
            builder.HasMany(s => s.StudentCoursesList) // One-to-many relationship
                .WithOne(sc => sc.Student) // Inverse relationship in StudentCourses entity
                .HasForeignKey(sc => sc.Student_Id);
        }
    }
}
