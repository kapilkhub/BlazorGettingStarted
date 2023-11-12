using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BethanysPieShopHRM.Api.Migrations
{
    public partial class AddBenefitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Benefit",
                columns: new[] { "Id", "Description", "Premium" },
                values: new object[,]
                {
                    { 1, "Health Insurance", false },
                    { 2, "Paid Time Off", false },
                    { 3, "Wellness", true },
                    { 4, "Education", true },
                    { 5, "Store Discount", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Benefit",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Benefit",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Benefit",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Benefit",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Benefit",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
