using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TMS_DB.Migrations
{
    /// <inheritdoc />
    public partial class AddedDemoAcc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buyer",
                columns: new[] { "BuyerId", "BuyerDOB", "BuyerEmail", "BuyerName", "BuyerPassword", "BuyerPhone" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buyer1@example.com", "Buyer1", "Password1", "1234567890" },
                    { 2, new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buyer2@example.com", "Buyer2", "Password2", "2345678901" },
                    { 3, new DateTime(1996, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buyer3@example.com", "Buyer3", "Password3", "7890123456" }
                });

            migrationBuilder.InsertData(
                table: "Planner",
                columns: new[] { "PlannerId", "PlannerDOB", "PlannerEmail", "PlannerName", "PlannerPassword", "PlannerPhone" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planner1@example.com", "Planner1", "Password1", "1234567890" },
                    { 2, new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planner2@example.com", "Planner2", "Password2", "2345678901" },
                    { 3, new DateTime(1996, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planner3@example.com", "Planner3", "Password3", "7890123456" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buyer",
                keyColumn: "BuyerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Buyer",
                keyColumn: "BuyerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Buyer",
                keyColumn: "BuyerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Planner",
                keyColumn: "PlannerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Planner",
                keyColumn: "PlannerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Planner",
                keyColumn: "PlannerId",
                keyValue: 3);
        }
    }
}
