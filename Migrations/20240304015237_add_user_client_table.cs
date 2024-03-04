using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflApp.Migrations
{
    /// <inheritdoc />
    public partial class add_user_client_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbclient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    AccountRole = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BusinessLicenseFile = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TaxNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Representator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RepresentatorTitle = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IDCardNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPerson = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsThirdParty = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Website = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FaxNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsVerified = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ActiveAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    VerifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    AccountName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ward = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    District = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dob = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbclient", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbuser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Roles = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsVerified = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ActiveDateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    VerifiedDateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedDateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    AccountName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ward = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    District = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dob = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbuser", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "dbclient",
                columns: new[] { "Id", "AccountName", "AccountNumber", "AccountRole", "ActiveAt", "Address", "BusinessLicenseFile", "City", "CompanyName", "ContactPerson", "CreatedAt", "DeletedAt", "District", "Dob", "Email", "FaxNumber", "IDCardNumber", "IsActive", "IsDeleted", "IsThirdParty", "IsVerified", "Password", "Phone", "Representator", "RepresentatorTitle", "TaxNumber", "UpdatedAt", "VerifiedAt", "Ward", "Website" },
                values: new object[,]
                {
                    { new Guid("0967ae39-3848-49e7-9d70-c55cf744bf16"), "client 1", 128743, 0, new DateTime(2024, 3, 4, 8, 52, 37, 262, DateTimeKind.Local).AddTicks(3173), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCC", "0982288888", new DateTime(2024, 3, 4, 8, 52, 37, 262, DateTimeKind.Local).AddTicks(3170), null, "10", null, "client_1@gmail.com", "10099922", "1235888570", true, false, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 4, 8, 52, 37, 262, DateTimeKind.Local).AddTicks(3174), "5", "scc.com" },
                    { new Guid("6229cda6-afe0-4d93-8107-81560c3052e7"), "client 2", 123587, 0, new DateTime(2024, 3, 4, 8, 52, 37, 263, DateTimeKind.Local).AddTicks(2777), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCB", "0982288888", new DateTime(2024, 3, 4, 8, 52, 37, 263, DateTimeKind.Local).AddTicks(2775), null, "10", null, "client_2@gmail.com", "10099922", "1235888570", true, false, true, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 4, 8, 52, 37, 263, DateTimeKind.Local).AddTicks(2779), "5", "scc.com" }
                });

            migrationBuilder.InsertData(
                table: "dbuser",
                columns: new[] { "Id", "AccountName", "ActiveDateAt", "Address", "City", "CreatedAt", "DeletedAt", "DeletedDateAt", "District", "Dob", "Email", "IsActive", "IsDeleted", "IsVerified", "Password", "Phone", "Roles", "UpdatedAt", "VerifiedDateAt", "Ward" },
                values: new object[,]
                {
                    { new Guid("125aa7d7-3581-4845-b50d-27046848b057"), "Test 1", new DateTime(2024, 3, 4, 8, 52, 37, 261, DateTimeKind.Local).AddTicks(3871), null, null, new DateTime(2024, 3, 4, 8, 52, 37, 261, DateTimeKind.Local).AddTicks(3869), null, null, null, null, "test_2@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, new DateTime(2024, 3, 4, 8, 52, 37, 261, DateTimeKind.Local).AddTicks(3872), null },
                    { new Guid("e6d6cb1c-cbf8-45ff-93f9-41971874375c"), "Test 1", new DateTime(2024, 3, 4, 8, 52, 37, 260, DateTimeKind.Local).AddTicks(5344), null, null, new DateTime(2024, 3, 4, 8, 52, 37, 260, DateTimeKind.Local).AddTicks(5331), null, null, null, null, "test_1@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 0, null, new DateTime(2024, 3, 4, 8, 52, 37, 260, DateTimeKind.Local).AddTicks(5346), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbclient");

            migrationBuilder.DropTable(
                name: "dbuser");
        }
    }
}
