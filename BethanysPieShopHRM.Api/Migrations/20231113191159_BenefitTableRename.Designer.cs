﻿// <auto-generated />
using System;
using BethanysPieShopHRM.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BethanysPieShopHRM.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231113191159_BenefitTableRename")]
    partial class BenefitTableRename
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Domain.Benefit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Premium")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Benefits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Health Insurance",
                            Premium = false
                        },
                        new
                        {
                            Id = 2,
                            Description = "Paid Time Off",
                            Premium = false
                        },
                        new
                        {
                            Id = 3,
                            Description = "Wellness",
                            Premium = true
                        },
                        new
                        {
                            Id = 4,
                            Description = "Education",
                            Premium = true
                        },
                        new
                        {
                            Id = 5,
                            Description = "Store Discount",
                            Premium = false
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Domain.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "Belgium"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "Germany"
                        },
                        new
                        {
                            CountryId = 3,
                            Name = "Netherlands"
                        },
                        new
                        {
                            CountryId = 4,
                            Name = "USA"
                        },
                        new
                        {
                            CountryId = 5,
                            Name = "Japan"
                        },
                        new
                        {
                            CountryId = 6,
                            Name = "China"
                        },
                        new
                        {
                            CountryId = 7,
                            Name = "UK"
                        },
                        new
                        {
                            CountryId = 8,
                            Name = "France"
                        },
                        new
                        {
                            CountryId = 9,
                            Name = "Brazil"
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Domain.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Smoker")
                        .HasColumnType("bit");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CountryId");

                    b.HasIndex("JobCategoryId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BirthDate = new DateTime(1979, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Brussels",
                            Comment = "Lorem Ipsum",
                            CountryId = 1,
                            Email = "bethany@bethanyspieshop.com",
                            FirstName = "Bethany",
                            Gender = 1,
                            JobCategoryId = 1,
                            JoinedDate = new DateTime(2015, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Smith",
                            Latitude = 50.850299999999997,
                            Longitude = 4.3517000000000001,
                            MaritalStatus = 1,
                            PhoneNumber = "324777888773",
                            Smoker = false,
                            Street = "Grote Markt 1",
                            Zip = "1000"
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Domain.EmployeeBenefit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BenefitId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("BenefitId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeBenefit");
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Domain.JobCategory", b =>
                {
                    b.Property<int>("JobCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobCategoryId"), 1L, 1);

                    b.Property<string>("JobCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobCategoryId");

                    b.ToTable("JobCategories");

                    b.HasData(
                        new
                        {
                            JobCategoryId = 1,
                            JobCategoryName = "Pie research"
                        },
                        new
                        {
                            JobCategoryId = 2,
                            JobCategoryName = "Sales"
                        },
                        new
                        {
                            JobCategoryId = 3,
                            JobCategoryName = "Management"
                        },
                        new
                        {
                            JobCategoryId = 4,
                            JobCategoryName = "Store staff"
                        },
                        new
                        {
                            JobCategoryId = 5,
                            JobCategoryName = "Finance"
                        },
                        new
                        {
                            JobCategoryId = 6,
                            JobCategoryName = "QA"
                        },
                        new
                        {
                            JobCategoryId = 7,
                            JobCategoryName = "IT"
                        },
                        new
                        {
                            JobCategoryId = 8,
                            JobCategoryName = "Cleaning"
                        },
                        new
                        {
                            JobCategoryId = 9,
                            JobCategoryName = "Bakery"
                        });
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Domain.Employee", b =>
                {
                    b.HasOne("BethanysPieShopHRM.Shared.Domain.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BethanysPieShopHRM.Shared.Domain.JobCategory", "JobCategory")
                        .WithMany()
                        .HasForeignKey("JobCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("JobCategory");
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Domain.EmployeeBenefit", b =>
                {
                    b.HasOne("BethanysPieShopHRM.Shared.Domain.Benefit", "Benefit")
                        .WithMany("EmployeeBenefits")
                        .HasForeignKey("BenefitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BethanysPieShopHRM.Shared.Domain.Employee", "Employee")
                        .WithMany("EmployeeBenefits")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Benefit");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Domain.Benefit", b =>
                {
                    b.Navigation("EmployeeBenefits");
                });

            modelBuilder.Entity("BethanysPieShopHRM.Shared.Domain.Employee", b =>
                {
                    b.Navigation("EmployeeBenefits");
                });
#pragma warning restore 612, 618
        }
    }
}
