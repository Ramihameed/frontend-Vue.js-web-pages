using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test_3.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wheels_cars_carsId",
                table: "wheels");

            migrationBuilder.DropIndex(
                name: "IX_wheels_carsId",
                table: "wheels");

            migrationBuilder.DeleteData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "carsId",
                table: "wheels");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "cars",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "name", "price" },
                values: new object[,]
                {
                    { 1L, "Toyota", 20000 },
                    { 2L, "Honda", 22000 },
                    { 3L, "Ford", 18000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.AddColumn<int>(
                name: "carsId",
                table: "wheels",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "cars",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "name", "price" },
                values: new object[,]
                {
                    { 1, "Toyota", 20000 },
                    { 2, "Honda", 22000 },
                    { 3, "Ford", 18000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_wheels_carsId",
                table: "wheels",
                column: "carsId");

            migrationBuilder.AddForeignKey(
                name: "FK_wheels_cars_carsId",
                table: "wheels",
                column: "carsId",
                principalTable: "cars",
                principalColumn: "Id");
        }
    }
}
