using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflApp.Migrations
{
    /// <inheritdoc />
    public partial class add_user_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Roles = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsVerified = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "IsActive", "IsVerified", "Name", "Password", "Roles", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2c1f78fa-b861-4a86-adde-3d4408b4c93f"), new DateTime(2024, 3, 2, 18, 8, 59, 56, DateTimeKind.Local).AddTicks(8862), null, "test_2@gmail.com", true, true, "Test 1", "m9fUsQskgQAZZPVNkXc3ag==", 1, null },
                    { new Guid("47d50a18-7e30-4d6c-afe4-b44f81368e20"), new DateTime(2024, 3, 2, 18, 8, 59, 56, DateTimeKind.Local).AddTicks(1192), null, "test_1@gmail.com", true, true, "Test 1", "m9fUsQskgQAZZPVNkXc3ag==", 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
