namespace DiyabOcean.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>().HasKey(p => new { p.ProductId, p.VariantId });

            modelBuilder.Entity<Variant>().HasData(
                new Variant
                {
                    Id = 1,
                    Name = "Default"
                },
                new Variant
                {
                    Id = 2,
                    Name = "Chicken"
                },
                new Variant
                {
                    Id = 3,
                    Name = "Lamb"
                }
                );

            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                    Id = 1,
                    Name = "Starters",
                    Url = "starters"
               }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Chaat",
                    Description = "Chaat, a traditional savoury snack sold by street vendors in India. A great starter or side dish served with home made puri.",
                    ImageUrl = "",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Chilli Chicken",
                    Description = "Tender & flavorful Chilli Chicken, made with chicken marinated in soy sauce, fried till crispy, sautéed with onions, peppers & sauces.",
                    ImageUrl = "",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Spicy Chicken Wings",
                    Description = "Spicy grilled chicken wings are everyone's favorite. Juicy chicken wings are marinated in hot sauce and grilled to perfection.",
                    ImageUrl = "",
                    CategoryId = 1
                }
            );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    VariantId = 2,
                    Price = 3.45m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    VariantId = 3,
                    Price = 3.95m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    VariantId = 1,
                    Price = 3.95m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    VariantId = 1,
                    Price = 3.95m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
    }
}
