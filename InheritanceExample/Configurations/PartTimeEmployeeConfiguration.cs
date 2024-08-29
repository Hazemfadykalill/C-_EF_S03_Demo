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
    internal class PartTimeEmployeeConfiguration : IEntityTypeConfiguration<PartTimeEmployee>
    {
        public void Configure(EntityTypeBuilder<PartTimeEmployee> builder)
        {

            builder.ToTable("PartTimeEmployees");

            // Configure common properties
            
        }
    }
}
