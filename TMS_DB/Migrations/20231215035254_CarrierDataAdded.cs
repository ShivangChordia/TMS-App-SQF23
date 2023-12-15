using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TMS_DB.Migrations
{
    /// <inheritdoc />
    public partial class CarrierDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Carriers",
                newName: "DepotCity");

            migrationBuilder.AddColumn<int>(
                name: "FTLAvailability",
                table: "Carriers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "FTLRate",
                table: "Carriers",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "LTLAvailability",
                table: "Carriers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "LTLRate",
                table: "Carriers",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ReefCharge",
                table: "Carriers",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Carriers",
                columns: new[] { "CarrierID", "CarrierName", "DepotCity", "FTLAvailability", "FTLRate", "LTLAvailability", "LTLRate", "ReefCharge" },
                values: new object[,]
                {
                    { 1, "Planet Express", "Windsor", 50, 5.21, 640, 0.36209999999999998, 0.080000000000000002 },
                    { 2, "Planet Express", "Hamilton", 50, 5.21, 640, 0.36209999999999998, 0.080000000000000002 },
                    { 3, "Planet Express", "Oshawa", 50, 5.21, 640, 0.36209999999999998, 0.080000000000000002 },
                    { 4, "Planet Express", "Belleville", 50, 5.21, 640, 0.36209999999999998, 0.080000000000000002 },
                    { 5, "Planet Express", "Ottawa", 50, 5.21, 640, 0.36209999999999998, 0.080000000000000002 },
                    { 6, "Schooner's", "London", 18, 5.0499999999999998, 98, 0.34339999999999998, 0.070000000000000007 },
                    { 7, "Schooner's", "Toronto", 18, 5.0499999999999998, 98, 0.34339999999999998, 0.070000000000000007 },
                    { 8, "Schooner's", "Kingston", 18, 5.0499999999999998, 98, 0.34339999999999998, 0.070000000000000007 },
                    { 9, "Tillman Transport", "Windsor", 24, 5.1100000000000003, 35, 0.30120000000000002, 0.089999999999999997 },
                    { 10, "Tillman Transport", "London", 18, 5.1100000000000003, 45, 0.30120000000000002, 0.089999999999999997 },
                    { 11, "Tillman Transport", "Hamilton", 18, 5.1100000000000003, 45, 0.30120000000000002, 0.089999999999999997 },
                    { 12, "We Haul", "Ottawa", 11, 5.2000000000000002, 0, 0.0, 0.065000000000000002 },
                    { 13, "We Haul", "Toronto", 11, 5.2000000000000002, 0, 0.0, 0.065000000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "CarrierID",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "FTLAvailability",
                table: "Carriers");

            migrationBuilder.DropColumn(
                name: "FTLRate",
                table: "Carriers");

            migrationBuilder.DropColumn(
                name: "LTLAvailability",
                table: "Carriers");

            migrationBuilder.DropColumn(
                name: "LTLRate",
                table: "Carriers");

            migrationBuilder.DropColumn(
                name: "ReefCharge",
                table: "Carriers");

            migrationBuilder.RenameColumn(
                name: "DepotCity",
                table: "Carriers",
                newName: "City");
        }
    }
}
