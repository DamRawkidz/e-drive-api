using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace e_drive_api.Migrations
{
    /// <inheritdoc />
    public partial class employeetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    create_by = table.Column<string>(type: "text", nullable: true),
                    create_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    update_by = table.Column<string>(type: "text", nullable: true),
                    update_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    firstName = table.Column<string>(type: "text", nullable: false),
                    lastName = table.Column<string>(type: "text", nullable: false),
                    nickName = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    msr_card = table.Column<int>(type: "integer", nullable: true),
                    tax_id = table.Column<string>(type: "text", nullable: true),
                    home_phone_no = table.Column<string>(type: "text", nullable: true),
                    mobile_phone_no = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    ciy = table.Column<string>(type: "text", nullable: true),
                    state = table.Column<string>(type: "text", nullable: true),
                    zipcode = table.Column<string>(type: "text", nullable: true),
                    hired_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    terminated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    birth_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    driver_licence_no = table.Column<string>(type: "text", nullable: true),
                    driver_licence_expire = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    car_insure_carrier = table.Column<string>(type: "text", nullable: true),
                    insurance_licence_expire = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    insurance_policy_no = table.Column<string>(type: "text", nullable: true),
                    insurance_policy_note = table.Column<string>(type: "text", nullable: true),
                    employee_note = table.Column<string>(type: "text", nullable: true),
                    pay_rate_id = table.Column<int>(type: "integer", nullable: true),
                    pay_rate = table.Column<int>(type: "integer", nullable: false),
                    is_enable_clock_break = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_employee", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_employee");
        }
    }
}
