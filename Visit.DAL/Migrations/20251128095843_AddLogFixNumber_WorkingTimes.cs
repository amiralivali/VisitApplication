using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Visit.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddLogFixNumber_WorkingTimes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Doctor Takhasos_Doctors_DoctorID",
                table: "Tbl_Doctor Takhasos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Doctor Takhasos_Takhasoses_TakhasosID",
                table: "Tbl_Doctor Takhasos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Doctor Takhasos",
                table: "Tbl_Doctor Takhasos");

            migrationBuilder.RenameTable(
                name: "Tbl_Doctor Takhasos",
                newName: "Doctor_Takhasoses");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_Doctor Takhasos_TakhasosID",
                table: "Doctor_Takhasoses",
                newName: "IX_Doctor_Takhasoses_TakhasosID");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_Doctor Takhasos_DoctorID",
                table: "Doctor_Takhasoses",
                newName: "IX_Doctor_Takhasoses_DoctorID");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNumber",
                table: "Users",
                type: "char(11)",
                unicode: false,
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldUnicode: false,
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartWorkingTime",
                table: "Doctors",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndWorkingTime",
                table: "Doctors",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor_Takhasoses",
                table: "Doctor_Takhasoses",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "ExceptionLogs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StackTrace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExceptionType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Source = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionLogs", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Takhasoses_Doctors_DoctorID",
                table: "Doctor_Takhasoses",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Takhasoses_Takhasoses_TakhasosID",
                table: "Doctor_Takhasoses",
                column: "TakhasosID",
                principalTable: "Takhasoses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Takhasoses_Doctors_DoctorID",
                table: "Doctor_Takhasoses");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Takhasoses_Takhasoses_TakhasosID",
                table: "Doctor_Takhasoses");

            migrationBuilder.DropTable(
                name: "ExceptionLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor_Takhasoses",
                table: "Doctor_Takhasoses");

            migrationBuilder.RenameTable(
                name: "Doctor_Takhasoses",
                newName: "Tbl_Doctor Takhasos");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_Takhasoses_TakhasosID",
                table: "Tbl_Doctor Takhasos",
                newName: "IX_Tbl_Doctor Takhasos_TakhasosID");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_Takhasoses_DoctorID",
                table: "Tbl_Doctor Takhasos",
                newName: "IX_Tbl_Doctor Takhasos_DoctorID");

            migrationBuilder.AlterColumn<string>(
                name: "MobileNumber",
                table: "Users",
                type: "varchar(11)",
                unicode: false,
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(11)",
                oldUnicode: false,
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartWorkingTime",
                table: "Doctors",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndWorkingTime",
                table: "Doctors",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Doctor Takhasos",
                table: "Tbl_Doctor Takhasos",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Doctor Takhasos_Doctors_DoctorID",
                table: "Tbl_Doctor Takhasos",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Doctor Takhasos_Takhasoses_TakhasosID",
                table: "Tbl_Doctor Takhasos",
                column: "TakhasosID",
                principalTable: "Takhasoses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
