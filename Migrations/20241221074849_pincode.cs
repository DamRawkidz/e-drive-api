using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_drive_api.Migrations
{
    /// <inheritdoc />
    public partial class pincode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "pincode",
                table: "t_employee",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pincode",
                table: "t_employee");
        }
    }
}
