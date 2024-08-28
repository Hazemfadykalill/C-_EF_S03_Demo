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
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Primary Key
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn(1,3);    


           

            builder.Property(e => e.Name)
                .IsRequired() // Name is required
                .HasMaxLength(100); // Sets a max length of 100 characters

            builder.Property(e => e.Salary)
                .IsRequired() // Salary is required
                .HasColumnType("decimal(18,2)"); // Configure as decimal with 2 decimal places for better precision

            builder.Property(e => e.Address)
                .HasMaxLength(200); // Sets a max length of 200 characters

            builder.Property(e => e.Dept_Id)
                .IsRequired(); // Department ID is required

            // Relationships
            builder.HasOne(e => e.Department)
                .WithMany(d => d.Employees) // Assuming Department class has an Employees collection
                .HasForeignKey(e => e.Dept_Id);
        }
    }
}
