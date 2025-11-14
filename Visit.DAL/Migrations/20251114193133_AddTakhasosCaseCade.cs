using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Visit.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddTakhasosCaseCade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Doctor Takhasos_Doctors_DoctorID",
                table: "Tbl_Doctor Takhasos");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Bimars_BimarID",
                table: "Visits");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Doctors_DoctorID",
                table: "Visits");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Doctor Takhasos_Doctors_DoctorID",
                table: "Tbl_Doctor Takhasos",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Bimars_BimarID",
                table: "Visits",
                column: "BimarID",
                principalTable: "Bimars",
                principalColumn: "BimarID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Doctors_DoctorID",
                table: "Visits",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Doctor Takhasos_Doctors_DoctorID",
                table: "Tbl_Doctor Takhasos");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Bimars_BimarID",
                table: "Visits");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Doctors_DoctorID",
                table: "Visits");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Doctor Takhasos_Doctors_DoctorID",
                table: "Tbl_Doctor Takhasos",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Bimars_BimarID",
                table: "Visits",
                column: "BimarID",
                principalTable: "Bimars",
                principalColumn: "BimarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Doctors_DoctorID",
                table: "Visits",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
