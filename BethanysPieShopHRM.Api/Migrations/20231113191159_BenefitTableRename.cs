using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BethanysPieShopHRM.Api.Migrations
{
    public partial class BenefitTableRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeBenefit_Benefit_BenefitId",
                table: "EmployeeBenefit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Benefit",
                table: "Benefit");

            migrationBuilder.RenameTable(
                name: "Benefit",
                newName: "Benefits");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Benefits",
                table: "Benefits",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeBenefit_Benefits_BenefitId",
                table: "EmployeeBenefit",
                column: "BenefitId",
                principalTable: "Benefits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeBenefit_Benefits_BenefitId",
                table: "EmployeeBenefit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Benefits",
                table: "Benefits");

            migrationBuilder.RenameTable(
                name: "Benefits",
                newName: "Benefit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Benefit",
                table: "Benefit",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeBenefit_Benefit_BenefitId",
                table: "EmployeeBenefit",
                column: "BenefitId",
                principalTable: "Benefit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
