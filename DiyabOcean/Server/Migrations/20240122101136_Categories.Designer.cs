﻿// <auto-generated />
using DiyabOcean.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiyabOcean.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240122101136_Categories")]
    partial class Categories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DiyabOcean.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Starters",
                            Url = "starters"
                        });
                });

            modelBuilder.Entity("DiyabOcean.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Chaat, a traditional savoury snack sold by street vendors in India. A great starter or side dish served with home made puri.",
                            ImageUrl = "",
                            Price = 4.25m,
                            Title = "Chaat"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Tender & flavorful Chilli Chicken, made with chicken marinated in soy sauce, fried till crispy, sautéed with onions, peppers & sauces.",
                            ImageUrl = "",
                            Price = 4.25m,
                            Title = "Chilli Chicken"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Spicy grilled chicken wings are everyone's favorite. Juicy chicken wings are marinated in hot sauce and grilled to perfection.",
                            ImageUrl = "",
                            Price = 4.25m,
                            Title = "Spicy Chicken Wings"
                        });
                });

            modelBuilder.Entity("DiyabOcean.Shared.Product", b =>
                {
                    b.HasOne("DiyabOcean.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
