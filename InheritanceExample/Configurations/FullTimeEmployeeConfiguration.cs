﻿using InheritanceExample.Modules;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.Configurations
{
    internal class FullTimeEmployeeConfiguration : IEntityTypeConfiguration<FullTimeEmployee>
    {
        public void Configure(EntityTypeBuilder<FullTimeEmployee> builder)
        {

            builder.ToTable("FullTimeEmployees");

            // Configure common properties
           
        }
    }
}
