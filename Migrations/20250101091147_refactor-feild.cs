using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_drive_api.Migrations
{
    /// <inheritdoc />
    public partial class refactorfeild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "paswordHash",
                table: "t_user",
                newName: "passwordHash");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "passwordHash",
                table: "t_user",
                newName: "paswordHash");
        }
    }
}
