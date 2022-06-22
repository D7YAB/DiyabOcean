namespace DiyabOcean.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Starters",
                    Url = "starters"
                },
                new Category
                {
                    Id = 2,
                    Name = "Diyab Ocean Uniques",
                    Url = "diyab-ocean-uniques"
                },
                new Category
                {
                    Id = 3,
                    Name = "Naan & Breads",
                    Url = "naan-breads"
                });

            modelbuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Name = "Onion Bhajee",
                    Description = "Finely sliced onion smothered in a simple, fragrantly spiced batter and fried to crispy perfection",
                    ImageURL = "https://www.kitchensanctuary.com/wp-content/uploads/2021/01/Onion-Bhaji-tall-FS-40.webp",
                    Price = 2.80m,
                    CategoryId = 1
                    

                },
                new Product
                {
                    ID = 2,
                    Name = "Butter Chicken",
                    Description = "Aromatic golden chicken pieces in an incredible creamy curry sauce",
                    ImageURL = "https://cafedelites.com/wp-content/uploads/2019/01/Butter-Chicken-IMAGE-27.jpg",
                    Price = 8.45m,
                    CategoryId = 2

                },
                new Product
                {
                    ID = 3,
                    Name = "Garlic Naan",
                    Description = "Soft fluffy naan bread, brushed with melted garlic butter.",
                    ImageURL = "https://www.kitchensanctuary.com/wp-content/uploads/2021/03/Garlic-Naan-tall-FS-27.webp",
                    Price = 2.70m,
                    CategoryId = 3

                });
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
