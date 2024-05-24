﻿// <auto-generated />
using EmployeeCrud.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeCrud.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240522104916_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeCrud.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Deparment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Address = "İzmir",
                            Deparment = "Software Developer",
                            Firstname = "Görkem",
                            Lastname = "Uçar"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Address = "Ankara",
                            Deparment = "IT",
                            Firstname = "Ali",
                            Lastname = "Al"
                        },
                        new
                        {
                            EmployeeId = 3,
                            Address = "Ankara",
                            Deparment = "IT",
                            Firstname = "Deniz",
                            Lastname = "Dağ"
                        },
                        new
                        {
                            EmployeeId = 4,
                            Address = "Antalya",
                            Deparment = "Software Developer",
                            Firstname = "Cemre",
                            Lastname = "Kaya"
                        },
                        new
                        {
                            EmployeeId = 5,
                            Address = "Bursa",
                            Deparment = "IT",
                            Firstname = "Ahmet",
                            Lastname = "Uzun"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
