using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SecurityProject.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    role_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    role_code = table.Column<string>(nullable: true),
                    role_description = table.Column<string>(nullable: true),
                    role_active_default = table.Column<bool>(nullable: false),
                    role_system_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.role_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
