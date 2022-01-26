using DAL.ModelExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StoreContext : DbContext
    {
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Campain> Campains { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<DepartmentProduct> DepartmentProducts { get; set; }

       

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            {
                builder.UseSqlServer(@"Server = LocalHost\SQLEXPRESS; Database = Upg3SojaMathiasAng; Trusted_Connection = True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}

