﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMS_DB.Migrations.MarketPlaceMigrations
{
    /// <inheritdoc />
    public partial class AddedCMP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
