using C__EF_S03_Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S03_Demo.Contexts
{
    public class AppDbContext:DbContext
    {
        //Connection With Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Server = .;Database=EFS03Demo;Trusted_Connection=True;TrustServerCertificate=True");
        }

        //Configuration Class
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // [To All Class In The Same Time]
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }
        //Names Table That In Database
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}
