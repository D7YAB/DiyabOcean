namespace DiyabOcean.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                    Price = 4.25m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Chilli Chicken",
                    Description = "Tender & flavorful Chilli Chicken, made with chicken marinated in soy sauce, fried till crispy, sautéed with onions, peppers & sauces.",
                    ImageUrl = "",
                    Price = 4.25m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Spicy Chicken Wings",
                    Description = "Spicy grilled chicken wings are everyone's favorite. Juicy chicken wings are marinated in hot sauce and grilled to perfection.",
                    ImageUrl = "",
                    Price = 4.25m,
                    CategoryId = 1
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
