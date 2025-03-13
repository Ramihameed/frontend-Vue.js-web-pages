using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_3.Migrations
{
    /// <inheritdoc />
    public partial class prduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "cars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cars",
                table: "cars",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "wheels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pressure = table.Column<int>(type: "int", nullable: false),
                    carsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wheels", x => x.id);
                    table.ForeignKey(
                        name: "FK_wheels_cars_carsId",
                        column: x => x.carsId,
                        principalTable: "cars",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_wheels_carsId",
                table: "wheels",
                column: "carsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wheels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cars",
                table: "cars");

            migrationBuilder.RenameTable(
                name: "cars",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }
    }
}
