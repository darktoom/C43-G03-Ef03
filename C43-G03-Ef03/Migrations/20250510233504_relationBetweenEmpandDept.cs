using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G03_Ef03.Migrations
{
    /// <inheritdoc />
    public partial class relationBetweenEmpandDept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "empolyeedepartmentDeptId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_empolyeedepartmentDeptId",
                table: "Employee",
                column: "empolyeedepartmentDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_department_empolyeedepartmentDeptId",
                table: "Employee",
                column: "empolyeedepartmentDeptId",
                principalTable: "department",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_department_empolyeedepartmentDeptId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_empolyeedepartmentDeptId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "empolyeedepartmentDeptId",
                table: "Employee");
        }
    }
}
