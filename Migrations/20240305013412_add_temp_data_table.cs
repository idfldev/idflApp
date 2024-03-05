using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflApp.Migrations
{
    /// <inheritdoc />
    public partial class add_temp_data_table : Migration
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
                    ClientId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectGeneralId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    PayerId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    BookId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
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
                    UserModelId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    AuditById = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CompletedById = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
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
                        principalColumn: "Id");
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
                    { new Guid("5a9caa69-2281-47ed-8059-5958f79eecf5"), "client 1", 128743, 0, new DateTime(2024, 3, 5, 8, 34, 12, 221, DateTimeKind.Local).AddTicks(9193), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCC", "0982288888", new DateTime(2024, 3, 5, 8, 34, 12, 221, DateTimeKind.Local).AddTicks(9192), null, "10", null, "client_1@gmail.com", "10099922", "1235888570", true, false, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 5, 8, 34, 12, 221, DateTimeKind.Local).AddTicks(9194), "5", "scc.com" },
                    { new Guid("b2782ba2-3b03-4275-9b77-cb8d950ec0a9"), "client 2", 123587, 0, new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6282), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCB", "0982288888", new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6281), null, "10", null, "client_2@gmail.com", "10099922", "1235888570", true, false, true, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6283), "5", "scc.com" }
                });

            migrationBuilder.InsertData(
                table: "dbstandard",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "StandardCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4aef00bc-ce0b-4341-ae0d-05b8ca86d291"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6334), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Len Có Trách Nhiệm", "RWS", null },
                    { new Guid("64941b2d-2d4b-4afa-8abe-b84eb8ec937c"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6331), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Down Standard", "RDS", null },
                    { new Guid("70c35c61-bda8-49fc-be16-89f8eb83806b"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6318), null, "IDFL may not issue a GRS scope certificate to an organization which holds a RCS scope certificate with another certification body, unless the RCS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Recycled Standard", "GRS", null },
                    { new Guid("75720a7f-b53d-43cf-aa4a-a771ec152fac"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6332), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Animal Fiber", "RAF", null },
                    { new Guid("95ebb065-6543-413e-829c-a08d1453d2d7"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6329), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Recycled Claim Standard", "RCS", null },
                    { new Guid("9898c778-92c9-4f8f-a0a9-36fadb3aa3ed"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6316), null, "IDFL may not issue a GOTS scope certificate to an organization which holds a OCS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Organic Textile Standard", "GOTS", null },
                    { new Guid("aae28554-b375-49c8-8560-d4a3b3e5dc40"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6335), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Mohair Có Trách Nhiệm", "RMS", null },
                    { new Guid("cff2fc8c-3446-4835-8e18-3cfc33f3aa9a"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6337), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Alpaca Có Trách Nhiệm", "RAS", null },
                    { new Guid("df96beec-9559-40fd-8ed3-1c88d7e0bd4c"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6314), null, "IDFL may not issue an OCS scope certificate to an organization which holds a GOTS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Organic Content Standard", "OCS", null }
                });

            migrationBuilder.InsertData(
                table: "dbuser",
                columns: new[] { "Id", "AccountName", "ActiveDateAt", "Address", "City", "CreatedAt", "DeletedAt", "DeletedDateAt", "District", "Dob", "Email", "IsActive", "IsDeleted", "IsVerified", "Password", "Phone", "Roles", "UpdatedAt", "VerifiedDateAt", "Ward" },
                values: new object[,]
                {
                    { new Guid("3a38085e-7311-4971-ac77-4f6d87d09e57"), "Test 1", new DateTime(2024, 3, 5, 8, 34, 12, 221, DateTimeKind.Local).AddTicks(2083), null, null, new DateTime(2024, 3, 5, 8, 34, 12, 221, DateTimeKind.Local).AddTicks(2082), null, null, null, null, "test_2@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, new DateTime(2024, 3, 5, 8, 34, 12, 221, DateTimeKind.Local).AddTicks(2084), null },
                    { new Guid("40e4d1e6-0b63-41fe-a812-8676d169a8d3"), "Test 1", new DateTime(2024, 3, 5, 8, 34, 12, 220, DateTimeKind.Local).AddTicks(5179), null, null, new DateTime(2024, 3, 5, 8, 34, 12, 220, DateTimeKind.Local).AddTicks(5166), null, null, null, null, "test_1@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 0, null, new DateTime(2024, 3, 5, 8, 34, 12, 220, DateTimeKind.Local).AddTicks(5181), null }
                });

            migrationBuilder.InsertData(
                table: "dbproject",
                columns: new[] { "Id", "ActiveDateAt", "BookId", "CertificatedDate", "CertificationBody", "CertificationExpirationDate", "ClientId", "ConfirmedByUserId", "ConfirmedDateAt", "CreatedAt", "DeletedAt", "DeletedDateAt", "IsActive", "IsAnotherCertification", "IsCertificated", "IsConfirmed", "IsDeleted", "IsInitialCertification", "IsRenewalCertification", "IsRequired", "LicenseNo", "PayerId", "ProjectGeneralId", "StandardId", "Status", "UpdatedAt" },
                values: new object[] { new Guid("f07956fd-55c2-4e4f-9195-9ced480dc073"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6395), null, new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6395), "Test", new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6392), new Guid("5a9caa69-2281-47ed-8059-5958f79eecf5"), new Guid("40e4d1e6-0b63-41fe-a812-8676d169a8d3"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6394), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6396), null, null, true, true, true, true, false, true, true, true, "12233XYUC", null, null, new Guid("df96beec-9559-40fd-8ed3-1c88d7e0bd4c"), (byte)1, null });

            migrationBuilder.InsertData(
                table: "dbstandardquestion",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "Question", "StandardId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4839bd38-1508-43be-854f-4c12187cd286"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6368), null, null, true, "SCS Recycled Content Verification | Xác Minh Thành Phần Tái Chế SCS", new Guid("df96beec-9559-40fd-8ed3-1c88d7e0bd4c"), null },
                    { new Guid("64071313-5446-483a-8d9e-660e57f48064"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6364), null, null, true, "OEKO-TEX STEP Environmental Performance Requirements | Yêu cầu về Hiệu suất Môi trường của Oeko - Tex Step", new Guid("df96beec-9559-40fd-8ed3-1c88d7e0bd4c"), null },
                    { new Guid("fad53f3d-6b20-4dd5-ac5a-07bdf064180f"), new DateTime(2024, 3, 5, 8, 34, 12, 222, DateTimeKind.Local).AddTicks(6362), null, null, true, "Are there any subcontractor facilities that trade / handle / process certified products in this scope of certification? If so, please indicate by noting in the List of Activities / Processes", new Guid("df96beec-9559-40fd-8ed3-1c88d7e0bd4c"), null }
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
