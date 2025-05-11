using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelGuide.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attractions",
                columns: new[] { "Id", "CityId", "Description", "EntranceFee", "History", "Name", "PhotoPath", "WorkingHours" },
                values: new object[] { 4, 1, "Исторический комплекс в центре Москвы", 1000m, "Главный общественно-политический комплекс страны", "Московский Кремль", "images/moscow-kremlin.jpg", "10:00-17:00" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "History",
                value: "Москва — столица России, крупнейший город страны.");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "History", "Name", "PhotoPath", "Population", "Region" },
                values: new object[,]
                {
                    { 2, "Санкт-Петербург — культурная столица России.", "Санкт-Петербург", "images/spb.jpg", 5392992, "Северо-Западный" },
                    { 3, "Казань — столица Республики Татарстан.", "Казань", "images/kazan.jpg", 1257391, "Приволжский" }
                });

            migrationBuilder.InsertData(
                table: "Attractions",
                columns: new[] { "Id", "CityId", "Description", "EntranceFee", "History", "Name", "PhotoPath", "WorkingHours" },
                values: new object[,]
                {
                    { 2, 2, "Один из крупнейших музеев мира", 800m, "Основан в 1764 году Екатериной II", "Эрмитаж", "images/hermitage.jpg", "10:00-18:00, выходной - понедельник" },
                    { 3, 3, "Историческая крепость", 500m, "Объект Всемирного наследия ЮНЕСКО", "Казанский Кремль", "images/kazan-kremlin.jpg", "08:00-20:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Attractions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "History",
                value: "История Москвы...");
        }
    }
}
