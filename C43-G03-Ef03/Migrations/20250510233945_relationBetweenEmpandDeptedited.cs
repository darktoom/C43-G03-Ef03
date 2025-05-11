using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G03_Ef03.Migrations
{
    /// <inheritdoc />
    public partial class relationBetweenEmpandDeptedited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_department_empolyeedepartmentDeptId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "empolyeedepartmentDeptId",
                table: "Employee",
                newName: "EmpolyeeDepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_empolyeedepartmentDeptId",
                table: "Employee",
                newName: "IX_Employee_EmpolyeeDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_department_EmpolyeeDepartmentId",
                table: "Employee",
                column: "EmpolyeeDepartmentId",
                principalTable: "department",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_department_EmpolyeeDepartmentId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmpolyeeDepartmentId",
                table: "Employee",
                newName: "empolyeedepartmentDeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_EmpolyeeDepartmentId",
                table: "Employee",
                newName: "IX_Employee_empolyeedepartmentDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_department_empolyeedepartmentDeptId",
                table: "Employee",
                column: "empolyeedepartmentDeptId",
                principalTable: "department",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
