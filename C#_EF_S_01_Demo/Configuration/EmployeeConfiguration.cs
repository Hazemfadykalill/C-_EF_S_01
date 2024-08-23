using C__EF_S_01_Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__EF_S_01_Demo.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.Id);//Primary Key Is Called Id
            builder.
                //  Property(E=>E.Id).
                //  Property("Id").
                Property(nameof(Employee.Id)).
                UseIdentityColumn(1, 1);//Add Constraint On Primary Key Is Called Id

            builder.
                 Property(nameof(Employee.Name)).
                 HasColumnType("Varchar").
                 HasMaxLength(50).
                 HasDefaultValue("Ahmed");

            builder.
            Property(nameof(Employee.Salary)).
            HasColumnType("Money");
        }
    }
}
