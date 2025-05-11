using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C43_G03_Ef03.Migrations
{
    /// <inheritdoc />
    public partial class RelationBetweenEmpandAdress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_City",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_Country",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_street",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpAddress_City",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmpAddress_Country",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmpAddress_street",
                table: "Employee");
        }
    }
}
