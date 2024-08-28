using InheritanceExample.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {


            // Configure common properties
            builder.ToTable("Employees");
            
            builder.Property(e => e.Name).HasColumnType("varchar")  .HasMaxLength(255);
            builder.Property(e => e.Email).HasColumnType("varchar") .HasMaxLength(255);
            builder.Property(e => e.Address).HasColumnType("varchar").HasMaxLength(255);
        }
    }
}
