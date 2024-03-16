using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflApp.Migrations
{
    /// <inheritdoc />
    public partial class add_refactor_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbbooking_dbproject_ProjectId",
                table: "dbbooking");

            migrationBuilder.DropForeignKey(
                name: "FK_dbbooking_dbuser_CompletedBy",
                table: "dbbooking");

            migrationBuilder.DropForeignKey(
                name: "fk_project_client",
                table: "dbproject");

            migrationBuilder.DropForeignKey(
                name: "fk_project_standard",
                table: "dbproject");

            migrationBuilder.DropForeignKey(
                name: "fk_project_user",
                table: "dbproject");

            migrationBuilder.DropTable(
                name: "dbprojectgeneral");

            migrationBuilder.DropTable(
                name: "dbprojectstandard");

            migrationBuilder.DropTable(
                name: "dbstandardanswer");

            migrationBuilder.DropTable(
                name: "dbstandardquestion");

            migrationBuilder.DropTable(
                name: "ProjectStandardCategory");

            migrationBuilder.DropIndex(
                name: "IX_dbproject_HandledBy",
                table: "dbproject");

            migrationBuilder.DropIndex(
                name: "IX_dbbooking_CompletedBy",
                table: "dbbooking");

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("cafe2325-8400-4efc-bda5-61b3bb5d061b"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("51ce1a80-cad2-48a5-b971-4ad73cef3a27"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("75c45c16-8bc5-4ef1-8fff-e0b77402d0c8"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("830ae23a-567d-4db1-bbc3-278727c20d39"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("9b99e73c-1e12-48cf-a3e2-639d8bdf1bdd"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("0d50ac6f-87d2-4560-b82f-b09f0c0f6123"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("20094066-dd29-412b-8aab-9237ef79ca72"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("281f8d38-063b-4805-8298-736d2e7d333d"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("3bce5c66-c742-4af8-9866-ca5bd0384c95"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("a3178844-d33b-47b2-bd4e-14c0ea852749"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("d6feb4e9-45bf-40f8-93bc-c8aec6460684"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("e4e59734-62b8-455b-aca8-84cacf3ca980"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("f521b970-4674-44a9-8f82-8dbe5cd4f7fe"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("7bd6c441-9558-4180-b0b7-2b8245bbc7f6"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("8c3b7104-2842-46d9-86a3-836d0b724640"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("9aba2d39-8acf-41c3-9dee-109ca8b15e48"));

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("4a735124-2eaa-4567-98f4-0bffe2a0cda4"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("29c43274-df4a-43f1-a064-f8efaf0d01a5"));

            migrationBuilder.DropColumn(
                name: "AccountName",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "ActiveDateAt",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "City",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "DeletedDateAt",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "District",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "Dob",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "VerifiedDateAt",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "dbstandard");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "dbstandard");

            migrationBuilder.DropColumn(
                name: "HandledBy",
                table: "dbproject");

            migrationBuilder.DropColumn(
                name: "IsAnotherCertification",
                table: "dbproject");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "dbproject");

            migrationBuilder.DropColumn(
                name: "IsInitialCertification",
                table: "dbproject");

            migrationBuilder.DropColumn(
                name: "IsRenewalCertification",
                table: "dbproject");

            migrationBuilder.DropColumn(
                name: "IssueCertificated",
                table: "dbproject");

            migrationBuilder.DropColumn(
                name: "PayerId",
                table: "dbproject");

            migrationBuilder.DropColumn(
                name: "AccountName",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "ActiveAt",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "BusinessLicenseFile",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "City",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "ContactPerson",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "District",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "Dob",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "FaxNumber",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "IDCardNumber",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "Representator",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "RepresentatorTitle",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "TaxNumber",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "VerifiedAt",
                table: "dbclient");

            migrationBuilder.DropColumn(
                name: "CompletedBy",
                table: "dbbooking");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "dbbooking");

            migrationBuilder.RenameColumn(
                name: "Ward",
                table: "dbuser",
                newName: "DisplayName");

            migrationBuilder.RenameColumn(
                name: "Roles",
                table: "dbuser",
                newName: "UserRole");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "dbuser",
                newName: "UserCode");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "dbuser",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ProjectGeneralId",
                table: "dbproject",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "LicenseNo",
                table: "dbproject",
                newName: "CertificationNumber");

            migrationBuilder.RenameColumn(
                name: "IdflCode",
                table: "dbproject",
                newName: "RefCode");

            migrationBuilder.RenameIndex(
                name: "IX_dbproject_IdflCode",
                table: "dbproject",
                newName: "IX_dbproject_RefCode");

            migrationBuilder.RenameColumn(
                name: "Website",
                table: "dbclient",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Ward",
                table: "dbclient",
                newName: "DisplayName");

            migrationBuilder.RenameColumn(
                name: "AccountRole",
                table: "dbclient",
                newName: "ClientRole");

            migrationBuilder.RenameColumn(
                name: "AccountNumber",
                table: "dbclient",
                newName: "ClientCode");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "dbbooking",
                newName: "FactoryId");

            migrationBuilder.RenameIndex(
                name: "IX_dbbooking_ProjectId",
                table: "dbbooking",
                newName: "IX_dbbooking_FactoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "dbuser",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "dbuser",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Displayname",
                table: "dbstandard",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "StandardId",
                table: "dbproject",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "dbclient",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbaccountverify",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserModelId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ClientId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ClientModelId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    VerifyCode = table.Column<double>(type: "double", nullable: false),
                    VerifyCount = table.Column<int>(type: "int", nullable: false),
                    StartedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbaccountverify", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbaccountverify_dbclient_ClientModelId",
                        column: x => x.ClientModelId,
                        principalTable: "dbclient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_dbaccountverify_dbuser_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "dbuser",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbbookcomplete",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserModelId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    BookModelId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompletedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbbookcomplete", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbbookcomplete_dbbooking_BookModelId",
                        column: x => x.BookModelId,
                        principalTable: "dbbooking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbbookcomplete_dbuser_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "dbuser",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbclientinformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ClientId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CompanyName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactPerson = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeskPhone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dob = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbclientinformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbclientinformation_dbclient_ClientId",
                        column: x => x.ClientId,
                        principalTable: "dbclient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbfactory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UnitName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ward = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    District = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ZipCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Occupancies = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActivitiesList = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsCertificatePreviously = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbfactory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbfactory_dbproject_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "dbproject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbuserinformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Icon = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dob = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbuserinformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbuserinformation_dbuser_UserId",
                        column: x => x.UserId,
                        principalTable: "dbuser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DepartmentModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DepartmentName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentModel", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "DepartmentModel",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DepartmentName", "Description", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d22ebe93-42ae-4a93-ad54-5e597d46ed56"), new DateTime(2024, 3, 16, 18, 46, 45, 678, DateTimeKind.Local).AddTicks(4967), null, "CS department", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book", true, null },
                    { new Guid("d9b3099d-b7ee-4e57-a3b8-eca1547f622c"), new DateTime(2024, 3, 16, 18, 46, 45, 678, DateTimeKind.Local).AddTicks(4983), null, "Audit department", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book", true, null }
                });

            migrationBuilder.InsertData(
                table: "dbclient",
                columns: new[] { "Id", "ClientCode", "ClientRole", "CreatedAt", "DeletedAt", "DisplayName", "Email", "IsActive", "IsThirdParty", "IsVerified", "Password", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1615e262-4630-4963-818f-5bb8df8be61f"), 1002, 1, new DateTime(2024, 3, 16, 18, 46, 45, 683, DateTimeKind.Local).AddTicks(1258), null, "Client2 Corporation", "bob@example.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "Active", null },
                    { new Guid("54295843-e8fb-4e79-81b5-57939411eb2d"), 1001, 0, new DateTime(2024, 3, 16, 18, 46, 45, 682, DateTimeKind.Local).AddTicks(3688), null, "Client1 Company", "alice@example.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "Active", null },
                    { new Guid("9bb6884e-1fa6-4d38-ae1b-77d70eab8134"), 1005, 1, new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6092), null, "Client5 Solutions", "sarah@example.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "Active", null },
                    { new Guid("c66df42b-0850-4e6f-9c69-2216b38d3560"), 1003, 0, new DateTime(2024, 3, 16, 18, 46, 45, 683, DateTimeKind.Local).AddTicks(8984), null, "Client3 Enterprises", "emily@example.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "Active", null },
                    { new Guid("ed1ba434-35e9-48bd-936f-e33dc3c755aa"), 1004, 1, null, null, "Client4 Ltd.", "michael@example.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "Active", null }
                });

            migrationBuilder.InsertData(
                table: "dbstandard",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Displayname", "IsActive", "StandardCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("336fc67b-e2a6-4f34-84a6-bad2bb3abc7e"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6279), null, "IDFL may not issue a GOTS scope certificate to an organization which holds a OCS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", "Global Organic Textile Standard", true, "GOTS", null },
                    { new Guid("36764bf4-f76f-4b99-a973-6b03f9754543"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6287), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", "Responsible Down Standard", true, "RDS", null },
                    { new Guid("4e6b07e6-fc73-4931-a594-5c13d8c9ff20"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6285), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", "Recycled Claim Standard", true, "RCS", null },
                    { new Guid("5d2a551a-de3d-4566-82a0-ffb33f7d0302"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6291), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", "Tiêu Chuẩn Len Có Trách Nhiệm", true, "RWS", null },
                    { new Guid("603f275f-beab-4eb9-ad9c-a5d4eae3d8a6"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6289), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", "Responsible Animal Fiber", true, "RAF", null },
                    { new Guid("9aae728c-be2a-4033-9c50-31ae91158ae1"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6234), null, "IDFL may not issue an OCS scope certificate to an organization which holds a GOTS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", "Organic Content Standard", true, "OCS", null },
                    { new Guid("a9a503f2-e23f-4c3f-9484-8f62303a81cd"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6293), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", "Tiêu Chuẩn Mohair Có Trách Nhiệm", true, "RMS", null },
                    { new Guid("bb9ea653-6d37-4cf6-977e-3dd98f2f594c"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6281), null, "IDFL may not issue a GRS scope certificate to an organization which holds a RCS scope certificate with another certification body, unless the RCS scope certificate is in the process of being transferred to IDFL.", "Global Recycled Standard", true, "GRS", null },
                    { new Guid("d614df29-44de-465e-b99b-8402cfbd1c4e"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6295), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", "Tiêu Chuẩn Alpaca Có Trách Nhiệm", true, "RAS", null }
                });

            migrationBuilder.InsertData(
                table: "dbclientinformation",
                columns: new[] { "Id", "Address", "City", "ClientId", "CompanyName", "ContactPerson", "Country", "CreatedAt", "DeletedAt", "DeskPhone", "Dob", "Phone", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("14ad10a7-2783-4d32-9a03-62de4531291f"), "1010 Pine St", "Houston", new Guid("ed1ba434-35e9-48bd-936f-e33dc3c755aa"), "Client4 Ltd.", "Michael Brown", "USA", null, null, "555-666-7777", new DateTime(1975, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "222-333-4444", "CEO", null },
                    { new Guid("bd4acbd1-5399-49b4-83cc-db9bb304a1c9"), "456 Oak St", "Los Angeles", new Guid("1615e262-4630-4963-818f-5bb8df8be61f"), "Client2 Corporation", "Bob Johnson", "USA", new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6165), null, "123-456-7890", new DateTime(1978, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "987-654-3210", "Director", null },
                    { new Guid("e8bce232-d77d-4809-9462-702e0e6244f3"), "789 Maple Ave", "Chicago", new Guid("c66df42b-0850-4e6f-9c69-2216b38d3560"), "Client3 Enterprises", "Emily Davis", "USA", new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6169), null, "444-555-6666", new DateTime(1982, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "111-222-3333", "Manager", null },
                    { new Guid("eb1e90cf-758d-4129-a077-8072e91261bb"), "123 Main St", "New York", new Guid("54295843-e8fb-4e79-81b5-57939411eb2d"), "Client1 Company", "Alice Smith", "USA", new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6161), null, "987-654-3210", new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "123-456-7890", "CEO", null },
                    { new Guid("ec383b84-baef-489a-854d-54cd78caaaad"), "789 Market St", "San Francisco", new Guid("9bb6884e-1fa6-4d38-ae1b-77d70eab8134"), "Client5 Solutions", "Sarah Adams", "USA", new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6175), null, "666-777-8888", new DateTime(1988, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "333-444-5555", "Director", null }
                });

            migrationBuilder.InsertData(
                table: "dbproject",
                columns: new[] { "Id", "CertificationBody", "CertificationExpirationDate", "CertificationNumber", "ClientId", "CreatedAt", "DeletedAt", "IssueCertificatedDate", "RefCode", "StandardId", "Status", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("685d7299-d83a-4609-bcec-071b8a050f6a"), "Certification Authority", new DateTime(2025, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6344), "CERT101", new Guid("1615e262-4630-4963-818f-5bb8df8be61f"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6345), null, new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6343), "PROJ004", new Guid("9aae728c-be2a-4033-9c50-31ae91158ae1"), "Pending", null, null },
                    { new Guid("a3f22a8c-0eb0-4e15-97e5-73b8b45d451a"), "Certification Authority", new DateTime(2025, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6340), "CERT789", new Guid("54295843-e8fb-4e79-81b5-57939411eb2d"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6341), null, new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6339), "PROJ003", new Guid("336fc67b-e2a6-4f34-84a6-bad2bb3abc7e"), "Active", null, null },
                    { new Guid("a6ddc50a-ad89-4fc9-bd36-6ec3bd7af726"), "Certification Authority", new DateTime(2025, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6334), "CERT456", new Guid("54295843-e8fb-4e79-81b5-57939411eb2d"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6335), null, new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6333), "PROJ002", new Guid("d614df29-44de-465e-b99b-8402cfbd1c4e"), "Active", null, null },
                    { new Guid("ff1439d6-f1ba-482b-a0ae-74b32bcf01ee"), "Certification Authority", new DateTime(2025, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6323), "CERT123", new Guid("1615e262-4630-4963-818f-5bb8df8be61f"), new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6329), null, new DateTime(2024, 3, 16, 18, 46, 45, 685, DateTimeKind.Local).AddTicks(6322), "PROJ001", new Guid("9aae728c-be2a-4033-9c50-31ae91158ae1"), "Pending", null, null }
                });

            migrationBuilder.InsertData(
                table: "dbuser",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DepartmentId", "DisplayName", "Email", "IsActive", "IsVerified", "Password", "Status", "UpdatedAt", "UserCode", "UserRole" },
                values: new object[,]
                {
                    { new Guid("3fb8c7f9-e96c-412b-ac25-92980e89274c"), new DateTime(2024, 3, 16, 18, 46, 45, 680, DateTimeKind.Local).AddTicks(739), null, new Guid("d9b3099d-b7ee-4e57-a3b8-eca1547f622c"), "Alice Smith", "alice.smith@example.com", true, true, "m9fUsQskgQAZZPVNkXc3ag==", true, null, "user002", 0 },
                    { new Guid("684c02da-f46d-45c0-9bf5-6bb716102a2e"), new DateTime(2024, 3, 16, 18, 46, 45, 681, DateTimeKind.Local).AddTicks(5981), null, new Guid("d22ebe93-42ae-4a93-ad54-5e597d46ed56"), "Michael Brown", "michael.brown@example.com", true, true, "m9fUsQskgQAZZPVNkXc3ag==", true, null, "user006", 0 },
                    { new Guid("ee85baa4-3073-4089-912d-593b94cbbe73"), new DateTime(2024, 3, 16, 18, 46, 45, 680, DateTimeKind.Local).AddTicks(8353), null, new Guid("d22ebe93-42ae-4a93-ad54-5e597d46ed56"), "Emily Johnson", "emily.johnson@example.com", true, true, "m9fUsQskgQAZZPVNkXc3ag==", true, null, "user003", 1 },
                    { new Guid("f714d440-35d8-48c3-ba87-2c6fdbff28bf"), new DateTime(2024, 3, 16, 18, 46, 45, 679, DateTimeKind.Local).AddTicks(3164), null, new Guid("d9b3099d-b7ee-4e57-a3b8-eca1547f622c"), "Tom Arrict", "john.doe@example.com", true, true, "m9fUsQskgQAZZPVNkXc3ag==", true, null, "user001", 0 }
                });

            migrationBuilder.InsertData(
                table: "dbfactory",
                columns: new[] { "Id", "ActivitiesList", "Address", "City", "Country", "CreatedAt", "DeletedAt", "District", "IsCertificatePreviously", "Occupancies", "ProjectId", "UnitName", "UpdatedAt", "Ward", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("238d18c0-9cd0-4861-a858-2e272dc7a5c6"), "Machining, Finishing", "111 Avenue St", "City V", "Country U", null, null, "District E", false, "Production", new Guid("ff1439d6-f1ba-482b-a0ae-74b32bcf01ee"), "Factory E", null, "Ward 5", "13579" },
                    { new Guid("31404a91-b21e-41df-bea2-be09b77c24cb"), "Packaging, Sorting", "456 Commercial St", "City Y", "Country Z", null, null, "District B", true, "Processing", new Guid("ff1439d6-f1ba-482b-a0ae-74b32bcf01ee"), "Factory B", null, "Ward 2", "54321" },
                    { new Guid("64afb8f6-55ae-46f0-a72d-a3a4719bc174"), "Assembling, Testing", "101 Residential St", "City W", "Country V", null, null, "District D", true, "Assembly", new Guid("a3f22a8c-0eb0-4e15-97e5-73b8b45d451a"), "Factory D", null, "Ward 4", "98765" },
                    { new Guid("ac4268c0-f63e-4e4f-9a14-30cda7647746"), "Cutting, Welding", "789 Business St", "City Z", "Country X", null, null, "District C", false, "Fabrication", new Guid("a6ddc50a-ad89-4fc9-bd36-6ec3bd7af726"), "Factory C", null, "Ward 3", "67890" },
                    { new Guid("ea4cfe84-1e71-44ba-824f-d23c4de8f07c"), "Production, Assembly", "123 Industrial St", "City X", "Country Y", null, null, "District A", false, "Manufacturing", new Guid("ff1439d6-f1ba-482b-a0ae-74b32bcf01ee"), "Factory A", null, "Ward 1", "12345" }
                });

            migrationBuilder.InsertData(
                table: "dbuserinformation",
                columns: new[] { "Id", "Address", "City", "CreatedAt", "DeletedAt", "Dob", "Icon", "Phone", "Title", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("9b50d418-5b72-446f-9e17-876dfb9a5659"), "456 Oak St", "Los Angeles", null, null, new DateTime(1980, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "987-654-3210", "Sales Manager", null, new Guid("3fb8c7f9-e96c-412b-ac25-92980e89274c") },
                    { new Guid("ab760805-7074-408e-851b-229a117cb76a"), "123 Main St", "New York", null, null, new DateTime(1994, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "123-456-7890", "Software Engineer", null, new Guid("f714d440-35d8-48c3-ba87-2c6fdbff28bf") },
                    { new Guid("c42fc78d-8993-4831-b0e8-41f432fa0099"), "1010 Pine St", "San Francisco", new DateTime(2024, 3, 16, 18, 46, 45, 681, DateTimeKind.Local).AddTicks(6061), null, new DateTime(1988, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "444-555-6666", "IT Manager", null, new Guid("684c02da-f46d-45c0-9bf5-6bb716102a2e") },
                    { new Guid("cf6ed099-b04e-4a61-b866-6711bbbc504f"), "789 Maple Ave", "Chicago", null, null, new DateTime(1975, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "111-222-3333", "HR Manager", null, new Guid("ee85baa4-3073-4089-912d-593b94cbbe73") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbuser_DepartmentId",
                table: "dbuser",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_dbproject_UserId",
                table: "dbproject",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_dbaccountverify_ClientModelId",
                table: "dbaccountverify",
                column: "ClientModelId");

            migrationBuilder.CreateIndex(
                name: "IX_dbaccountverify_UserModelId",
                table: "dbaccountverify",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_dbbookcomplete_BookModelId",
                table: "dbbookcomplete",
                column: "BookModelId");

            migrationBuilder.CreateIndex(
                name: "IX_dbbookcomplete_UserModelId",
                table: "dbbookcomplete",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_dbclientinformation_ClientId",
                table: "dbclientinformation",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_dbfactory_ProjectId",
                table: "dbfactory",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_dbuserinformation_UserId",
                table: "dbuserinformation",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_dbbooking_dbfactory_FactoryId",
                table: "dbbooking",
                column: "FactoryId",
                principalTable: "dbfactory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dbproject_dbclient_ClientId",
                table: "dbproject",
                column: "ClientId",
                principalTable: "dbclient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dbproject_dbstandard_StandardId",
                table: "dbproject",
                column: "StandardId",
                principalTable: "dbstandard",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dbproject_dbuser_UserId",
                table: "dbproject",
                column: "UserId",
                principalTable: "dbuser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dbuser_DepartmentModel_DepartmentId",
                table: "dbuser",
                column: "DepartmentId",
                principalTable: "DepartmentModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbbooking_dbfactory_FactoryId",
                table: "dbbooking");

            migrationBuilder.DropForeignKey(
                name: "FK_dbproject_dbclient_ClientId",
                table: "dbproject");

            migrationBuilder.DropForeignKey(
                name: "FK_dbproject_dbstandard_StandardId",
                table: "dbproject");

            migrationBuilder.DropForeignKey(
                name: "FK_dbproject_dbuser_UserId",
                table: "dbproject");

            migrationBuilder.DropForeignKey(
                name: "FK_dbuser_DepartmentModel_DepartmentId",
                table: "dbuser");

            migrationBuilder.DropTable(
                name: "dbaccountverify");

            migrationBuilder.DropTable(
                name: "dbbookcomplete");

            migrationBuilder.DropTable(
                name: "dbclientinformation");

            migrationBuilder.DropTable(
                name: "dbfactory");

            migrationBuilder.DropTable(
                name: "dbuserinformation");

            migrationBuilder.DropTable(
                name: "DepartmentModel");

            migrationBuilder.DropIndex(
                name: "IX_dbuser_DepartmentId",
                table: "dbuser");

            migrationBuilder.DropIndex(
                name: "IX_dbproject_UserId",
                table: "dbproject");

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("9bb6884e-1fa6-4d38-ae1b-77d70eab8134"));

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("c66df42b-0850-4e6f-9c69-2216b38d3560"));

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("ed1ba434-35e9-48bd-936f-e33dc3c755aa"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("685d7299-d83a-4609-bcec-071b8a050f6a"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("a3f22a8c-0eb0-4e15-97e5-73b8b45d451a"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("a6ddc50a-ad89-4fc9-bd36-6ec3bd7af726"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("ff1439d6-f1ba-482b-a0ae-74b32bcf01ee"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("36764bf4-f76f-4b99-a973-6b03f9754543"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("4e6b07e6-fc73-4931-a594-5c13d8c9ff20"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("5d2a551a-de3d-4566-82a0-ffb33f7d0302"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("603f275f-beab-4eb9-ad9c-a5d4eae3d8a6"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("a9a503f2-e23f-4c3f-9484-8f62303a81cd"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("bb9ea653-6d37-4cf6-977e-3dd98f2f594c"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("3fb8c7f9-e96c-412b-ac25-92980e89274c"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("684c02da-f46d-45c0-9bf5-6bb716102a2e"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("ee85baa4-3073-4089-912d-593b94cbbe73"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("f714d440-35d8-48c3-ba87-2c6fdbff28bf"));

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("1615e262-4630-4963-818f-5bb8df8be61f"));

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("54295843-e8fb-4e79-81b5-57939411eb2d"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("336fc67b-e2a6-4f34-84a6-bad2bb3abc7e"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("9aae728c-be2a-4033-9c50-31ae91158ae1"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("d614df29-44de-465e-b99b-8402cfbd1c4e"));

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "Displayname",
                table: "dbstandard");

            migrationBuilder.RenameColumn(
                name: "UserRole",
                table: "dbuser",
                newName: "Roles");

            migrationBuilder.RenameColumn(
                name: "UserCode",
                table: "dbuser",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "dbuser",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "dbuser",
                newName: "Ward");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "dbproject",
                newName: "ProjectGeneralId");

            migrationBuilder.RenameColumn(
                name: "RefCode",
                table: "dbproject",
                newName: "IdflCode");

            migrationBuilder.RenameColumn(
                name: "CertificationNumber",
                table: "dbproject",
                newName: "LicenseNo");

            migrationBuilder.RenameIndex(
                name: "IX_dbproject_RefCode",
                table: "dbproject",
                newName: "IX_dbproject_IdflCode");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "dbclient",
                newName: "Website");

            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "dbclient",
                newName: "Ward");

            migrationBuilder.RenameColumn(
                name: "ClientRole",
                table: "dbclient",
                newName: "AccountRole");

            migrationBuilder.RenameColumn(
                name: "ClientCode",
                table: "dbclient",
                newName: "AccountNumber");

            migrationBuilder.RenameColumn(
                name: "FactoryId",
                table: "dbbooking",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_dbbooking_FactoryId",
                table: "dbbooking",
                newName: "IX_dbbooking_ProjectId");

            migrationBuilder.UpdateData(
                table: "dbuser",
                keyColumn: "Email",
                keyValue: null,
                column: "Email",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "dbuser",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "AccountName",
                table: "dbuser",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActiveDateAt",
                table: "dbuser",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "dbuser",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "dbuser",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDateAt",
                table: "dbuser",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "dbuser",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Dob",
                table: "dbuser",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "dbuser",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "dbuser",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "dbuser",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "VerifiedDateAt",
                table: "dbuser",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "dbstandard",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "dbstandard",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "StandardId",
                table: "dbproject",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "HandledBy",
                table: "dbproject",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<bool>(
                name: "IsAnotherCertification",
                table: "dbproject",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "dbproject",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInitialCertification",
                table: "dbproject",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRenewalCertification",
                table: "dbproject",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IssueCertificated",
                table: "dbproject",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "PayerId",
                table: "dbproject",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "dbclient",
                keyColumn: "Email",
                keyValue: null,
                column: "Email",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "dbclient",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "AccountName",
                table: "dbclient",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ActiveAt",
                table: "dbclient",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "dbclient",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "BusinessLicenseFile",
                table: "dbclient",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "dbclient",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "dbclient",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson",
                table: "dbclient",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "dbclient",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Dob",
                table: "dbclient",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FaxNumber",
                table: "dbclient",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "IDCardNumber",
                table: "dbclient",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "dbclient",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "dbclient",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Representator",
                table: "dbclient",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "RepresentatorTitle",
                table: "dbclient",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TaxNumber",
                table: "dbclient",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "VerifiedAt",
                table: "dbclient",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompletedBy",
                table: "dbbooking",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "dbbooking",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "dbprojectgeneral",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BannedCertificationDescription = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientNumber = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeniedCertificationDescription = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsEmergency = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsRushCertificate = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ProjectCode = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                name: "dbstandardanswer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsYesNo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Question = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StandardQuestionId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbstandardanswer", x => x.Id);
                    table.ForeignKey(
                        name: "fk_standard_answer_project",
                        column: x => x.ProjectId,
                        principalTable: "dbproject",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbstandardquestion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StandardId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Question = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbstandardquestion", x => x.Id);
                    table.ForeignKey(
                        name: "fk_standard_question_standard",
                        column: x => x.StandardId,
                        principalTable: "dbstandard",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProjectStandardCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectStandardCategory", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbprojectstandard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ProjectStandardCategoryId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbprojectstandard", x => x.Id);
                    table.ForeignKey(
                        name: "fk_project_standard_project",
                        column: x => x.ProjectId,
                        principalTable: "dbproject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "fk_project_standard_project_standard_category",
                        column: x => x.ProjectStandardCategoryId,
                        principalTable: "ProjectStandardCategory",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "dbclient",
                columns: new[] { "Id", "AccountName", "AccountNumber", "AccountRole", "ActiveAt", "Address", "BusinessLicenseFile", "City", "CompanyName", "ContactPerson", "CreatedAt", "DeletedAt", "District", "Dob", "Email", "FaxNumber", "IDCardNumber", "IsActive", "IsDeleted", "IsThirdParty", "IsVerified", "Password", "Phone", "Representator", "RepresentatorTitle", "TaxNumber", "UpdatedAt", "VerifiedAt", "Ward", "Website" },
                values: new object[,]
                {
                    { new Guid("4a735124-2eaa-4567-98f4-0bffe2a0cda4"), "client 1", 128743, 0, new DateTime(2024, 3, 14, 16, 55, 17, 567, DateTimeKind.Local).AddTicks(6208), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCC", "0982288888", new DateTime(2024, 3, 14, 16, 55, 17, 567, DateTimeKind.Local).AddTicks(6208), null, "10", null, "client_1@gmail.com", "10099922", "1235888570", true, false, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 14, 16, 55, 17, 567, DateTimeKind.Local).AddTicks(6209), "5", "scc.com" },
                    { new Guid("cafe2325-8400-4efc-bda5-61b3bb5d061b"), "client 2", 123587, 0, new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(2999), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCB", "0982288888", new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(2998), null, "10", null, "client_2@gmail.com", "10099922", "1235888570", true, false, true, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3000), "5", "scc.com" }
                });

            migrationBuilder.InsertData(
                table: "dbstandard",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "StandardCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0d50ac6f-87d2-4560-b82f-b09f0c0f6123"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3043), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Mohair Có Trách Nhiệm", "RMS", null },
                    { new Guid("20094066-dd29-412b-8aab-9237ef79ca72"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3033), null, "IDFL may not issue a GRS scope certificate to an organization which holds a RCS scope certificate with another certification body, unless the RCS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Recycled Standard", "GRS", null },
                    { new Guid("281f8d38-063b-4805-8298-736d2e7d333d"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3038), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Animal Fiber", "RAF", null },
                    { new Guid("29c43274-df4a-43f1-a064-f8efaf0d01a5"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3029), null, "IDFL may not issue an OCS scope certificate to an organization which holds a GOTS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Organic Content Standard", "OCS", null },
                    { new Guid("3bce5c66-c742-4af8-9866-ca5bd0384c95"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3031), null, "IDFL may not issue a GOTS scope certificate to an organization which holds a OCS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Organic Textile Standard", "GOTS", null },
                    { new Guid("a3178844-d33b-47b2-bd4e-14c0ea852749"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3039), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Len Có Trách Nhiệm", "RWS", null },
                    { new Guid("d6feb4e9-45bf-40f8-93bc-c8aec6460684"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3045), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Alpaca Có Trách Nhiệm", "RAS", null },
                    { new Guid("e4e59734-62b8-455b-aca8-84cacf3ca980"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3035), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Recycled Claim Standard", "RCS", null },
                    { new Guid("f521b970-4674-44a9-8f82-8dbe5cd4f7fe"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3036), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Down Standard", "RDS", null }
                });

            migrationBuilder.InsertData(
                table: "dbuser",
                columns: new[] { "Id", "AccountName", "ActiveDateAt", "Address", "City", "CreatedAt", "DeletedAt", "DeletedDateAt", "District", "Dob", "Email", "Icon", "IsActive", "IsDeleted", "IsVerified", "Password", "Phone", "Roles", "SubTitle", "Title", "UpdatedAt", "VerifiedDateAt", "Ward" },
                values: new object[,]
                {
                    { new Guid("7bd6c441-9558-4180-b0b7-2b8245bbc7f6"), "Pham Anh Teo", new DateTime(2024, 3, 14, 16, 55, 17, 566, DateTimeKind.Local).AddTicks(2582), null, null, new DateTime(2024, 3, 14, 16, 55, 17, 566, DateTimeKind.Local).AddTicks(2581), null, null, null, null, "test_2@gmail.com", "https://picsum.photos/24", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, "Auditor", null, new DateTime(2024, 3, 14, 16, 55, 17, 566, DateTimeKind.Local).AddTicks(2582), null },
                    { new Guid("8c3b7104-2842-46d9-86a3-836d0b724640"), "Pham Anh Doan", new DateTime(2024, 3, 14, 16, 55, 17, 565, DateTimeKind.Local).AddTicks(5793), null, null, new DateTime(2024, 3, 14, 16, 55, 17, 565, DateTimeKind.Local).AddTicks(5777), null, null, null, null, "test_1@gmail.com", "https://picsum.photos/24", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 0, null, "Developer", null, new DateTime(2024, 3, 14, 16, 55, 17, 565, DateTimeKind.Local).AddTicks(5797), null },
                    { new Guid("9aba2d39-8acf-41c3-9dee-109ca8b15e48"), "Tran thanh sang", new DateTime(2024, 3, 14, 16, 55, 17, 566, DateTimeKind.Local).AddTicks(9360), null, null, new DateTime(2024, 3, 14, 16, 55, 17, 566, DateTimeKind.Local).AddTicks(9359), null, null, null, null, "test_3@gmail.com", "https://picsum.photos/24", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, "Auditor Supervisor", null, new DateTime(2024, 3, 14, 16, 55, 17, 566, DateTimeKind.Local).AddTicks(9361), null }
                });

            migrationBuilder.InsertData(
                table: "dbproject",
                columns: new[] { "Id", "CertificationBody", "CertificationExpirationDate", "ClientId", "CreatedAt", "DeletedAt", "HandledBy", "IdflCode", "IsAnotherCertification", "IsDeleted", "IsInitialCertification", "IsRenewalCertification", "IssueCertificated", "IssueCertificatedDate", "LicenseNo", "PayerId", "ProjectGeneralId", "StandardId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("51ce1a80-cad2-48a5-b971-4ad73cef3a27"), "Test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4a735124-2eaa-4567-98f4-0bffe2a0cda4"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3117), null, null, "223787XC", true, false, true, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12233XYUC", null, null, new Guid("29c43274-df4a-43f1-a064-f8efaf0d01a5"), "Pending", null },
                    { new Guid("75c45c16-8bc5-4ef1-8fff-e0b77402d0c8"), "certification 1", new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3120), new Guid("4a735124-2eaa-4567-98f4-0bffe2a0cda4"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3121), null, null, "223407XC", true, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12233XYUC", null, null, new Guid("29c43274-df4a-43f1-a064-f8efaf0d01a5"), "Verified", null },
                    { new Guid("830ae23a-567d-4db1-bbc3-278727c20d39"), "certification 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4a735124-2eaa-4567-98f4-0bffe2a0cda4"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3129), null, null, "223TTT009", true, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12233XYUC", null, null, new Guid("29c43274-df4a-43f1-a064-f8efaf0d01a5"), "Approved", null },
                    { new Guid("9b99e73c-1e12-48cf-a3e2-639d8bdf1bdd"), "certification 2", new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3123), new Guid("4a735124-2eaa-4567-98f4-0bffe2a0cda4"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3125), null, null, "223TTT010", true, false, true, false, true, new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3124), "12233XYUC", null, null, new Guid("29c43274-df4a-43f1-a064-f8efaf0d01a5"), "Certificated", null }
                });

            migrationBuilder.InsertData(
                table: "dbstandardquestion",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "Question", "StandardId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00b0d938-a5a2-4056-962f-95b94a8e19c9"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3073), null, null, true, "OEKO-TEX STEP Environmental Performance Requirements | Yêu cầu về Hiệu suất Môi trường của Oeko - Tex Step", new Guid("29c43274-df4a-43f1-a064-f8efaf0d01a5"), null },
                    { new Guid("0353506c-3b77-42c4-abf7-1df9e2a24616"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3074), null, null, true, "SCS Recycled Content Verification | Xác Minh Thành Phần Tái Chế SCS", new Guid("29c43274-df4a-43f1-a064-f8efaf0d01a5"), null },
                    { new Guid("93347d80-43a0-4072-85d1-56a3138fc952"), new DateTime(2024, 3, 14, 16, 55, 17, 568, DateTimeKind.Local).AddTicks(3069), null, null, true, "Are there any subcontractor facilities that trade / handle / process certified products in this scope of certification? If so, please indicate by noting in the List of Activities / Processes", new Guid("29c43274-df4a-43f1-a064-f8efaf0d01a5"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbproject_HandledBy",
                table: "dbproject",
                column: "HandledBy");

            migrationBuilder.CreateIndex(
                name: "IX_dbbooking_CompletedBy",
                table: "dbbooking",
                column: "CompletedBy");

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

            migrationBuilder.CreateIndex(
                name: "IX_dbstandardanswer_ProjectId",
                table: "dbstandardanswer",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_dbstandardquestion_StandardId",
                table: "dbstandardquestion",
                column: "StandardId");

            migrationBuilder.AddForeignKey(
                name: "FK_dbbooking_dbproject_ProjectId",
                table: "dbbooking",
                column: "ProjectId",
                principalTable: "dbproject",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dbbooking_dbuser_CompletedBy",
                table: "dbbooking",
                column: "CompletedBy",
                principalTable: "dbuser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "fk_project_client",
                table: "dbproject",
                column: "ClientId",
                principalTable: "dbclient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_project_standard",
                table: "dbproject",
                column: "StandardId",
                principalTable: "dbstandard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_project_user",
                table: "dbproject",
                column: "HandledBy",
                principalTable: "dbuser",
                principalColumn: "Id");
        }
    }
}
