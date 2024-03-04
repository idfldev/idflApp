using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflApp.Migrations
{
    /// <inheritdoc />
    public partial class add_standard_project_projectgeneral_book_projectstandard_standardcategory_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("0967ae39-3848-49e7-9d70-c55cf744bf16"));

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("6229cda6-afe0-4d93-8107-81560c3052e7"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("125aa7d7-3581-4845-b50d-27046848b057"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("e6d6cb1c-cbf8-45ff-93f9-41971874375c"));

            migrationBuilder.CreateTable(
                name: "dbstandard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbstandard", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProjectStandardCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStandardCategory", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbproject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StandardId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ClientId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectGeneralId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PayerId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BookId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsInitialCertification = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsRenewalCertification = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsAnotherCertification = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsRequired = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LicenseNo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CertificationBody = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CertificationExpirationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Status = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsCertificated = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ConfirmedByUserId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConfirmedDateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CertificatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ActiveDateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedDateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbproject", x => x.Id);
                    table.ForeignKey(
                        name: "fk_project_client",
                        column: x => x.ClientId,
                        principalTable: "dbclient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_project_standard",
                        column: x => x.StandardId,
                        principalTable: "dbstandard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbbooking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserModelId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AuditById = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CompletedById = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Subject = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AuditDateAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    BookedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbbooking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbbooking_dbuser_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "dbuser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_book_project",
                        column: x => x.ProjectId,
                        principalTable: "dbproject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbprojectgeneral",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectCode = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientNumber = table.Column<int>(type: "int", nullable: true),
                    IsEmergency = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsRushCertificate = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    OEKO = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SCS = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    BSCI = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SA8000 = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FEM = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FSLM = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    BRM = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    WRAP = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ChemicalInputGOTS = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ChemicalsAreUsedGOTS = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ChemicalInputGRS = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ChemicalsAreUsedGRS = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CertificationCompliance = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeniedCertificationDescription = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BannedCertificationDescription = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbprojectgeneral", x => x.Id);
                    table.ForeignKey(
                        name: "fk_project_general_project",
                        column: x => x.ProjectId,
                        principalTable: "dbproject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbprojectstandard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectStandardCategoryId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbprojectstandard", x => x.Id);
                    table.ForeignKey(
                        name: "fk_project_standard_project",
                        column: x => x.ProjectId,
                        principalTable: "dbproject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_project_standard_project_standard_category",
                        column: x => x.ProjectStandardCategoryId,
                        principalTable: "ProjectStandardCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "dbclient",
                columns: new[] { "Id", "AccountName", "AccountNumber", "AccountRole", "ActiveAt", "Address", "BusinessLicenseFile", "City", "CompanyName", "ContactPerson", "CreatedAt", "DeletedAt", "District", "Dob", "Email", "FaxNumber", "IDCardNumber", "IsActive", "IsDeleted", "IsThirdParty", "IsVerified", "Password", "Phone", "Representator", "RepresentatorTitle", "TaxNumber", "UpdatedAt", "VerifiedAt", "Ward", "Website" },
                values: new object[,]
                {
                    { new Guid("8b7f530f-931a-4ed7-befb-47777200e775"), "client 1", 128743, 0, new DateTime(2024, 3, 4, 14, 53, 39, 196, DateTimeKind.Local).AddTicks(7298), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCC", "0982288888", new DateTime(2024, 3, 4, 14, 53, 39, 196, DateTimeKind.Local).AddTicks(7296), null, "10", null, "client_1@gmail.com", "10099922", "1235888570", true, false, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 4, 14, 53, 39, 196, DateTimeKind.Local).AddTicks(7299), "5", "scc.com" },
                    { new Guid("95220eba-12e5-47e9-bf53-bf5ac5984789"), "client 2", 123587, 0, new DateTime(2024, 3, 4, 14, 53, 39, 197, DateTimeKind.Local).AddTicks(5288), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCB", "0982288888", new DateTime(2024, 3, 4, 14, 53, 39, 197, DateTimeKind.Local).AddTicks(5286), null, "10", null, "client_2@gmail.com", "10099922", "1235888570", true, false, true, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 4, 14, 53, 39, 197, DateTimeKind.Local).AddTicks(5288), "5", "scc.com" }
                });

            migrationBuilder.InsertData(
                table: "dbuser",
                columns: new[] { "Id", "AccountName", "ActiveDateAt", "Address", "City", "CreatedAt", "DeletedAt", "DeletedDateAt", "District", "Dob", "Email", "IsActive", "IsDeleted", "IsVerified", "Password", "Phone", "Roles", "UpdatedAt", "VerifiedDateAt", "Ward" },
                values: new object[,]
                {
                    { new Guid("8851ae4c-4471-4d08-bb6a-b180a51ab64c"), "Test 1", new DateTime(2024, 3, 4, 14, 53, 39, 195, DateTimeKind.Local).AddTicks(1585), null, null, new DateTime(2024, 3, 4, 14, 53, 39, 195, DateTimeKind.Local).AddTicks(1572), null, null, null, null, "test_1@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 0, null, new DateTime(2024, 3, 4, 14, 53, 39, 195, DateTimeKind.Local).AddTicks(1586), null },
                    { new Guid("af26c1a6-ff07-4ffa-ba75-368862861bf6"), "Test 1", new DateTime(2024, 3, 4, 14, 53, 39, 195, DateTimeKind.Local).AddTicks(9425), null, null, new DateTime(2024, 3, 4, 14, 53, 39, 195, DateTimeKind.Local).AddTicks(9423), null, null, null, null, "test_2@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, new DateTime(2024, 3, 4, 14, 53, 39, 195, DateTimeKind.Local).AddTicks(9426), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbbooking_ProjectId",
                table: "dbbooking",
                column: "ProjectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dbbooking_UserModelId",
                table: "dbbooking",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_dbproject_ClientId",
                table: "dbproject",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_dbproject_StandardId",
                table: "dbproject",
                column: "StandardId");

            migrationBuilder.CreateIndex(
                name: "IX_dbprojectgeneral_ProjectId",
                table: "dbprojectgeneral",
                column: "ProjectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dbprojectstandard_ProjectId",
                table: "dbprojectstandard",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_dbprojectstandard_ProjectStandardCategoryId",
                table: "dbprojectstandard",
                column: "ProjectStandardCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbbooking");

            migrationBuilder.DropTable(
                name: "dbprojectgeneral");

            migrationBuilder.DropTable(
                name: "dbprojectstandard");

            migrationBuilder.DropTable(
                name: "dbproject");

            migrationBuilder.DropTable(
                name: "ProjectStandardCategory");

            migrationBuilder.DropTable(
                name: "dbstandard");

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("8b7f530f-931a-4ed7-befb-47777200e775"));

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("95220eba-12e5-47e9-bf53-bf5ac5984789"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("8851ae4c-4471-4d08-bb6a-b180a51ab64c"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("af26c1a6-ff07-4ffa-ba75-368862861bf6"));

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
    }
}
