﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_3.Data;

#nullable disable

namespace Test_3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250310112748_prduct")]
    partial class prduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Test_3.Models.cars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            name = "Toyota",
                            price = 20000
                        },
                        new
                        {
                            Id = 2,
                            name = "Honda",
                            price = 22000
                        },
                        new
                        {
                            Id = 3,
                            name = "Ford",
                            price = 18000
                        });
                });

            modelBuilder.Entity("Test_3.Models.wheels", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("carsId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pressure")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("carsId");

                    b.ToTable("wheels");
                });

            modelBuilder.Entity("Test_3.Models.wheels", b =>
                {
                    b.HasOne("Test_3.Models.cars", null)
                        .WithMany("Wheels")
                        .HasForeignKey("carsId");
                });

            modelBuilder.Entity("Test_3.Models.cars", b =>
                {
                    b.Navigation("Wheels");
                });
#pragma warning restore 612, 618
        }
    }
}
