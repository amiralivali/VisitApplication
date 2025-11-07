using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Visit.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkingTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartWorkingTime",
                table: "Doctors",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndWorkingTime",
                table: "Doctors",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndWorkingTime",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "StartWorkingTime",
                table: "Doctors");
        }
    }
}
