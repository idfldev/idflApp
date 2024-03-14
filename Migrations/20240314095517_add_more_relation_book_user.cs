using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflApp.Migrations
{
    /// <inheritdoc />
    public partial class add_more_relation_book_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_dbbookusertable",
                table: "dbbookusertable");

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

            migrationBuilder.RenameTable(
                name: "dbbookusertable",
                newName: "dbbookuser");

            migrationBuilder.RenameIndex(
                name: "IX_dbbookusertable_BookId",
                table: "dbbookuser",
                newName: "IX_dbbookuser_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbbookuser",
                table: "dbbookuser",
                column: "Id");

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
                name: "IX_dbbookuser_AuditorId",
                table: "dbbookuser",
                column: "AuditorId");

            migrationBuilder.AddForeignKey(
                name: "fk_book_user_table_user",
                table: "dbbookuser",
                column: "AuditorId",
                principalTable: "dbuser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_book_user_table_user",
                table: "dbbookuser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dbbookuser",
                table: "dbbookuser");

            migrationBuilder.DropIndex(
                name: "IX_dbbookuser_AuditorId",
                table: "dbbookuser");

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
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("00b0d938-a5a2-4056-962f-95b94a8e19c9"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("0353506c-3b77-42c4-abf7-1df9e2a24616"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("93347d80-43a0-4072-85d1-56a3138fc952"));

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

            migrationBuilder.RenameTable(
                name: "dbbookuser",
                newName: "dbbookusertable");

            migrationBuilder.RenameIndex(
                name: "IX_dbbookuser_BookId",
                table: "dbbookusertable",
                newName: "IX_dbbookusertable_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbbookusertable",
                table: "dbbookusertable",
                column: "Id");

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
        }
    }
}
