using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G03_Ef03.Migrations
{
    /// <inheritdoc />
    public partial class relationshipdeptbetweenemp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManageId",
                table: "department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_department_ManageId",
                table: "department",
                column: "ManageId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_department_Employee_ManageId",
                table: "department",
                column: "ManageId",
                principalTable: "Employee",
                principalColumn: "EmpId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_Employee_ManageId",
                table: "department");

            migrationBuilder.DropIndex(
                name: "IX_department_ManageId",
                table: "department");

            migrationBuilder.DropColumn(
                name: "ManageId",
                table: "department");
        }
    }
}
