using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflApp.Migrations
{
    /// <inheritdoc />
    public partial class add_data_table : Migration
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
                name: "dbstandard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StandardCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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

            migrationBuilder.CreateTable(
                name: "ProjectStandardCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                name: "dbstandardquestion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Question = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    StandardId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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
                name: "dbproject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StandardId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IdflCode = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectGeneralId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    PayerId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsInitialCertification = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsRenewalCertification = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsAnotherCertification = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LicenseNo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CertificationBody = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CertificationExpirationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HandledBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IssueCertificated = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IssueCertificatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
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
                    table.ForeignKey(
                        name: "fk_project_user",
                        column: x => x.HandledBy,
                        principalTable: "dbuser",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbbooking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Purpose = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    AuditBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CompletedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsBooked = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CompletedNotes = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbbooking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbbooking_dbproject_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "dbproject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_dbbooking_dbuser_UserId",
                        column: x => x.UserId,
                        principalTable: "dbuser",
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
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ProjectStandardCategoryId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "fk_project_standard_project_standard_category",
                        column: x => x.ProjectStandardCategoryId,
                        principalTable: "ProjectStandardCategory",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "dbstandardanswer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Question = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StandardQuestionId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsYesNo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "dbclient",
                columns: new[] { "Id", "AccountName", "AccountNumber", "AccountRole", "ActiveAt", "Address", "BusinessLicenseFile", "City", "CompanyName", "ContactPerson", "CreatedAt", "DeletedAt", "District", "Dob", "Email", "FaxNumber", "IDCardNumber", "IsActive", "IsDeleted", "IsThirdParty", "IsVerified", "Password", "Phone", "Representator", "RepresentatorTitle", "TaxNumber", "UpdatedAt", "VerifiedAt", "Ward", "Website" },
                values: new object[,]
                {
                    { new Guid("36c18ca7-abb9-41c7-8b71-64d9633ae99e"), "client 1", 128743, 0, new DateTime(2024, 3, 8, 22, 15, 33, 556, DateTimeKind.Local).AddTicks(5309), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCC", "0982288888", new DateTime(2024, 3, 8, 22, 15, 33, 556, DateTimeKind.Local).AddTicks(5308), null, "10", null, "client_1@gmail.com", "10099922", "1235888570", true, false, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 8, 22, 15, 33, 556, DateTimeKind.Local).AddTicks(5312), "5", "scc.com" },
                    { new Guid("d704fd02-fa40-4544-b8dd-c834d5f29d3e"), "client 2", 123587, 0, new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3840), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCB", "0982288888", new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3834), null, "10", null, "client_2@gmail.com", "10099922", "1235888570", true, false, true, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3841), "5", "scc.com" }
                });

            migrationBuilder.InsertData(
                table: "dbstandard",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "StandardCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("245d58b9-6baf-44af-8649-4138af83b37c"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3960), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Len Có Trách Nhiệm", "RWS", null },
                    { new Guid("6397bfea-d9a3-4b56-9bcc-86d520b38e51"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3947), null, "IDFL may not issue a GOTS scope certificate to an organization which holds a OCS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Organic Textile Standard", "GOTS", null },
                    { new Guid("75eff706-8001-4ba4-bc40-2b2151680d2f"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3961), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Mohair Có Trách Nhiệm", "RMS", null },
                    { new Guid("7c277fc7-ed9b-434b-bd4d-5cb1bfd7d5be"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3955), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Recycled Claim Standard", "RCS", null },
                    { new Guid("b456ab46-89f8-4ba3-b88b-e9fed6f4ca32"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3945), null, "IDFL may not issue an OCS scope certificate to an organization which holds a GOTS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Organic Content Standard", "OCS", null },
                    { new Guid("c50b412b-4363-45ef-b881-61199aec3882"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3957), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Down Standard", "RDS", null },
                    { new Guid("c9a2f250-2e10-44cb-9aef-8ac75723a958"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3958), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Animal Fiber", "RAF", null },
                    { new Guid("d97c83a4-aa24-46ea-aa8a-2349dcc4eb54"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3953), null, "IDFL may not issue a GRS scope certificate to an organization which holds a RCS scope certificate with another certification body, unless the RCS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Recycled Standard", "GRS", null },
                    { new Guid("e26b2fa4-55b9-4672-b0b6-189d165bde9f"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3963), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Alpaca Có Trách Nhiệm", "RAS", null }
                });

            migrationBuilder.InsertData(
                table: "dbuser",
                columns: new[] { "Id", "AccountName", "ActiveDateAt", "Address", "City", "CreatedAt", "DeletedAt", "DeletedDateAt", "District", "Dob", "Email", "IsActive", "IsDeleted", "IsVerified", "Password", "Phone", "Roles", "UpdatedAt", "VerifiedDateAt", "Ward" },
                values: new object[,]
                {
                    { new Guid("193290ee-672b-4c92-bb68-484cc3e1f028"), "Test 2", new DateTime(2024, 3, 8, 22, 15, 33, 555, DateTimeKind.Local).AddTicks(8017), null, null, new DateTime(2024, 3, 8, 22, 15, 33, 555, DateTimeKind.Local).AddTicks(8015), null, null, null, null, "test_2@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, new DateTime(2024, 3, 8, 22, 15, 33, 555, DateTimeKind.Local).AddTicks(8018), null },
                    { new Guid("8f9d93c2-1cee-47b6-89cc-d7d83e5eb346"), "Test 1", new DateTime(2024, 3, 8, 22, 15, 33, 555, DateTimeKind.Local).AddTicks(850), null, null, new DateTime(2024, 3, 8, 22, 15, 33, 555, DateTimeKind.Local).AddTicks(838), null, null, null, null, "test_1@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 0, null, new DateTime(2024, 3, 8, 22, 15, 33, 555, DateTimeKind.Local).AddTicks(850), null }
                });

            migrationBuilder.InsertData(
                table: "dbproject",
                columns: new[] { "Id", "CertificationBody", "CertificationExpirationDate", "ClientId", "CreatedAt", "DeletedAt", "HandledBy", "IdflCode", "IsAnotherCertification", "IsDeleted", "IsInitialCertification", "IsRenewalCertification", "IssueCertificated", "IssueCertificatedDate", "LicenseNo", "PayerId", "ProjectGeneralId", "StandardId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("580c6acb-1ce2-4e10-8c21-7de800a3ffe6"), "certification 2", new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(4080), new Guid("36c18ca7-abb9-41c7-8b71-64d9633ae99e"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(4081), null, null, "223TTT009", true, false, true, false, true, new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(4081), "12233XYUC", null, null, new Guid("b456ab46-89f8-4ba3-b88b-e9fed6f4ca32"), "Completed", null },
                    { new Guid("a0106382-fa3e-4b8b-bf89-ad0523555d28"), "Test", new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(4022), new Guid("36c18ca7-abb9-41c7-8b71-64d9633ae99e"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(4038), null, null, "223787XC", true, false, true, true, true, new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(4037), "12233XYUC", null, null, new Guid("b456ab46-89f8-4ba3-b88b-e9fed6f4ca32"), "Pending", null },
                    { new Guid("a7c9043b-ea33-443c-abfd-55e34b15a72e"), "certification 1", new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(4076), new Guid("36c18ca7-abb9-41c7-8b71-64d9633ae99e"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(4078), null, null, "223487XC", true, false, true, false, false, new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(4077), "12233XYUC", null, null, new Guid("b456ab46-89f8-4ba3-b88b-e9fed6f4ca32"), "Verified", null }
                });

            migrationBuilder.InsertData(
                table: "dbstandardquestion",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "Question", "StandardId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("9cabd458-c107-4205-8752-4742408b01ac"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(3996), null, null, true, "Are there any subcontractor facilities that trade / handle / process certified products in this scope of certification? If so, please indicate by noting in the List of Activities / Processes", new Guid("b456ab46-89f8-4ba3-b88b-e9fed6f4ca32"), null },
                    { new Guid("d85fb191-c7f6-4c1e-83c6-decf01363f87"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(4002), null, null, true, "SCS Recycled Content Verification | Xác Minh Thành Phần Tái Chế SCS", new Guid("b456ab46-89f8-4ba3-b88b-e9fed6f4ca32"), null },
                    { new Guid("fd9fd505-7f2b-4243-89b1-6c1fab65ec3b"), new DateTime(2024, 3, 8, 22, 15, 33, 557, DateTimeKind.Local).AddTicks(4000), null, null, true, "OEKO-TEX STEP Environmental Performance Requirements | Yêu cầu về Hiệu suất Môi trường của Oeko - Tex Step", new Guid("b456ab46-89f8-4ba3-b88b-e9fed6f4ca32"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbbooking_ProjectId",
                table: "dbbooking",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_dbbooking_UserId",
                table: "dbbooking",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_dbproject_ClientId",
                table: "dbproject",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_dbproject_HandledBy",
                table: "dbproject",
                column: "HandledBy");

            migrationBuilder.CreateIndex(
                name: "IX_dbproject_IdflCode",
                table: "dbproject",
                column: "IdflCode",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_dbstandardanswer_ProjectId",
                table: "dbstandardanswer",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_dbstandardquestion_StandardId",
                table: "dbstandardquestion",
                column: "StandardId");
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
                name: "dbstandardanswer");

            migrationBuilder.DropTable(
                name: "dbstandardquestion");

            migrationBuilder.DropTable(
                name: "ProjectStandardCategory");

            migrationBuilder.DropTable(
                name: "dbproject");

            migrationBuilder.DropTable(
                name: "dbclient");

            migrationBuilder.DropTable(
                name: "dbstandard");

            migrationBuilder.DropTable(
                name: "dbuser");
        }
    }
}
