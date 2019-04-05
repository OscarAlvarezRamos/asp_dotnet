using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SecurityProject.API.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    role_code = table.Column<string>(type: "varchar(10)", nullable: false),
                    role_description = table.Column<string>(type: "varchar(200)", nullable: false),
                    role_active_default = table.Column<sbyte>(type: "tinyint(4)", nullable: true, defaultValueSql: "'0'"),
                    role_sysdate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.role_id);
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "role_id", "role_active_default", "role_code", "role_description" },
                values: new object[] { 1, (sbyte)0, "admin", "System Administrator" });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "role_id", "role_active_default", "role_code", "role_description" },
                values: new object[] { 2, (sbyte)1, "user", "Application User" });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "role_id", "role_active_default", "role_code", "role_description" },
                values: new object[] { 3, (sbyte)1, "guest", "Guest User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
