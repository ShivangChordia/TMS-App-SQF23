using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TMS_DB.Migrations
{
    /// <inheritdoc />
    public partial class AdminDataUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminId", "AdminDOB", "AdminEmail", "AdminName", "AdminPassword", "AdminPhone" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1@example.com", "Admin1", "Password1", "1234567890" },
                    { 2, new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2@example.com", "Admin2", "Password2", "2345678901" },
                    { 3, new DateTime(1996, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin3@example.com", "Admin3", "Password3", "7890123456" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "AdminId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "AdminId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "AdminId",
                keyValue: 3);
        }
    }
}
