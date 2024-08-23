using C__EF_S_01_Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S_01_Demo.Contexts
{
    internal class EnterpriseDbContext : DbContext
    {
        #region Convention And Annotation
        public EnterpriseDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Enterprise;Trusted_Connection=true;TrustServerCertificate=True;");
        }
        public DbSet<Employee> Employees { get; set; }//Become Table IN Database Named==>Employees
        public DbSet<Department> Departments { get; set; }//Become Table IN Database Named==>Departments
        public DbSet<Project> Projects { get; set; }//Become Table IN Database Named==>Departments 
        #endregion


        #region Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Type (1)
            //modelBuilder.Entity<Employee>().HasKey(E => E.Id);//Primary Key Is Called Id
            //modelBuilder.Entity<Employee>().
            //    //  Property(E=>E.Id).
            //    //  Property("Id").
            //    Property(nameof(Employee.Id)).
            //    UseIdentityColumn(1, 1);//Add Constraint On Primary Key Is Called Id

            //modelBuilder.Entity<Employee>().
            //     Property(nameof(Employee.Name)).
            //     HasColumnType("Varchar").
            //     HasMaxLength(50).
            //     HasDefaultValue("Ahmed");

            //modelBuilder.Entity<Employee>().
            //Property(nameof(Employee.Salary)).
            //HasColumnType("Money"); 
            #endregion
            #region Type (2)
            //modelBuilder.Entity<Employee>(E =>
            //{

            //    E.HasKey(E => E.Id);//Primary Key Is Called Id
            //    E.
            //        //  Property(E=>E.Id).
            //        //  Property("Id").
            //        Property(nameof(Employee.Id)).
            //        UseIdentityColumn(1, 1);//Add Constraint On Primary Key Is Called Id

            //    E.
            //         Property(nameof(Employee.Name)).
            //         HasColumnType("Varchar").
            //         HasMaxLength(50).
            //         HasDefaultValue("Ahmed");

            //    E.
            //    Property(nameof(Employee.Salary)).
            //    HasColumnType("Money");
            //});
            #endregion



        }
        #endregion
    }
}
