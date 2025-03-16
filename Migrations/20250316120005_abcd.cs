using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test_3.Migrations
{
    /// <inheritdoc />
    public partial class abcd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "wheels",
                columns: new[] { "id", "name", "pressure" },
                values: new object[,]
                {
                    { 1, "Toyota", 2000f },
                    { 2, "Honda", 2200f },
                    { 3, "Ford", 1800f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "wheels",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "wheels",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "wheels",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
