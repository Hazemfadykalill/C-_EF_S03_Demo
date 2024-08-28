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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            // Primary Key
            builder.HasKey(d => d.Id);
            builder.Property(e => e.Id).UseIdentityColumn(1, 3);


            // Properties
            builder.Property(d => d.Id)
                .IsRequired()  // The Id property is required (default for primary keys)
                .ValueGeneratedOnAdd(); // Specifies that the Id is auto-generated

            builder.Property(d => d.Name)
                .IsRequired()  // Name is required
                .HasMaxLength(100); // Sets a maximum length of 100 characters

            // Relationships
            builder.HasMany(d => d.Employees)   // Specifies the one-to-many relationship
                .WithOne(e => e.Department)     // Specifies the inverse navigation property in Employee
                .HasForeignKey(e => e.Dept_Id); // Specifies the foreign key on the Employee side
                
        }
    }
}
