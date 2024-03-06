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
                name: "dbproject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StandardId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BookId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ClientId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectGeneralId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    PayerId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
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
                    ConfirmedByUserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
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
                name: "dbbooking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    AuditBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CompletedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Subject = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AuditedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
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
                    { new Guid("d1219868-b3cc-4218-8502-db40e6fb6a70"), "client 2", 123587, 0, new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6311), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCB", "0982288888", new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6310), null, "10", null, "client_2@gmail.com", "10099922", "1235888570", true, false, true, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6312), "5", "scc.com" },
                    { new Guid("d5a30990-25c0-463c-abb5-01607f2a2793"), "client 1", 128743, 0, new DateTime(2024, 3, 5, 22, 13, 46, 138, DateTimeKind.Local).AddTicks(9325), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCC", "0982288888", new DateTime(2024, 3, 5, 22, 13, 46, 138, DateTimeKind.Local).AddTicks(9321), null, "10", null, "client_1@gmail.com", "10099922", "1235888570", true, false, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 5, 22, 13, 46, 138, DateTimeKind.Local).AddTicks(9326), "5", "scc.com" }
                });

            migrationBuilder.InsertData(
                table: "dbstandard",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "StandardCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5c45b44d-c7ac-41a5-9a90-645aa8a08b8b"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6460), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Mohair Có Trách Nhiệm", "RMS", null },
                    { new Guid("72fbd03c-c19a-4a9d-b1a1-1aaf879429c1"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6453), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Recycled Claim Standard", "RCS", null },
                    { new Guid("b92141b9-3dd1-407f-b3f5-ba5ada8b9711"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6446), null, "IDFL may not issue a GOTS scope certificate to an organization which holds a OCS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Organic Textile Standard", "GOTS", null },
                    { new Guid("ca3131ca-74cf-46e1-9154-9be46ca59655"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6455), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Down Standard", "RDS", null },
                    { new Guid("cfc7a533-ab36-43cc-905b-bcba3f1bfb06"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6458), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Len Có Trách Nhiệm", "RWS", null },
                    { new Guid("d000f655-9e10-4786-b722-c3013a99484b"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6456), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Animal Fiber", "RAF", null },
                    { new Guid("dbb9dd05-8f9a-4df1-bb73-492e2b8cd68b"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6451), null, "IDFL may not issue a GRS scope certificate to an organization which holds a RCS scope certificate with another certification body, unless the RCS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Recycled Standard", "GRS", null },
                    { new Guid("f4ec2065-42b1-49ac-939b-67390be744f5"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6461), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Alpaca Có Trách Nhiệm", "RAS", null },
                    { new Guid("f83ea1d1-6027-4154-9d5b-86cf1f8762d9"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6444), null, "IDFL may not issue an OCS scope certificate to an organization which holds a GOTS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Organic Content Standard", "OCS", null }
                });

            migrationBuilder.InsertData(
                table: "dbuser",
                columns: new[] { "Id", "AccountName", "ActiveDateAt", "Address", "City", "CreatedAt", "DeletedAt", "DeletedDateAt", "District", "Dob", "Email", "IsActive", "IsDeleted", "IsVerified", "Password", "Phone", "Roles", "UpdatedAt", "VerifiedDateAt", "Ward" },
                values: new object[,]
                {
                    { new Guid("512c5fb5-8ed6-4a8c-acbd-2cf9ea672e22"), "Test 1", new DateTime(2024, 3, 5, 22, 13, 46, 138, DateTimeKind.Local).AddTicks(1674), null, null, new DateTime(2024, 3, 5, 22, 13, 46, 138, DateTimeKind.Local).AddTicks(1672), null, null, null, null, "test_2@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, new DateTime(2024, 3, 5, 22, 13, 46, 138, DateTimeKind.Local).AddTicks(1674), null },
                    { new Guid("c3fa981c-d5ad-4f87-8731-a643c690f2e9"), "Test 1", new DateTime(2024, 3, 5, 22, 13, 46, 137, DateTimeKind.Local).AddTicks(4608), null, null, new DateTime(2024, 3, 5, 22, 13, 46, 137, DateTimeKind.Local).AddTicks(4596), null, null, null, null, "test_1@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 0, null, new DateTime(2024, 3, 5, 22, 13, 46, 137, DateTimeKind.Local).AddTicks(4611), null }
                });

            migrationBuilder.InsertData(
                table: "dbproject",
                columns: new[] { "Id", "ActiveDateAt", "BookId", "CertificatedDate", "CertificationBody", "CertificationExpirationDate", "ClientId", "ConfirmedByUserId", "ConfirmedDateAt", "CreatedAt", "DeletedAt", "DeletedDateAt", "IsActive", "IsAnotherCertification", "IsCertificated", "IsConfirmed", "IsDeleted", "IsInitialCertification", "IsRenewalCertification", "IsRequired", "LicenseNo", "PayerId", "ProjectGeneralId", "StandardId", "Status", "UpdatedAt" },
                values: new object[] { new Guid("51ee6ad3-211f-4d98-b77f-14a398753d8f"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6577), null, new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6577), "Test", new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6574), new Guid("d5a30990-25c0-463c-abb5-01607f2a2793"), new Guid("c3fa981c-d5ad-4f87-8731-a643c690f2e9"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6576), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6578), null, null, true, true, true, true, false, true, true, true, "12233XYUC", null, null, new Guid("f83ea1d1-6027-4154-9d5b-86cf1f8762d9"), (byte)1, null });

            migrationBuilder.InsertData(
                table: "dbstandardquestion",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "Question", "StandardId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("81c29864-427a-4203-b999-b2923ff93def"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6492), null, null, true, "OEKO-TEX STEP Environmental Performance Requirements | Yêu cầu về Hiệu suất Môi trường của Oeko - Tex Step", new Guid("f83ea1d1-6027-4154-9d5b-86cf1f8762d9"), null },
                    { new Guid("f1322962-8a70-4e9a-85c1-276b82e0043a"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6494), null, null, true, "SCS Recycled Content Verification | Xác Minh Thành Phần Tái Chế SCS", new Guid("f83ea1d1-6027-4154-9d5b-86cf1f8762d9"), null },
                    { new Guid("fe0c98f8-8a04-4dae-b874-c01cab6d84df"), new DateTime(2024, 3, 5, 22, 13, 46, 139, DateTimeKind.Local).AddTicks(6488), null, null, true, "Are there any subcontractor facilities that trade / handle / process certified products in this scope of certification? If so, please indicate by noting in the List of Activities / Processes", new Guid("f83ea1d1-6027-4154-9d5b-86cf1f8762d9"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbbooking_ProjectId",
                table: "dbbooking",
                column: "ProjectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dbbooking_UserId",
                table: "dbbooking",
                column: "UserId");

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
                name: "dbuser");

            migrationBuilder.DropTable(
                name: "ProjectStandardCategory");

            migrationBuilder.DropTable(
                name: "dbproject");

            migrationBuilder.DropTable(
                name: "dbclient");

            migrationBuilder.DropTable(
                name: "dbstandard");
        }
    }
}
