using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyabOcean.Server.Migrations
{
    public partial class ProductSeeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 1, "Finely sliced onion smothered in a simple, fragrantly spiced batter and fried to crispy perfection", "https://www.kitchensanctuary.com/wp-content/uploads/2021/01/Onion-Bhaji-tall-FS-40.webp", "Onion Bhajee", 2.80m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 2, "Aromatic golden chicken pieces in an incredible creamy curry sauce", "https://cafedelites.com/wp-content/uploads/2019/01/Butter-Chicken-IMAGE-27.jpg", "Butter Chicken", 8.45m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "ImageURL", "Name", "Price" },
                values: new object[] { 3, "Soft fluffy naan bread, brushed with melted garlic butter.", "https://www.kitchensanctuary.com/wp-content/uploads/2021/03/Garlic-Naan-tall-FS-27.webp", "Garlic Naan", 2.70m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
