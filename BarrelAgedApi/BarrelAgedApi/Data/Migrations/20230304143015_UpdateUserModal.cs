using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarrelAgedApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserModal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FingerPrint",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FingerPrint",
                table: "Users");
        }
    }
}
