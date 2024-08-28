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
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            // Primary Key
            builder.HasKey(c => c.Id);
            builder.Property(e => e.Id).UseIdentityColumn(1, 3);



            builder.Property(c => c.Name)
                .IsRequired()  // Name is required
                .HasMaxLength(100); // Sets a maximum length of 100 characters

            // Relationships
            builder.HasMany(c => c.StudentCoursesList) // One-to-many relationship
                .WithOne(sc => sc.Course) // Inverse relationship in StudentCourses entity
                .HasForeignKey(sc => sc.Course_Id);
        }
    }
}
