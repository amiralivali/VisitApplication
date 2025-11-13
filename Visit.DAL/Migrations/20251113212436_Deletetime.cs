using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Visit.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Deletetime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Visits");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Visits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Visits");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Visits",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "Visits",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
