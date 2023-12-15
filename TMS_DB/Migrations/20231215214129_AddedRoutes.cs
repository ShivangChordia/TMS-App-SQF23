using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TMS_DB.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoutes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RouteEndPoint",
                table: "Route",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RouteStartPoint",
                table: "Route",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<float>(
                name: "TimeInHours",
                table: "Route",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "TotalDistance",
                table: "Route",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Route",
                columns: new[] { "RouteID", "RouteEndPoint", "RouteStartPoint", "TimeInHours", "TotalDistance" },
                values: new object[,]
                {
                    { 1, "London", "Windsor", 2.5f, 191 },
                    { 2, "Windsor", "London", 2.5f, 191 },
                    { 3, "Hamilton", "London", 1.75f, 128 },
                    { 4, "London", "Hamilton", 1.75f, 128 },
                    { 5, "Toronto", "Hamilton", 1.25f, 68 },
                    { 6, "Hamilton", "Toronto", 1.25f, 68 },
                    { 7, "Oshawa", "Toronto", 1.3f, 60 },
                    { 8, "Toronto", "Oshawa", 1.3f, 60 },
                    { 9, "Belleville", "Oshawa", 1.65f, 134 },
                    { 10, "Oshawa", "Belleville", 1.65f, 134 },
                    { 11, "Kingston", "Belleville", 1.2f, 82 },
                    { 12, "Belleville", "Kingston", 1.2f, 82 },
                    { 13, "Ottawa", "Kingston", 2.5f, 196 },
                    { 14, "Kingston", "Ottawa", 2.5f, 196 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Route",
                keyColumn: "RouteID",
                keyValue: 14);

            migrationBuilder.DropColumn(
                name: "RouteEndPoint",
                table: "Route");

            migrationBuilder.DropColumn(
                name: "RouteStartPoint",
                table: "Route");

            migrationBuilder.DropColumn(
                name: "TimeInHours",
                table: "Route");

            migrationBuilder.DropColumn(
                name: "TotalDistance",
                table: "Route");
        }
    }
}
