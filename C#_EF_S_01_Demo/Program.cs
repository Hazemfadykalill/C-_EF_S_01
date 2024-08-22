using C__EF_S_01_Demo.Contexts;
using Microsoft.EntityFrameworkCore;

namespace C__EF_S_01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterpriseDbContext dbContext = new EnterpriseDbContext();
            //By Code
           // dbContext.Database.Migrate();
        }
    }
}
