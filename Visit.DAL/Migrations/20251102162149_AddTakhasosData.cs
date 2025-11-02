using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Visit.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddTakhasosData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Takhasoses",
                columns: new[] { "ID", "Titel" },
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)5);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)6);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)7);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)8);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)9);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)10);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)11);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)12);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)13);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)14);

            migrationBuilder.DeleteData(
                table: "Takhasoses",
                keyColumn: "ID",
                keyValue: (byte)15);
        }
    }
}
