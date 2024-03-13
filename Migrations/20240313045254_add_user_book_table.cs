using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflApp.Migrations
{
    /// <inheritdoc />
    public partial class add_user_book_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbbooking_dbuser_CompletedBy",
                table: "dbbooking");

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("9cf262b7-d7e4-4a57-b0ed-0ce987c0e8ef"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("1ae71337-a62f-4eb8-8fc3-9947844a99b7"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("352711f1-354c-4d65-ad43-934b71019fd5"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("3b850aef-f30d-4128-a1fb-c13ee940bee9"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("51e5ef79-f1e0-4859-a10b-95eb4510c73d"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("4d5a69a4-6492-491a-915f-b1f1f7a58b82"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("9d1c727a-3430-443a-978b-b7a329fe5106"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("a1ea554c-9585-4981-92b2-61a2a0534f6e"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("c8d1d613-71ce-4499-adf9-a52696c93c82"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("ccbedc05-d8e2-4150-8485-72c16d496f2f"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("d9ff26c9-5168-4534-b5de-a000e4f30c04"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("dc6f10a4-32b9-429a-aa4b-59ef3949a8e4"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("e2e8bd7d-01e7-4d20-847d-ae49c824d80b"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("2f0f6fab-9564-46b8-b473-eea4340291d7"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("420aeb0f-2440-4567-9f7b-93335203a425"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("be2b9a90-5785-42f8-8df1-f985369368d6"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("02d88ab8-b2a1-46c9-9f5f-22288b28418f"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("1637e1e7-d25c-4021-bd18-eb8dea60d389"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("6877cf08-4b96-44cd-aa9e-4154021a7bad"));

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("faec6807-5fd5-44f7-8a76-a7e88dfe4515"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("b93663f7-30a1-4154-ad03-6191c0c6006c"));

            migrationBuilder.DropColumn(
                name: "AuditBy",
                table: "dbbooking");

            migrationBuilder.CreateTable(
                name: "dbbookusertable",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AuditorId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BookId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbbookusertable", x => x.Id);
                    table.ForeignKey(
                        name: "fk_book_user_table_book",
                        column: x => x.BookId,
                        principalTable: "dbbooking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "dbclient",
                columns: new[] { "Id", "AccountName", "AccountNumber", "AccountRole", "ActiveAt", "Address", "BusinessLicenseFile", "City", "CompanyName", "ContactPerson", "CreatedAt", "DeletedAt", "District", "Dob", "Email", "FaxNumber", "IDCardNumber", "IsActive", "IsDeleted", "IsThirdParty", "IsVerified", "Password", "Phone", "Representator", "RepresentatorTitle", "TaxNumber", "UpdatedAt", "VerifiedAt", "Ward", "Website" },
                values: new object[,]
                {
                    { new Guid("dfeeb086-a786-45c2-b0bc-7f85c32378e5"), "client 2", 123587, 0, new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4788), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCB", "0982288888", new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4783), null, "10", null, "client_2@gmail.com", "10099922", "1235888570", true, false, true, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4789), "5", "scc.com" },
                    { new Guid("e0eabd7c-540a-4214-b2b4-8102d86699e2"), "client 1", 128743, 0, new DateTime(2024, 3, 13, 11, 52, 54, 421, DateTimeKind.Local).AddTicks(7631), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCC", "0982288888", new DateTime(2024, 3, 13, 11, 52, 54, 421, DateTimeKind.Local).AddTicks(7627), null, "10", null, "client_1@gmail.com", "10099922", "1235888570", true, false, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 13, 11, 52, 54, 421, DateTimeKind.Local).AddTicks(7634), "5", "scc.com" }
                });

            migrationBuilder.InsertData(
                table: "dbstandard",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "StandardCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("197cd40d-8b76-4184-bf92-37b30fbddb28"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4896), null, "IDFL may not issue a GOTS scope certificate to an organization which holds a OCS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Organic Textile Standard", "GOTS", null },
                    { new Guid("2ecf7c41-0b8a-48cf-8a01-02733675e942"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4904), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Recycled Claim Standard", "RCS", null },
                    { new Guid("428387cd-78aa-496c-bfb1-f071923566af"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4898), null, "IDFL may not issue a GRS scope certificate to an organization which holds a RCS scope certificate with another certification body, unless the RCS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Recycled Standard", "GRS", null },
                    { new Guid("43783d44-651e-4729-8917-4493d042cff8"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4893), null, "IDFL may not issue an OCS scope certificate to an organization which holds a GOTS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Organic Content Standard", "OCS", null },
                    { new Guid("827b59c4-3352-4894-aafe-6aa481c73c89"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4909), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Len Có Trách Nhiệm", "RWS", null },
                    { new Guid("98bccc47-d4c9-4b3b-84cd-f7e85ac0169e"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4912), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Alpaca Có Trách Nhiệm", "RAS", null },
                    { new Guid("a12ec893-5cc4-47f5-9daf-eb8dc1d002e6"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4907), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Animal Fiber", "RAF", null },
                    { new Guid("ae8ab4f9-15b2-4fd5-b9ed-4a2d5204e3e3"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4906), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Down Standard", "RDS", null },
                    { new Guid("e5b5d400-bc26-4a56-b3c3-03da1dc3e989"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4911), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Mohair Có Trách Nhiệm", "RMS", null }
                });

            migrationBuilder.InsertData(
                table: "dbuser",
                columns: new[] { "Id", "AccountName", "ActiveDateAt", "Address", "City", "CreatedAt", "DeletedAt", "DeletedDateAt", "District", "Dob", "Email", "Icon", "IsActive", "IsDeleted", "IsVerified", "Password", "Phone", "Roles", "SubTitle", "Title", "UpdatedAt", "VerifiedDateAt", "Ward" },
                values: new object[,]
                {
                    { new Guid("2bb14793-b212-400f-9916-846757d1f96a"), "Tran thanh sang", new DateTime(2024, 3, 13, 11, 52, 54, 420, DateTimeKind.Local).AddTicks(9223), null, null, new DateTime(2024, 3, 13, 11, 52, 54, 420, DateTimeKind.Local).AddTicks(9222), null, null, null, null, "test_3@gmail.com", "https://picsum.photos/24", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, "Auditor Supervisor", null, new DateTime(2024, 3, 13, 11, 52, 54, 420, DateTimeKind.Local).AddTicks(9223), null },
                    { new Guid("d149adac-0d34-4c68-8e45-c375c8c31fef"), "Pham Anh Doan", new DateTime(2024, 3, 13, 11, 52, 54, 419, DateTimeKind.Local).AddTicks(5574), null, null, new DateTime(2024, 3, 13, 11, 52, 54, 419, DateTimeKind.Local).AddTicks(5562), null, null, null, null, "test_1@gmail.com", "https://picsum.photos/24", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 0, null, "Developer", null, new DateTime(2024, 3, 13, 11, 52, 54, 419, DateTimeKind.Local).AddTicks(5576), null },
                    { new Guid("f37be52c-d08f-429d-94be-5aa90a54e35e"), "Pham Anh Teo", new DateTime(2024, 3, 13, 11, 52, 54, 420, DateTimeKind.Local).AddTicks(2405), null, null, new DateTime(2024, 3, 13, 11, 52, 54, 420, DateTimeKind.Local).AddTicks(2404), null, null, null, null, "test_2@gmail.com", "https://picsum.photos/24", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, "Auditor", null, new DateTime(2024, 3, 13, 11, 52, 54, 420, DateTimeKind.Local).AddTicks(2405), null }
                });

            migrationBuilder.InsertData(
                table: "dbproject",
                columns: new[] { "Id", "CertificationBody", "CertificationExpirationDate", "ClientId", "CreatedAt", "DeletedAt", "HandledBy", "IdflCode", "IsAnotherCertification", "IsDeleted", "IsInitialCertification", "IsRenewalCertification", "IssueCertificated", "IssueCertificatedDate", "LicenseNo", "PayerId", "ProjectGeneralId", "StandardId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("07085e67-92e9-483d-b75b-d32db3a2d351"), "Test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e0eabd7c-540a-4214-b2b4-8102d86699e2"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(5034), null, null, "223787XC", true, false, true, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12233XYUC", null, null, new Guid("43783d44-651e-4729-8917-4493d042cff8"), "Pending", null },
                    { new Guid("0d9bd992-a76a-43d5-8fc7-87f6d9b33266"), "certification 2", new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(5041), new Guid("e0eabd7c-540a-4214-b2b4-8102d86699e2"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(5042), null, null, "223TTT010", true, false, true, false, true, new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(5042), "12233XYUC", null, null, new Guid("43783d44-651e-4729-8917-4493d042cff8"), "Certificated", null },
                    { new Guid("4c06d574-f2d3-4ced-a07b-8ebdaa5560ea"), "certification 1", new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(5037), new Guid("e0eabd7c-540a-4214-b2b4-8102d86699e2"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(5038), null, null, "223407XC", true, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12233XYUC", null, null, new Guid("43783d44-651e-4729-8917-4493d042cff8"), "Verified", null },
                    { new Guid("b4f2cac4-1243-4977-91e2-ebce3cc5e724"), "certification 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e0eabd7c-540a-4214-b2b4-8102d86699e2"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(5045), null, null, "223TTT009", true, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12233XYUC", null, null, new Guid("43783d44-651e-4729-8917-4493d042cff8"), "Approved", null }
                });

            migrationBuilder.InsertData(
                table: "dbstandardquestion",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "Question", "StandardId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("280a9d41-052b-4706-9807-3c492ef4bf22"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4961), null, null, true, "SCS Recycled Content Verification | Xác Minh Thành Phần Tái Chế SCS", new Guid("43783d44-651e-4729-8917-4493d042cff8"), null },
                    { new Guid("67dab7a8-ea9d-4a9f-a363-7bc91e0a0178"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4953), null, null, true, "Are there any subcontractor facilities that trade / handle / process certified products in this scope of certification? If so, please indicate by noting in the List of Activities / Processes", new Guid("43783d44-651e-4729-8917-4493d042cff8"), null },
                    { new Guid("83df4dde-5325-4ad8-b53a-2c4254f26efa"), new DateTime(2024, 3, 13, 11, 52, 54, 422, DateTimeKind.Local).AddTicks(4957), null, null, true, "OEKO-TEX STEP Environmental Performance Requirements | Yêu cầu về Hiệu suất Môi trường của Oeko - Tex Step", new Guid("43783d44-651e-4729-8917-4493d042cff8"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbbookusertable_BookId",
                table: "dbbookusertable",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_dbbooking_dbuser_CompletedBy",
                table: "dbbooking",
                column: "CompletedBy",
                principalTable: "dbuser",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbbooking_dbuser_CompletedBy",
                table: "dbbooking");

            migrationBuilder.DropTable(
                name: "dbbookusertable");

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("dfeeb086-a786-45c2-b0bc-7f85c32378e5"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("07085e67-92e9-483d-b75b-d32db3a2d351"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("0d9bd992-a76a-43d5-8fc7-87f6d9b33266"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("4c06d574-f2d3-4ced-a07b-8ebdaa5560ea"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("b4f2cac4-1243-4977-91e2-ebce3cc5e724"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("197cd40d-8b76-4184-bf92-37b30fbddb28"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("2ecf7c41-0b8a-48cf-8a01-02733675e942"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("428387cd-78aa-496c-bfb1-f071923566af"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("827b59c4-3352-4894-aafe-6aa481c73c89"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("98bccc47-d4c9-4b3b-84cd-f7e85ac0169e"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("a12ec893-5cc4-47f5-9daf-eb8dc1d002e6"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("ae8ab4f9-15b2-4fd5-b9ed-4a2d5204e3e3"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("e5b5d400-bc26-4a56-b3c3-03da1dc3e989"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("280a9d41-052b-4706-9807-3c492ef4bf22"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("67dab7a8-ea9d-4a9f-a363-7bc91e0a0178"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("83df4dde-5325-4ad8-b53a-2c4254f26efa"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("2bb14793-b212-400f-9916-846757d1f96a"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("d149adac-0d34-4c68-8e45-c375c8c31fef"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("f37be52c-d08f-429d-94be-5aa90a54e35e"));

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("e0eabd7c-540a-4214-b2b4-8102d86699e2"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("43783d44-651e-4729-8917-4493d042cff8"));

            migrationBuilder.AddColumn<Guid>(
                name: "AuditBy",
                table: "dbbooking",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "dbclient",
                columns: new[] { "Id", "AccountName", "AccountNumber", "AccountRole", "ActiveAt", "Address", "BusinessLicenseFile", "City", "CompanyName", "ContactPerson", "CreatedAt", "DeletedAt", "District", "Dob", "Email", "FaxNumber", "IDCardNumber", "IsActive", "IsDeleted", "IsThirdParty", "IsVerified", "Password", "Phone", "Representator", "RepresentatorTitle", "TaxNumber", "UpdatedAt", "VerifiedAt", "Ward", "Website" },
                values: new object[,]
                {
                    { new Guid("9cf262b7-d7e4-4a57-b0ed-0ce987c0e8ef"), "client 2", 123587, 0, new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(7950), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCB", "0982288888", new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(7948), null, "10", null, "client_2@gmail.com", "10099922", "1235888570", true, false, true, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(7951), "5", "scc.com" },
                    { new Guid("faec6807-5fd5-44f7-8a76-a7e88dfe4515"), "client 1", 128743, 0, new DateTime(2024, 3, 12, 11, 31, 30, 355, DateTimeKind.Local).AddTicks(8698), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCC", "0982288888", new DateTime(2024, 3, 12, 11, 31, 30, 355, DateTimeKind.Local).AddTicks(8692), null, "10", null, "client_1@gmail.com", "10099922", "1235888570", true, false, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 12, 11, 31, 30, 355, DateTimeKind.Local).AddTicks(8700), "5", "scc.com" }
                });

            migrationBuilder.InsertData(
                table: "dbstandard",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "StandardCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4d5a69a4-6492-491a-915f-b1f1f7a58b82"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8155), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Mohair Có Trách Nhiệm", "RMS", null },
                    { new Guid("9d1c727a-3430-443a-978b-b7a329fe5106"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8075), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Animal Fiber", "RAF", null },
                    { new Guid("a1ea554c-9585-4981-92b2-61a2a0534f6e"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8073), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Down Standard", "RDS", null },
                    { new Guid("b93663f7-30a1-4154-ad03-6191c0c6006c"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8057), null, "IDFL may not issue an OCS scope certificate to an organization which holds a GOTS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Organic Content Standard", "OCS", null },
                    { new Guid("c8d1d613-71ce-4499-adf9-a52696c93c82"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8157), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Alpaca Có Trách Nhiệm", "RAS", null },
                    { new Guid("ccbedc05-d8e2-4150-8485-72c16d496f2f"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8060), null, "IDFL may not issue a GOTS scope certificate to an organization which holds a OCS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Organic Textile Standard", "GOTS", null },
                    { new Guid("d9ff26c9-5168-4534-b5de-a000e4f30c04"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8071), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Recycled Claim Standard", "RCS", null },
                    { new Guid("dc6f10a4-32b9-429a-aa4b-59ef3949a8e4"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8076), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Len Có Trách Nhiệm", "RWS", null },
                    { new Guid("e2e8bd7d-01e7-4d20-847d-ae49c824d80b"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8063), null, "IDFL may not issue a GRS scope certificate to an organization which holds a RCS scope certificate with another certification body, unless the RCS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Recycled Standard", "GRS", null }
                });

            migrationBuilder.InsertData(
                table: "dbuser",
                columns: new[] { "Id", "AccountName", "ActiveDateAt", "Address", "City", "CreatedAt", "DeletedAt", "DeletedDateAt", "District", "Dob", "Email", "Icon", "IsActive", "IsDeleted", "IsVerified", "Password", "Phone", "Roles", "SubTitle", "Title", "UpdatedAt", "VerifiedDateAt", "Ward" },
                values: new object[,]
                {
                    { new Guid("02d88ab8-b2a1-46c9-9f5f-22288b28418f"), "Pham Anh Teo", new DateTime(2024, 3, 12, 11, 31, 30, 353, DateTimeKind.Local).AddTicks(8644), null, null, new DateTime(2024, 3, 12, 11, 31, 30, 353, DateTimeKind.Local).AddTicks(8642), null, null, null, null, "test_2@gmail.com", "https://picsum.photos/24", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, "Auditor", null, new DateTime(2024, 3, 12, 11, 31, 30, 353, DateTimeKind.Local).AddTicks(8645), null },
                    { new Guid("1637e1e7-d25c-4021-bd18-eb8dea60d389"), "Tran thanh sang", new DateTime(2024, 3, 12, 11, 31, 30, 354, DateTimeKind.Local).AddTicks(8554), null, null, new DateTime(2024, 3, 12, 11, 31, 30, 354, DateTimeKind.Local).AddTicks(8548), null, null, null, null, "test_3@gmail.com", "https://picsum.photos/24", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, "Auditor Supervisor", null, new DateTime(2024, 3, 12, 11, 31, 30, 354, DateTimeKind.Local).AddTicks(8555), null },
                    { new Guid("6877cf08-4b96-44cd-aa9e-4154021a7bad"), "Pham Anh Doan", new DateTime(2024, 3, 12, 11, 31, 30, 352, DateTimeKind.Local).AddTicks(9008), null, null, new DateTime(2024, 3, 12, 11, 31, 30, 352, DateTimeKind.Local).AddTicks(8988), null, null, null, null, "test_1@gmail.com", "https://picsum.photos/24", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 0, null, "Developer", null, new DateTime(2024, 3, 12, 11, 31, 30, 352, DateTimeKind.Local).AddTicks(9009), null }
                });

            migrationBuilder.InsertData(
                table: "dbproject",
                columns: new[] { "Id", "CertificationBody", "CertificationExpirationDate", "ClientId", "CreatedAt", "DeletedAt", "HandledBy", "IdflCode", "IsAnotherCertification", "IsDeleted", "IsInitialCertification", "IsRenewalCertification", "IssueCertificated", "IssueCertificatedDate", "LicenseNo", "PayerId", "ProjectGeneralId", "StandardId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1ae71337-a62f-4eb8-8fc3-9947844a99b7"), "certification 2", new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8248), new Guid("faec6807-5fd5-44f7-8a76-a7e88dfe4515"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8250), null, null, "223TTT010", true, false, true, false, true, new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8249), "12233XYUC", null, null, new Guid("b93663f7-30a1-4154-ad03-6191c0c6006c"), "Certificated", null },
                    { new Guid("352711f1-354c-4d65-ad43-934b71019fd5"), "Test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("faec6807-5fd5-44f7-8a76-a7e88dfe4515"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8240), null, null, "223787XC", true, false, true, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12233XYUC", null, null, new Guid("b93663f7-30a1-4154-ad03-6191c0c6006c"), "Pending", null },
                    { new Guid("3b850aef-f30d-4128-a1fb-c13ee940bee9"), "certification 1", new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8244), new Guid("faec6807-5fd5-44f7-8a76-a7e88dfe4515"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8245), null, null, "223407XC", true, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12233XYUC", null, null, new Guid("b93663f7-30a1-4154-ad03-6191c0c6006c"), "Verified", null },
                    { new Guid("51e5ef79-f1e0-4859-a10b-95eb4510c73d"), "certification 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("faec6807-5fd5-44f7-8a76-a7e88dfe4515"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8253), null, null, "223TTT009", true, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12233XYUC", null, null, new Guid("b93663f7-30a1-4154-ad03-6191c0c6006c"), "Approved", null }
                });

            migrationBuilder.InsertData(
                table: "dbstandardquestion",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "Question", "StandardId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2f0f6fab-9564-46b8-b473-eea4340291d7"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8192), null, null, true, "Are there any subcontractor facilities that trade / handle / process certified products in this scope of certification? If so, please indicate by noting in the List of Activities / Processes", new Guid("b93663f7-30a1-4154-ad03-6191c0c6006c"), null },
                    { new Guid("420aeb0f-2440-4567-9f7b-93335203a425"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8200), null, null, true, "SCS Recycled Content Verification | Xác Minh Thành Phần Tái Chế SCS", new Guid("b93663f7-30a1-4154-ad03-6191c0c6006c"), null },
                    { new Guid("be2b9a90-5785-42f8-8df1-f985369368d6"), new DateTime(2024, 3, 12, 11, 31, 30, 356, DateTimeKind.Local).AddTicks(8195), null, null, true, "OEKO-TEX STEP Environmental Performance Requirements | Yêu cầu về Hiệu suất Môi trường của Oeko - Tex Step", new Guid("b93663f7-30a1-4154-ad03-6191c0c6006c"), null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_dbbooking_dbuser_CompletedBy",
                table: "dbbooking",
                column: "CompletedBy",
                principalTable: "dbuser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
