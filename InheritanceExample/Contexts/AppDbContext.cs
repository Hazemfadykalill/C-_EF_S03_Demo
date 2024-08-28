using InheritanceExample.Modules;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.Contexts
{
    internal class AppDbContext:DbContext
    {
        //Connection With Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Server = .;Database=EFS03DemoInheritanceExample;Trusted_Connection=True;TrustServerCertificate=True");
        }

        //Configuration Class
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // [To All Class In The Same Time]
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }
        //Names Table That In Database
        //TPC
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
 
    }
}
