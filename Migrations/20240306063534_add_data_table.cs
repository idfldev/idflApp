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
                    BookId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
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
                    { new Guid("47896a19-b739-4466-8c04-a15c421ff780"), "client 1", 128743, 0, new DateTime(2024, 3, 6, 13, 35, 34, 740, DateTimeKind.Local).AddTicks(2708), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCC", "0982288888", new DateTime(2024, 3, 6, 13, 35, 34, 740, DateTimeKind.Local).AddTicks(2706), null, "10", null, "client_1@gmail.com", "10099922", "1235888570", true, false, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 6, 13, 35, 34, 740, DateTimeKind.Local).AddTicks(2709), "5", "scc.com" },
                    { new Guid("f5e77044-f8bc-4031-b3b4-ed121afe1ff8"), "client 2", 123587, 0, new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(418), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCB", "0982288888", new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(414), null, "10", null, "client_2@gmail.com", "10099922", "1235888570", true, false, true, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(419), "5", "scc.com" }
                });

            migrationBuilder.InsertData(
                table: "dbstandard",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "StandardCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2ccf6ef9-e06f-484c-a51c-fd9e67975118"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(533), null, "IDFL may not issue a GOTS scope certificate to an organization which holds a OCS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Organic Textile Standard", "GOTS", null },
                    { new Guid("628501b9-2821-4469-8f48-c527421d8e20"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(548), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Alpaca Có Trách Nhiệm", "RAS", null },
                    { new Guid("9345e936-9d53-4793-bf3d-d0c7a36f7fc3"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(546), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Mohair Có Trách Nhiệm", "RMS", null },
                    { new Guid("96370b7b-ecfb-40f2-b4bd-db86a87dee17"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(535), null, "IDFL may not issue a GRS scope certificate to an organization which holds a RCS scope certificate with another certification body, unless the RCS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Recycled Standard", "GRS", null },
                    { new Guid("ae2f32cc-fad4-42df-87a8-656fe9bef995"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(530), null, "IDFL may not issue an OCS scope certificate to an organization which holds a GOTS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Organic Content Standard", "OCS", null },
                    { new Guid("b44382e1-d93e-4cd8-afe7-6d26adfeb392"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(542), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Len Có Trách Nhiệm", "RWS", null },
                    { new Guid("d0294ed1-5534-4e1a-8090-bf5dfb7dedcf"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(540), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Animal Fiber", "RAF", null },
                    { new Guid("eabb4ac6-3c38-4d7b-a618-da739f109d1e"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(537), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Recycled Claim Standard", "RCS", null },
                    { new Guid("ed944e61-dbca-43b9-bba2-b1a9298f2505"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(539), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Down Standard", "RDS", null }
                });

            migrationBuilder.InsertData(
                table: "dbuser",
                columns: new[] { "Id", "AccountName", "ActiveDateAt", "Address", "City", "CreatedAt", "DeletedAt", "DeletedDateAt", "District", "Dob", "Email", "IsActive", "IsDeleted", "IsVerified", "Password", "Phone", "Roles", "UpdatedAt", "VerifiedDateAt", "Ward" },
                values: new object[,]
                {
                    { new Guid("9757b502-b82c-4558-8cd2-66e86c41f63b"), "Test 1", new DateTime(2024, 3, 6, 13, 35, 34, 738, DateTimeKind.Local).AddTicks(8267), null, null, new DateTime(2024, 3, 6, 13, 35, 34, 738, DateTimeKind.Local).AddTicks(8254), null, null, null, null, "test_1@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 0, null, new DateTime(2024, 3, 6, 13, 35, 34, 738, DateTimeKind.Local).AddTicks(8270), null },
                    { new Guid("9a455c0a-f149-43ac-81a8-2f71975b4c7d"), "Test 1", new DateTime(2024, 3, 6, 13, 35, 34, 739, DateTimeKind.Local).AddTicks(5459), null, null, new DateTime(2024, 3, 6, 13, 35, 34, 739, DateTimeKind.Local).AddTicks(5457), null, null, null, null, "test_2@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, new DateTime(2024, 3, 6, 13, 35, 34, 739, DateTimeKind.Local).AddTicks(5460), null }
                });

            migrationBuilder.InsertData(
                table: "dbproject",
                columns: new[] { "Id", "BookId", "CertificationBody", "CertificationExpirationDate", "ClientId", "CreatedAt", "DeletedAt", "HandledBy", "IdflCode", "IsAnotherCertification", "IsDeleted", "IsInitialCertification", "IsRenewalCertification", "IssueCertificated", "IssueCertificatedDate", "LicenseNo", "PayerId", "ProjectGeneralId", "StandardId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("26db5f41-d572-4193-bdb7-56ec5c2487a3"), null, "project_3", new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(624), new Guid("47896a19-b739-4466-8c04-a15c421ff780"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(625), null, null, "223TTT009", true, false, true, false, true, new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(625), "12233XYUC", null, null, new Guid("ae2f32cc-fad4-42df-87a8-656fe9bef995"), "Completed", null },
                    { new Guid("56163402-81f5-4730-82c7-57cc0835c394"), null, "Test", new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(601), new Guid("47896a19-b739-4466-8c04-a15c421ff780"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(617), null, null, "223787XC", true, false, true, true, true, new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(617), "12233XYUC", null, null, new Guid("ae2f32cc-fad4-42df-87a8-656fe9bef995"), "Pending", null },
                    { new Guid("f9e391ad-b392-4e54-8ae7-8af430f68cba"), null, "Test", new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(620), new Guid("47896a19-b739-4466-8c04-a15c421ff780"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(622), null, null, "223487XC", true, false, true, false, false, new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(621), "12233XYUC", null, null, new Guid("ae2f32cc-fad4-42df-87a8-656fe9bef995"), "Verified", null }
                });

            migrationBuilder.InsertData(
                table: "dbstandardquestion",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "Question", "StandardId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("6a46c609-ee0d-4960-96b3-0ccaeb111b65"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(574), null, null, true, "Are there any subcontractor facilities that trade / handle / process certified products in this scope of certification? If so, please indicate by noting in the List of Activities / Processes", new Guid("ae2f32cc-fad4-42df-87a8-656fe9bef995"), null },
                    { new Guid("899f415b-6db2-407d-bedf-025ade556ca5"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(579), null, null, true, "SCS Recycled Content Verification | Xác Minh Thành Phần Tái Chế SCS", new Guid("ae2f32cc-fad4-42df-87a8-656fe9bef995"), null },
                    { new Guid("fb43f8ef-850c-4c79-94bf-515426377a4d"), new DateTime(2024, 3, 6, 13, 35, 34, 741, DateTimeKind.Local).AddTicks(577), null, null, true, "OEKO-TEX STEP Environmental Performance Requirements | Yêu cầu về Hiệu suất Môi trường của Oeko - Tex Step", new Guid("ae2f32cc-fad4-42df-87a8-656fe9bef995"), null }
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
