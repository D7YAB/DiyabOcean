// <auto-generated />
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
    [Migration("20220622103344_Categories")]
    partial class Categories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
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
                        },
                        new
                        {
                            Id = 2,
                            Name = "Diyab Ocean Uniques",
                            Url = "diyab-ocean-uniques"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Naan & Breads",
                            Url = "naan-breads"
                        });
                });

            modelBuilder.Entity("DiyabOcean.Shared.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryId = 1,
                            Description = "Finely sliced onion smothered in a simple, fragrantly spiced batter and fried to crispy perfection",
                            ImageURL = "https://www.kitchensanctuary.com/wp-content/uploads/2021/01/Onion-Bhaji-tall-FS-40.webp",
                            Name = "Onion Bhajee",
                            Price = 2.80m
                        },
                        new
                        {
                            ID = 2,
                            CategoryId = 2,
                            Description = "Aromatic golden chicken pieces in an incredible creamy curry sauce",
                            ImageURL = "https://cafedelites.com/wp-content/uploads/2019/01/Butter-Chicken-IMAGE-27.jpg",
                            Name = "Butter Chicken",
                            Price = 8.45m
                        },
                        new
                        {
                            ID = 3,
                            CategoryId = 3,
                            Description = "Soft fluffy naan bread, brushed with melted garlic butter.",
                            ImageURL = "https://www.kitchensanctuary.com/wp-content/uploads/2021/03/Garlic-Naan-tall-FS-27.webp",
                            Name = "Garlic Naan",
                            Price = 2.70m
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
