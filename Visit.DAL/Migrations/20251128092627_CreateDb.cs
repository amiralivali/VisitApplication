using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Visit.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Takhasoses",
                columns: table => new
                {
                    ID = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takhasoses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bimars",
                columns: table => new
                {
                    BimarID = table.Column<int>(type: "int", nullable: false),
                    NationalCode = table.Column<string>(type: "char(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bimars", x => x.BimarID);
                    table.ForeignKey(
                        name: "FK_Bimars_Users_BimarID",
                        column: x => x.BimarID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromID = table.Column<int>(type: "int", nullable: false),
                    ToID = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chats_Users_FromID",
                        column: x => x.FromID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chats_Users_ToID",
                        column: x => x.ToID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    CodeNezamPezeshki = table.Column<string>(type: "char(5)", unicode: false, maxLength: 10, nullable: false),
                    StartWorkingTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    EndWorkingTime = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorID);
                    table.ForeignKey(
                        name: "FK_Doctors_Users_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Doctor Takhasos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    TakhasosID = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Doctor Takhasos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_Doctor Takhasos_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Doctor Takhasos_Takhasoses_TakhasosID",
                        column: x => x.TakhasosID,
                        principalTable: "Takhasoses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    BimarID = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Visits_Bimars_BimarID",
                        column: x => x.BimarID,
                        principalTable: "Bimars",
                        principalColumn: "BimarID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visits_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Takhasoses",
                columns: new[] { "ID", "Title" },
                values: new object[,]
                {
                    { (byte)1, "چشم" },
                    { (byte)2, "مغز و اعصاب" },
                    { (byte)3, "قلب و عروق" },
                    { (byte)4, "گوش و حلق و بینی" },
                    { (byte)5, "اعصاب و روان" },
                    { (byte)6, "روانشناسی" },
                    { (byte)7, "اطفال" },
                    { (byte)8, "پوست و مو زیبایی" },
                    { (byte)9, "گوارش" },
                    { (byte)10, "ریه" },
                    { (byte)11, "کلیه" },
                    { (byte)12, "غدد" },
                    { (byte)13, "تغذیه" },
                    { (byte)14, "پزشک عمومی" },
                    { (byte)15, "مامایی" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_FromID",
                table: "Chats",
                column: "FromID");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ToID",
                table: "Chats",
                column: "ToID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Doctor Takhasos_DoctorID",
                table: "Tbl_Doctor Takhasos",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Doctor Takhasos_TakhasosID",
                table: "Tbl_Doctor Takhasos",
                column: "TakhasosID");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_BimarID",
                table: "Visits",
                column: "BimarID");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_DoctorID",
                table: "Visits",
                column: "DoctorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Tbl_Doctor Takhasos");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Takhasoses");

            migrationBuilder.DropTable(
                name: "Bimars");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
