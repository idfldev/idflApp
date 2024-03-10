using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflApp.Migrations
{
    /// <inheritdoc />
    public partial class add_relation_user_book : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbbooking_dbuser_UserId",
                table: "dbbooking");

            migrationBuilder.DropIndex(
                name: "IX_dbbooking_UserId",
                table: "dbbooking");

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("d704fd02-fa40-4544-b8dd-c834d5f29d3e"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("580c6acb-1ce2-4e10-8c21-7de800a3ffe6"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("a0106382-fa3e-4b8b-bf89-ad0523555d28"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("a7c9043b-ea33-443c-abfd-55e34b15a72e"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("245d58b9-6baf-44af-8649-4138af83b37c"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("6397bfea-d9a3-4b56-9bcc-86d520b38e51"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("75eff706-8001-4ba4-bc40-2b2151680d2f"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("7c277fc7-ed9b-434b-bd4d-5cb1bfd7d5be"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("c50b412b-4363-45ef-b881-61199aec3882"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("c9a2f250-2e10-44cb-9aef-8ac75723a958"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("d97c83a4-aa24-46ea-aa8a-2349dcc4eb54"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("e26b2fa4-55b9-4672-b0b6-189d165bde9f"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("9cabd458-c107-4205-8752-4742408b01ac"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("d85fb191-c7f6-4c1e-83c6-decf01363f87"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("fd9fd505-7f2b-4243-89b1-6c1fab65ec3b"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("193290ee-672b-4c92-bb68-484cc3e1f028"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("8f9d93c2-1cee-47b6-89cc-d7d83e5eb346"));

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("36c18ca7-abb9-41c7-8b71-64d9633ae99e"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("b456ab46-89f8-4ba3-b88b-e9fed6f4ca32"));

            migrationBuilder.InsertData(
                table: "dbclient",
                columns: new[] { "Id", "AccountName", "AccountNumber", "AccountRole", "ActiveAt", "Address", "BusinessLicenseFile", "City", "CompanyName", "ContactPerson", "CreatedAt", "DeletedAt", "District", "Dob", "Email", "FaxNumber", "IDCardNumber", "IsActive", "IsDeleted", "IsThirdParty", "IsVerified", "Password", "Phone", "Representator", "RepresentatorTitle", "TaxNumber", "UpdatedAt", "VerifiedAt", "Ward", "Website" },
                values: new object[,]
                {
                    { new Guid("38db3857-2553-4899-9ff4-32b5e077ffa6"), "client 2", 123587, 0, new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6469), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCB", "0982288888", new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6467), null, "10", null, "client_2@gmail.com", "10099922", "1235888570", true, false, true, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6470), "5", "scc.com" },
                    { new Guid("79c4f3cf-be88-4bcc-945d-cb9e16794852"), "client 1", 128743, 0, new DateTime(2024, 3, 9, 10, 8, 38, 115, DateTimeKind.Local).AddTicks(5877), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCC", "0982288888", new DateTime(2024, 3, 9, 10, 8, 38, 115, DateTimeKind.Local).AddTicks(5875), null, "10", null, "client_1@gmail.com", "10099922", "1235888570", true, false, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 9, 10, 8, 38, 115, DateTimeKind.Local).AddTicks(5878), "5", "scc.com" }
                });

            migrationBuilder.InsertData(
                table: "dbstandard",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "StandardCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1155761e-4468-4a7a-8d04-7d335e2bc001"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6560), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Alpaca Có Trách Nhiệm", "RAS", null },
                    { new Guid("3ac3e836-9759-4b1e-a6b2-6712178fd11f"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6543), null, "IDFL may not issue a GOTS scope certificate to an organization which holds a OCS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Organic Textile Standard", "GOTS", null },
                    { new Guid("6c4c8fe6-3370-4ef5-81b0-707219039140"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6547), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Recycled Claim Standard", "RCS", null },
                    { new Guid("6d06120a-9fd1-4c1d-b537-f7915bcba089"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6545), null, "IDFL may not issue a GRS scope certificate to an organization which holds a RCS scope certificate with another certification body, unless the RCS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Recycled Standard", "GRS", null },
                    { new Guid("6dfaafb3-5037-40e6-8f36-240776bb36e4"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6552), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Animal Fiber", "RAF", null },
                    { new Guid("73a346cf-d70f-4ade-93f3-671195318a70"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6558), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Mohair Có Trách Nhiệm", "RMS", null },
                    { new Guid("8e50186b-b7e8-4eec-b908-75da62a429a3"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6549), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Down Standard", "RDS", null },
                    { new Guid("b8c83c69-eab7-404a-8a1f-54e75f48b276"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6554), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Len Có Trách Nhiệm", "RWS", null },
                    { new Guid("f667feb2-c139-431f-8a00-de6aac0fa657"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6540), null, "IDFL may not issue an OCS scope certificate to an organization which holds a GOTS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Organic Content Standard", "OCS", null }
                });

            migrationBuilder.InsertData(
                table: "dbuser",
                columns: new[] { "Id", "AccountName", "ActiveDateAt", "Address", "City", "CreatedAt", "DeletedAt", "DeletedDateAt", "District", "Dob", "Email", "IsActive", "IsDeleted", "IsVerified", "Password", "Phone", "Roles", "UpdatedAt", "VerifiedDateAt", "Ward" },
                values: new object[,]
                {
                    { new Guid("33864b03-e2a9-437a-8997-30e7e583af97"), "Test 1", new DateTime(2024, 3, 9, 10, 8, 38, 113, DateTimeKind.Local).AddTicks(6304), null, null, new DateTime(2024, 3, 9, 10, 8, 38, 113, DateTimeKind.Local).AddTicks(6289), null, null, null, null, "test_1@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 0, null, new DateTime(2024, 3, 9, 10, 8, 38, 113, DateTimeKind.Local).AddTicks(6305), null },
                    { new Guid("711d3fa6-e181-4fec-86fe-f4a8178429f5"), "Test 2", new DateTime(2024, 3, 9, 10, 8, 38, 114, DateTimeKind.Local).AddTicks(5629), null, null, new DateTime(2024, 3, 9, 10, 8, 38, 114, DateTimeKind.Local).AddTicks(5627), null, null, null, null, "test_2@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, new DateTime(2024, 3, 9, 10, 8, 38, 114, DateTimeKind.Local).AddTicks(5630), null }
                });

            migrationBuilder.InsertData(
                table: "dbproject",
                columns: new[] { "Id", "CertificationBody", "CertificationExpirationDate", "ClientId", "CreatedAt", "DeletedAt", "HandledBy", "IdflCode", "IsAnotherCertification", "IsDeleted", "IsInitialCertification", "IsRenewalCertification", "IssueCertificated", "IssueCertificatedDate", "LicenseNo", "PayerId", "ProjectGeneralId", "StandardId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4686907d-f71a-406e-9867-22589f6fe251"), "certification 1", new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6784), new Guid("79c4f3cf-be88-4bcc-945d-cb9e16794852"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6786), null, null, "223487XC", true, false, true, false, false, new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6785), "12233XYUC", null, null, new Guid("f667feb2-c139-431f-8a00-de6aac0fa657"), "Verified", null },
                    { new Guid("7b254925-e86a-4abb-8e84-a131b290909b"), "certification 2", new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6789), new Guid("79c4f3cf-be88-4bcc-945d-cb9e16794852"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6792), null, null, "223TTT009", true, false, true, false, true, new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6791), "12233XYUC", null, null, new Guid("f667feb2-c139-431f-8a00-de6aac0fa657"), "Completed", null },
                    { new Guid("a023e5c1-a743-491f-afde-27400459793e"), "Test", new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6749), new Guid("79c4f3cf-be88-4bcc-945d-cb9e16794852"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6779), null, null, "223787XC", true, false, true, true, true, new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6779), "12233XYUC", null, null, new Guid("f667feb2-c139-431f-8a00-de6aac0fa657"), "Pending", null }
                });

            migrationBuilder.InsertData(
                table: "dbstandardquestion",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "Question", "StandardId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("8d1f1a7f-00a7-4660-b1df-ec6946e675e3"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6694), null, null, true, "OEKO-TEX STEP Environmental Performance Requirements | Yêu cầu về Hiệu suất Môi trường của Oeko - Tex Step", new Guid("f667feb2-c139-431f-8a00-de6aac0fa657"), null },
                    { new Guid("f0676c1f-06b5-4f74-b6d1-01758cf6b61a"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6697), null, null, true, "SCS Recycled Content Verification | Xác Minh Thành Phần Tái Chế SCS", new Guid("f667feb2-c139-431f-8a00-de6aac0fa657"), null },
                    { new Guid("f07675a8-4a5b-4151-84be-97ea1305ceec"), new DateTime(2024, 3, 9, 10, 8, 38, 116, DateTimeKind.Local).AddTicks(6688), null, null, true, "Are there any subcontractor facilities that trade / handle / process certified products in this scope of certification? If so, please indicate by noting in the List of Activities / Processes", new Guid("f667feb2-c139-431f-8a00-de6aac0fa657"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbbooking_CompletedBy",
                table: "dbbooking",
                column: "CompletedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_dbbooking_dbuser_CompletedBy",
                table: "dbbooking",
                column: "CompletedBy",
                principalTable: "dbuser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dbbooking_dbuser_CompletedBy",
                table: "dbbooking");

            migrationBuilder.DropIndex(
                name: "IX_dbbooking_CompletedBy",
                table: "dbbooking");

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("38db3857-2553-4899-9ff4-32b5e077ffa6"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("4686907d-f71a-406e-9867-22589f6fe251"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("7b254925-e86a-4abb-8e84-a131b290909b"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("a023e5c1-a743-491f-afde-27400459793e"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("1155761e-4468-4a7a-8d04-7d335e2bc001"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("3ac3e836-9759-4b1e-a6b2-6712178fd11f"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("6c4c8fe6-3370-4ef5-81b0-707219039140"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("6d06120a-9fd1-4c1d-b537-f7915bcba089"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("6dfaafb3-5037-40e6-8f36-240776bb36e4"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("73a346cf-d70f-4ade-93f3-671195318a70"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("8e50186b-b7e8-4eec-b908-75da62a429a3"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("b8c83c69-eab7-404a-8a1f-54e75f48b276"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("8d1f1a7f-00a7-4660-b1df-ec6946e675e3"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("f0676c1f-06b5-4f74-b6d1-01758cf6b61a"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("f07675a8-4a5b-4151-84be-97ea1305ceec"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("33864b03-e2a9-437a-8997-30e7e583af97"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("711d3fa6-e181-4fec-86fe-f4a8178429f5"));

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("79c4f3cf-be88-4bcc-945d-cb9e16794852"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("f667feb2-c139-431f-8a00-de6aac0fa657"));

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
                name: "IX_dbbooking_UserId",
                table: "dbbooking",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_dbbooking_dbuser_UserId",
                table: "dbbooking",
                column: "UserId",
                principalTable: "dbuser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
