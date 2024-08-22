using C__EF_S_01_Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S_01_Demo.Contexts
{
    internal class EnterpriseDbContext:DbContext
    {
        public EnterpriseDbContext():base()
        {
                
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Hazem;Database=Enterprise;Trusted-Connection=true");
        }
        public DbSet<Employee> Employees { get; set; }//Become Table IN Database Named==>Employees
    }
}
