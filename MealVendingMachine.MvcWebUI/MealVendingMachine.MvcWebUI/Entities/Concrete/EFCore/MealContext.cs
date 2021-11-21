using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealVendingMachine.MvcWebUI.Entities.Concrete.EFCore
{
    public class MealContext : DbContext
    {
        public DbSet<Foods> Foods { get; set; }
        public DbSet<Beverages> Beverages { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Categories> Categories { get;  set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MealVendingMachine;Trusted_Connection=true;");
        }
    }
}
