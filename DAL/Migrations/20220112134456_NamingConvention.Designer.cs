﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20220112134456_NamingConvention")]
    partial class NamingConvention
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Campain", b =>
                {
                    b.Property<int>("CampainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CampainId"), 1L, 1);

                    b.Property<float>("Pricedrop")
                        .HasColumnType("real");

                    b.HasKey("CampainId");

                    b.ToTable("Campains");

                    b.HasData(
                        new
                        {
                            CampainId = 1,
                            Pricedrop = 0.75f
                        });
                });

            modelBuilder.Entity("DAL.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            EmployeeId = 1,
                            Name = "Dairy"
                        },
                        new
                        {
                            DepartmentId = 2,
                            EmployeeId = 1,
                            Name = "Bread"
                        },
                        new
                        {
                            DepartmentId = 3,
                            EmployeeId = 3,
                            Name = "Drinks"
                        },
                        new
                        {
                            DepartmentId = 4,
                            EmployeeId = 5,
                            Name = "Meat"
                        },
                        new
                        {
                            DepartmentId = 5,
                            EmployeeId = 6,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("DAL.DepartmentProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentProducts");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            DepartmentId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            DepartmentId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            DepartmentId = 1
                        },
                        new
                        {
                            ProductId = 4,
                            DepartmentId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            DepartmentId = 2
                        },
                        new
                        {
                            ProductId = 6,
                            DepartmentId = 2
                        },
                        new
                        {
                            ProductId = 7,
                            DepartmentId = 3
                        },
                        new
                        {
                            ProductId = 8,
                            DepartmentId = 3
                        },
                        new
                        {
                            ProductId = 9,
                            DepartmentId = 3
                        },
                        new
                        {
                            ProductId = 1,
                            DepartmentId = 4
                        },
                        new
                        {
                            ProductId = 2,
                            DepartmentId = 4
                        },
                        new
                        {
                            ProductId = 3,
                            DepartmentId = 4
                        },
                        new
                        {
                            ProductId = 4,
                            DepartmentId = 5
                        },
                        new
                        {
                            ProductId = 5,
                            DepartmentId = 5
                        },
                        new
                        {
                            ProductId = 6,
                            DepartmentId = 5
                        },
                        new
                        {
                            ProductId = 7,
                            DepartmentId = 5
                        });
                });

            modelBuilder.Entity("DAL.Email", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmailId"), 1L, 1);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("EmailId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Emails");

                    b.HasData(
                        new
                        {
                            EmailId = 1,
                            EmailAddress = "Adam@hotmail.com",
                            EmployeeId = 1
                        },
                        new
                        {
                            EmailId = 2,
                            EmailAddress = "Berit@hotmail.com",
                            EmployeeId = 2
                        },
                        new
                        {
                            EmailId = 4,
                            EmailAddress = "David@hotmail.com",
                            EmployeeId = 3
                        },
                        new
                        {
                            EmailId = 5,
                            EmailAddress = "Carl@hotmail.com",
                            EmployeeId = 4
                        },
                        new
                        {
                            EmailId = 6,
                            EmailAddress = "Erik@hotmail.com",
                            EmployeeId = 5
                        },
                        new
                        {
                            EmailId = 7,
                            EmailAddress = "Fredirk@hotmail.com",
                            EmployeeId = 6
                        },
                        new
                        {
                            EmailId = 3,
                            EmailAddress = "Berit@gmail.com",
                            EmployeeId = 2
                        });
                });

            modelBuilder.Entity("DAL.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Personnumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("Personnumber")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            FirstName = "Adam",
                            LastName = "Adolfsson",
                            Personnumber = "19910918"
                        },
                        new
                        {
                            EmployeeId = 2,
                            FirstName = "Berit",
                            LastName = "Bengtsson",
                            Personnumber = "19900211"
                        },
                        new
                        {
                            EmployeeId = 3,
                            FirstName = "Carl",
                            LastName = "Carlsson",
                            Personnumber = "19801121"
                        },
                        new
                        {
                            EmployeeId = 4,
                            FirstName = "David",
                            LastName = "Davidsson",
                            Personnumber = "19700121"
                        },
                        new
                        {
                            EmployeeId = 5,
                            FirstName = "Erik",
                            LastName = "Eriksson",
                            Personnumber = "19641121"
                        },
                        new
                        {
                            EmployeeId = 6,
                            FirstName = "Fredrik",
                            LastName = "Fredriksson",
                            Personnumber = "19641122"
                        });
                });

            modelBuilder.Entity("DAL.Mentorship", b =>
                {
                    b.Property<int>("MentoredForId")
                        .HasColumnType("int");

                    b.Property<int>("MentoredById")
                        .HasColumnType("int");

                    b.HasKey("MentoredForId", "MentoredById");

                    b.HasIndex("MentoredById");

                    b.ToTable("Mentorship");

                    b.HasData(
                        new
                        {
                            MentoredForId = 2,
                            MentoredById = 1
                        },
                        new
                        {
                            MentoredForId = 1,
                            MentoredById = 3
                        },
                        new
                        {
                            MentoredForId = 3,
                            MentoredById = 4
                        },
                        new
                        {
                            MentoredForId = 1,
                            MentoredById = 5
                        });
                });

            modelBuilder.Entity("DAL.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int?>("CampainId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfLastCheck")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ListOfIngredients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberInStore")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CampainId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CampainId = 1,
                            DateOfLastCheck = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 2,
                            ExpirationDate = new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListOfIngredients = "Kyckling, vatten",
                            NumberInStore = 12,
                            Price = 13f,
                            ProductName = "Kyckling"
                        },
                        new
                        {
                            ProductId = 2,
                            DateOfLastCheck = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 1,
                            ExpirationDate = new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListOfIngredients = "Havre, durum",
                            NumberInStore = 3,
                            Price = 23f,
                            ProductName = "Pasta"
                        },
                        new
                        {
                            ProductId = 3,
                            DateOfLastCheck = new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 2,
                            ExpirationDate = new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListOfIngredients = "Lingon, Socker",
                            NumberInStore = 2,
                            Price = 24f,
                            ProductName = "Lingon"
                        },
                        new
                        {
                            ProductId = 4,
                            DateOfLastCheck = new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 2,
                            ExpirationDate = new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListOfIngredients = "Havre, vatten",
                            NumberInStore = 2,
                            Price = 14f,
                            ProductName = "Havredryck"
                        },
                        new
                        {
                            ProductId = 5,
                            CampainId = 1,
                            DateOfLastCheck = new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 3,
                            ExpirationDate = new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListOfIngredients = "Sötningsmedel, vatten",
                            NumberInStore = 2,
                            Price = 18f,
                            ProductName = "Pepsi"
                        },
                        new
                        {
                            ProductId = 6,
                            DateOfLastCheck = new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 4,
                            ExpirationDate = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListOfIngredients = "Havre, Sirap",
                            NumberInStore = 2,
                            Price = 22f,
                            ProductName = "Lingongrova"
                        },
                        new
                        {
                            ProductId = 7,
                            DateOfLastCheck = new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 5,
                            ExpirationDate = new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListOfIngredients = "Senapsfrön, vatten",
                            NumberInStore = 3,
                            Price = 26f,
                            ProductName = "Senap"
                        },
                        new
                        {
                            ProductId = 8,
                            CampainId = 1,
                            DateOfLastCheck = new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 2,
                            ExpirationDate = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListOfIngredients = "Köttfärs, Fett",
                            NumberInStore = 5,
                            Price = 89f,
                            ProductName = "Köttfärs"
                        },
                        new
                        {
                            ProductId = 9,
                            CampainId = 1,
                            DateOfLastCheck = new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 1,
                            ExpirationDate = new DateTime(2022, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ListOfIngredients = "Gurka, vatten",
                            NumberInStore = 2,
                            Price = 13f,
                            ProductName = "Gurka"
                        });
                });

            modelBuilder.Entity("DAL.Telephone", b =>
                {
                    b.Property<int>("TelephoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TelephoneId"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TelephoneId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Telephones");

                    b.HasData(
                        new
                        {
                            TelephoneId = 1,
                            EmployeeId = 1,
                            PhoneNumber = "12345"
                        },
                        new
                        {
                            TelephoneId = 2,
                            EmployeeId = 2,
                            PhoneNumber = "145"
                        },
                        new
                        {
                            TelephoneId = 3,
                            EmployeeId = 3,
                            PhoneNumber = "1243145"
                        },
                        new
                        {
                            TelephoneId = 4,
                            EmployeeId = 4,
                            PhoneNumber = "321"
                        },
                        new
                        {
                            TelephoneId = 5,
                            EmployeeId = 5,
                            PhoneNumber = "3245"
                        },
                        new
                        {
                            TelephoneId = 6,
                            EmployeeId = 6,
                            PhoneNumber = "124"
                        });
                });

            modelBuilder.Entity("DAL.Department", b =>
                {
                    b.HasOne("DAL.Employee", "Employees")
                        .WithMany("Departments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DAL.DepartmentProduct", b =>
                {
                    b.HasOne("DAL.Department", "Department")
                        .WithMany("DepartmentProduct")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Product", "Product")
                        .WithMany("DepartmentProduct")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAL.Email", b =>
                {
                    b.HasOne("DAL.Employee", "Employee")
                        .WithMany("Emails")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DAL.Mentorship", b =>
                {
                    b.HasOne("DAL.Employee", "EMentoredBy")
                        .WithMany("MentorFor")
                        .HasForeignKey("MentoredById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Employee", "EMentoredFor")
                        .WithMany("MentoredBy")
                        .HasForeignKey("MentoredForId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("EMentoredBy");

                    b.Navigation("EMentoredFor");
                });

            modelBuilder.Entity("DAL.Product", b =>
                {
                    b.HasOne("DAL.Campain", "PartOfCampain")
                        .WithMany("ProductInCampain")
                        .HasForeignKey("CampainId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Employee", "Employees")
                        .WithMany("Products")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employees");

                    b.Navigation("PartOfCampain");
                });

            modelBuilder.Entity("DAL.Telephone", b =>
                {
                    b.HasOne("DAL.Employee", "Employee")
                        .WithMany("Telephones")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DAL.Campain", b =>
                {
                    b.Navigation("ProductInCampain");
                });

            modelBuilder.Entity("DAL.Department", b =>
                {
                    b.Navigation("DepartmentProduct");
                });

            modelBuilder.Entity("DAL.Employee", b =>
                {
                    b.Navigation("Departments");

                    b.Navigation("Emails");

                    b.Navigation("MentorFor");

                    b.Navigation("MentoredBy");

                    b.Navigation("Products");

                    b.Navigation("Telephones");
                });

            modelBuilder.Entity("DAL.Product", b =>
                {
                    b.Navigation("DepartmentProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
