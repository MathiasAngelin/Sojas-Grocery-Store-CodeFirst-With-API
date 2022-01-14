using Microsoft.EntityFrameworkCore;

namespace DAL.ModelExtensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {


            var emp1 = new Employee { EmployeeId = 1, Personnumber = "19910918", FirstName = "Adam", LastName = "Adolfsson" };
            var emp2 = new Employee { EmployeeId = 2, Personnumber = "19900211", FirstName = "Berit", LastName = "Bengtsson" };
            var emp3 = new Employee { EmployeeId = 3, Personnumber = "19801121", FirstName = "Carl", LastName = "Carlsson" };
            var emp4 = new Employee { EmployeeId = 4, Personnumber = "19700121", FirstName = "David", LastName = "Davidsson" };
            var emp5 = new Employee { EmployeeId = 5, Personnumber = "19641121", FirstName = "Erik", LastName = "Eriksson" };
            var emp6 = new Employee { EmployeeId = 6, Personnumber = "19641122", FirstName = "Fredrik", LastName = "Fredriksson" };

            modelBuilder.Entity<Employee>().HasData(
               emp1, emp2, emp3, emp4, emp5, emp6
               );

            var ema1 = new Email { EmailId = 1, EmailAddress = "Adam@hotmail.com", EmployeeId = emp1.EmployeeId };
            var ema2 = new Email { EmailId = 2, EmailAddress = "Berit@hotmail.com", EmployeeId = emp2.EmployeeId };
            var ema3 = new Email { EmailId = 3, EmailAddress = "Berit@gmail.com", EmployeeId = emp2.EmployeeId };
            var ema4 = new Email { EmailId = 4, EmailAddress = "David@hotmail.com", EmployeeId = emp3.EmployeeId };
            var ema5 = new Email { EmailId = 5, EmailAddress = "Carl@hotmail.com", EmployeeId = emp4.EmployeeId };
            var ema6 = new Email { EmailId = 6, EmailAddress = "Erik@hotmail.com", EmployeeId = emp5.EmployeeId };
            var ema7 = new Email { EmailId = 7, EmailAddress = "Fredirk@hotmail.com", EmployeeId = emp6.EmployeeId };

            modelBuilder.Entity<Email>().HasData(
               ema1, ema2, ema4, ema5, ema6, ema7, ema3
                );


            var tel1 = new Telephone { TelephoneId = 1, EmployeeId = emp1.EmployeeId, PhoneNumber = "12345" };
            var tel2 = new Telephone { TelephoneId = 2, EmployeeId = emp2.EmployeeId, PhoneNumber = "145" };
            var tel3 = new Telephone { TelephoneId = 3, EmployeeId = emp3.EmployeeId, PhoneNumber = "1243145" };
            var tel4 = new Telephone { TelephoneId = 4, EmployeeId = emp4.EmployeeId, PhoneNumber = "321" };
            var tel5 = new Telephone { TelephoneId = 5, EmployeeId = emp5.EmployeeId, PhoneNumber = "3245" };
            var tel6 = new Telephone { TelephoneId = 6, EmployeeId = emp6.EmployeeId, PhoneNumber = "124" };

            modelBuilder.Entity<Telephone>().HasData(
             tel1, tel2, tel3, tel4, tel5, tel6
               );


            var camp1 = new Campain { CampainId = 1, Pricedrop = 0.75F };
            modelBuilder.Entity<Campain>().HasData(
                camp1
                );

            var pro1 = new Product { Barcode = 1, ProductName = "Kyckling", ListOfIngredients = "Kyckling, vatten", Price = 13, ExpirationDate = new DateTime(2023, 01, 22), NumberInStore = 12, DateOfLastCheck = new DateTime(2022, 01, 01), EmployeeId = ema2.EmployeeId, CampainId = camp1.CampainId, };
            var pro2 = new Product { Barcode = 2, ProductName = "Pasta", ListOfIngredients = "Havre, durum", Price = 23, ExpirationDate = new DateTime(2024, 05, 21), NumberInStore = 3, DateOfLastCheck = new DateTime(2021, 02, 01), EmployeeId = ema1.EmployeeId, };
            var pro3 = new Product { Barcode = 3, ProductName = "Lingon", ListOfIngredients = "Lingon, Socker", Price = 24, ExpirationDate = new DateTime(2025, 11, 02), NumberInStore = 2, DateOfLastCheck = new DateTime(2020, 03, 01), EmployeeId = ema2.EmployeeId, };
            var pro4 = new Product { Barcode = 4, ProductName = "Havredryck", ListOfIngredients = "Havre, vatten", Price = 14, ExpirationDate = new DateTime(2025, 02, 22), NumberInStore = 2, DateOfLastCheck = new DateTime(2021, 04, 01), EmployeeId = ema3.EmployeeId, };
            var pro5 = new Product { Barcode = 5, ProductName = "Pepsi", ListOfIngredients = "Sötningsmedel, vatten", Price = 18, ExpirationDate = new DateTime(2023, 01, 22), NumberInStore = 2, DateOfLastCheck = new DateTime(2021, 05, 22), EmployeeId = ema4.EmployeeId, CampainId = camp1.CampainId, };
            var pro6 = new Product { Barcode = 6, ProductName = "Lingongrova", ListOfIngredients = "Havre, Sirap", Price = 22, ExpirationDate = new DateTime(2022, 02, 02), NumberInStore = 2, DateOfLastCheck = new DateTime(2021, 06, 01), EmployeeId = ema5.EmployeeId, };
            var pro7 = new Product { Barcode = 7, ProductName = "Senap", ListOfIngredients = "Senapsfrön, vatten", Price = 26, ExpirationDate = new DateTime(2023, 05, 11), NumberInStore = 3, DateOfLastCheck = new DateTime(2021, 07, 22), EmployeeId = ema6.EmployeeId, };
            var pro8 = new Product { Barcode = 8, ProductName = "Köttfärs", ListOfIngredients = "Köttfärs, Fett", Price = 89, ExpirationDate = new DateTime(2022, 02, 01), NumberInStore = 5, DateOfLastCheck = new DateTime(2021, 08, 01), EmployeeId = ema2.EmployeeId, CampainId = camp1.CampainId, };
            var pro9 = new Product { Barcode = 9, ProductName = "Gurka", ListOfIngredients = "Gurka, vatten", Price = 13, ExpirationDate = new DateTime(2022, 01, 22), NumberInStore = 2, DateOfLastCheck = new DateTime(2021, 09, 11), EmployeeId = ema1.EmployeeId, CampainId = camp1.CampainId, };
           
            modelBuilder.Entity<Product>().HasData(
                pro1, pro2, pro3, pro4, pro5, pro6, pro7, pro8, pro9
                );


            var dep1 = new Department { DepartmentId = 1, Name = "Dairy", EmployeeId = emp2.EmployeeId };
            var dep2 = new Department { DepartmentId = 2, Name = "Bread", EmployeeId = emp2.EmployeeId };
            var dep3 = new Department { DepartmentId = 3, Name = "Drinks", EmployeeId = emp3.EmployeeId };
            var dep4 = new Department { DepartmentId = 4, Name = "Meat", EmployeeId = emp5.EmployeeId };
            var dep5 = new Department { DepartmentId = 5, Name = "Other", EmployeeId = emp6.EmployeeId };

            modelBuilder.Entity<Department>().HasData(
               dep1, dep2, dep3, dep4, dep5
                );

            var prodep1 = new DepartmentProduct { DepartmentId = 1, ProductId = 1 };
            var prodep2 = new DepartmentProduct { DepartmentId = 1, ProductId = 2 };
            var prodep3 = new DepartmentProduct { DepartmentId = 1, ProductId = 3 };
            var prodep4 = new DepartmentProduct { DepartmentId = 1, ProductId = 4 };
            var prodep5 = new DepartmentProduct { DepartmentId = 1, ProductId = 5 };
            var prodep6 = new DepartmentProduct { DepartmentId = 2, ProductId = 6 };
            var prodep7 = new DepartmentProduct { DepartmentId = 2, ProductId = 5 };
            var prodep8 = new DepartmentProduct { DepartmentId = 2, ProductId = 7 };
            var prodep9 = new DepartmentProduct { DepartmentId = 2, ProductId = 8 };
            var prodep10 = new DepartmentProduct { DepartmentId = 2, ProductId = 9 };
            var prodep11 = new DepartmentProduct { DepartmentId = 2, ProductId = 1 };
            var prodep12 = new DepartmentProduct { DepartmentId = 3, ProductId = 2 };
            var prodep13 = new DepartmentProduct { DepartmentId = 3, ProductId = 3 };
            var prodep14 = new DepartmentProduct { DepartmentId = 3, ProductId = 4 };
            var prodep15 = new DepartmentProduct { DepartmentId = 3, ProductId = 5 };
            var prodep16 = new DepartmentProduct { DepartmentId = 3, ProductId = 6 };
            var prodep17 = new DepartmentProduct { DepartmentId = 3, ProductId = 7 };
            var prodep18 = new DepartmentProduct { DepartmentId = 4, ProductId = 8 };
            var prodep19 = new DepartmentProduct { DepartmentId = 4, ProductId = 9 };
            var prodep20 = new DepartmentProduct { DepartmentId = 4, ProductId = 1 };
            var prodep21 = new DepartmentProduct { DepartmentId = 4, ProductId = 2 };
            var prodep30 = new DepartmentProduct { DepartmentId = 4, ProductId = 3 };
            var prodep23 = new DepartmentProduct { DepartmentId = 4, ProductId = 4 };
            var prodep24 = new DepartmentProduct { DepartmentId = 5, ProductId = 5 };
            var prodep25 = new DepartmentProduct { DepartmentId = 5, ProductId = 6 };
            var prodep26 = new DepartmentProduct { DepartmentId = 5, ProductId = 7 };
            var prodep27 = new DepartmentProduct { DepartmentId = 5, ProductId = 8 };
            var prodep28 = new DepartmentProduct { DepartmentId = 5, ProductId = 9 };
            var prodep29 = new DepartmentProduct { DepartmentId = 5, ProductId = 1 };

            modelBuilder.Entity<DepartmentProduct>().HasData(
               prodep1, prodep2, prodep3, prodep4, prodep5, prodep6, prodep7, prodep8, prodep9, prodep10, prodep11, prodep12, prodep13, prodep14, prodep15, prodep16, prodep17, prodep18, prodep19, prodep20, prodep21, prodep30, prodep23, prodep24, prodep25, prodep26, prodep27, prodep28, prodep29
                );


            var men1 = new Mentorship { MentoredById = emp1.EmployeeId, MentoredForId = emp2.EmployeeId };
            var men2 = new Mentorship { MentoredById = emp3.EmployeeId, MentoredForId = emp1.EmployeeId };
            var men3 = new Mentorship { MentoredById = emp4.EmployeeId, MentoredForId = emp3.EmployeeId };
            var men4 = new Mentorship { MentoredById = emp5.EmployeeId, MentoredForId = emp1.EmployeeId };

            modelBuilder.Entity<Mentorship>().HasData(
              men1, men2, men3, men4
               );


            modelBuilder.Entity<Employee>()
            .HasMany(e => e.Telephones)
             .WithOne(e => e.Employee)
             .HasForeignKey(e => e.EmployeeId);

            modelBuilder.Entity<Employee>()
            .HasMany(e => e.Emails)
            .WithOne(e => e.Employee)
            .HasForeignKey(e => e.EmployeeId);

            modelBuilder.Entity<Department>()
           .HasOne(e => e.Employees)
           .WithMany(e => e.Departments)
           .HasForeignKey(e => e.EmployeeId)
           ;

            modelBuilder.Entity<Product>()
                .HasOne(c => c.PartOfCampain)
                .WithMany(c => c.ProductInCampain)
                .HasForeignKey(c => c.CampainId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .HasOne(e => e.Employees)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.EmployeeId)
                ;

            modelBuilder.Entity<DepartmentProduct>()
                .HasKey(DP => new { DP.ProductId, DP.DepartmentId });

            modelBuilder.Entity<DepartmentProduct>()
                .HasOne(p => p.Product)
                .WithMany(d => d.DepartmentProduct)
                .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<DepartmentProduct>()
               .HasOne(d => d.Department)
               .WithMany(d => d.DepartmentProduct)
               .HasForeignKey(p => p.DepartmentId);

            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.Personnumber)
                .IsUnique();


            modelBuilder.Entity<Mentorship>()
                .HasKey(DP => new { DP.MentoredForId, DP.MentoredById });

            modelBuilder.Entity<Mentorship>()
             .HasOne(pt => pt.EMentoredFor)
            .WithMany(p => p.MentoredBy) 
             .HasForeignKey(pt => pt.MentoredForId)
             .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Mentorship>()
                .HasOne(pt => pt.EMentoredBy)
                .WithMany(t => t.MentorFor)
                .HasForeignKey(pt => pt.MentoredById);
        }


    }
}