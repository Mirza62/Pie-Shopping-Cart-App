﻿// <auto-generated />
using BethanysPie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BethanysPie.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210531144358_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BethanysPie.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Fruit Pies",
                            Description = "All Fruity Pies"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Cheese Cakes",
                            Description = "Cheese all the way"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Seasonal Pies",
                            Description = "Get in mood for a seasonal pie"
                        });
                });

            modelBuilder.Entity("BethanysPie.Models.Pie", b =>
                {
                    b.Property<int>("PieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbNailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPieOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pies");

                    b.HasData(
                        new
                        {
                            PieId = 1,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbNailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "Lorem Ipsum",
                            Name = "Strawberry Pie",
                            Price = 15.95m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            PieId = 2,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbNailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "Lorem Ipsum",
                            Name = "Cheese Cake",
                            Price = 18.95m,
                            ShortDescription = "Lorem Ipsum"
                        },
                        new
                        {
                            PieId = 3,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbNailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "Lorem Ipsum",
                            Name = "Rhubarb Pie",
                            Price = 15.95m,
                            ShortDescription = "Lorem Ipsum"
                        });
                });

            modelBuilder.Entity("BethanysPie.Models.Pie", b =>
                {
                    b.HasOne("BethanysPie.Models.Category", "Category")
                        .WithMany("Pies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
