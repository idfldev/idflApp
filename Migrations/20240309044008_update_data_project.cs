using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflApp.Migrations
{
    /// <inheritdoc />
    public partial class update_data_project : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("9535eb31-2ece-4404-bab7-e00d689c4040"), "client 1", 128743, 0, new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(862), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCC", "0982288888", new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(862), null, "10", null, "client_1@gmail.com", "10099922", "1235888570", true, false, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(863), "5", "scc.com" },
                    { new Guid("e866cbe3-8f78-45d6-af23-113e13f2fb7c"), "client 2", 123587, 0, new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7777), "TPHCM", "/uploads/docs/122BC4DD.pdf", null, "CTy TNHH MTV SCB", "0982288888", new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7776), null, "10", null, "client_2@gmail.com", "10099922", "1235888570", true, false, true, true, "m9fUsQskgQAZZPVNkXc3ag==", "0983373388", "Client example", "Director Manager", "12358799", null, new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7777), "5", "scc.com" }
                });

            migrationBuilder.InsertData(
                table: "dbstandard",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "StandardCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0434ef6e-cedf-4077-8c10-2451d28f08e4"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7814), null, "IDFL may not issue a GOTS scope certificate to an organization which holds a OCS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Organic Textile Standard", "GOTS", null },
                    { new Guid("3c8d8f29-0b80-4b45-a844-3a5899bfbbd3"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7822), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Len Có Trách Nhiệm", "RWS", null },
                    { new Guid("4317d086-f8b4-402f-85c7-d9a49e0f5b17"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7816), null, "IDFL may not issue a GRS scope certificate to an organization which holds a RCS scope certificate with another certification body, unless the RCS scope certificate is in the process of being transferred to IDFL.", true, false, "Global Recycled Standard", "GRS", null },
                    { new Guid("4f9815d8-d21e-4369-8f2a-5635f133d828"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7825), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Alpaca Có Trách Nhiệm", "RAS", null },
                    { new Guid("91d1709f-7106-4ef1-8b17-66c0848e22e6"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7823), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Tiêu Chuẩn Mohair Có Trách Nhiệm", "RMS", null },
                    { new Guid("92ea68b9-b837-4956-8957-9df4ea0c03d2"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7804), null, "IDFL may not issue an OCS scope certificate to an organization which holds a GOTS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.", true, false, "Organic Content Standard", "OCS", null },
                    { new Guid("d35e7b38-5327-4da4-8a54-4a954e27d159"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7819), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Down Standard", "RDS", null },
                    { new Guid("e7b8d7c9-45f8-4086-b7b1-2413fb821aa6"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7821), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Responsible Animal Fiber", "RAF", null },
                    { new Guid("fbdd90f8-335c-4865-92eb-30b4ce69b306"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7818), null, "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.", true, false, "Recycled Claim Standard", "RCS", null }
                });

            migrationBuilder.InsertData(
                table: "dbuser",
                columns: new[] { "Id", "AccountName", "ActiveDateAt", "Address", "City", "CreatedAt", "DeletedAt", "DeletedDateAt", "District", "Dob", "Email", "IsActive", "IsDeleted", "IsVerified", "Password", "Phone", "Roles", "UpdatedAt", "VerifiedDateAt", "Ward" },
                values: new object[,]
                {
                    { new Guid("178d0204-e0d3-499f-8b3c-1d0a9f9331b1"), "Test 2", new DateTime(2024, 3, 9, 11, 40, 8, 284, DateTimeKind.Local).AddTicks(3899), null, null, new DateTime(2024, 3, 9, 11, 40, 8, 284, DateTimeKind.Local).AddTicks(3899), null, null, null, null, "test_2@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 1, null, new DateTime(2024, 3, 9, 11, 40, 8, 284, DateTimeKind.Local).AddTicks(3900), null },
                    { new Guid("c9e5355c-d8b5-404f-8f75-3816830a3387"), "Test 1", new DateTime(2024, 3, 9, 11, 40, 8, 283, DateTimeKind.Local).AddTicks(6992), null, null, new DateTime(2024, 3, 9, 11, 40, 8, 283, DateTimeKind.Local).AddTicks(6979), null, null, null, null, "test_1@gmail.com", true, false, true, "m9fUsQskgQAZZPVNkXc3ag==", "123587777", 0, null, new DateTime(2024, 3, 9, 11, 40, 8, 283, DateTimeKind.Local).AddTicks(6993), null }
                });

            migrationBuilder.InsertData(
                table: "dbproject",
                columns: new[] { "Id", "CertificationBody", "CertificationExpirationDate", "ClientId", "CreatedAt", "DeletedAt", "HandledBy", "IdflCode", "IsAnotherCertification", "IsDeleted", "IsInitialCertification", "IsRenewalCertification", "IssueCertificated", "IssueCertificatedDate", "LicenseNo", "PayerId", "ProjectGeneralId", "StandardId", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("12a83536-5327-4392-bd1e-9fceb0a6a2f2"), "certification 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9535eb31-2ece-4404-bab7-e00d689c4040"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7892), null, null, "223TTT009", true, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12233XYUC", null, null, new Guid("92ea68b9-b837-4956-8957-9df4ea0c03d2"), "Approved", null },
                    { new Guid("5a321af0-7f06-4b1b-98bd-b7efb5622060"), "Test", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9535eb31-2ece-4404-bab7-e00d689c4040"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7882), null, null, "223787XC", true, false, true, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12233XYUC", null, null, new Guid("92ea68b9-b837-4956-8957-9df4ea0c03d2"), "Pending", null },
                    { new Guid("619b9d7b-77ec-4817-aad5-8cdd06d52c15"), "certification 1", new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7884), new Guid("9535eb31-2ece-4404-bab7-e00d689c4040"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7885), null, null, "223407XC", true, false, true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12233XYUC", null, null, new Guid("92ea68b9-b837-4956-8957-9df4ea0c03d2"), "Verified", null },
                    { new Guid("70d58ae3-96fc-4a2b-9bea-4a7ce74c92d5"), "certification 2", new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7888), new Guid("9535eb31-2ece-4404-bab7-e00d689c4040"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7889), null, null, "223TTT010", true, false, true, false, true, new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7889), "12233XYUC", null, null, new Guid("92ea68b9-b837-4956-8957-9df4ea0c03d2"), "Certificated", null }
                });

            migrationBuilder.InsertData(
                table: "dbstandardquestion",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "Question", "StandardId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("096105bf-6598-48ee-932e-2c00f05ea7b0"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7852), null, null, true, "SCS Recycled Content Verification | Xác Minh Thành Phần Tái Chế SCS", new Guid("92ea68b9-b837-4956-8957-9df4ea0c03d2"), null },
                    { new Guid("828f184b-4512-4429-96fc-ae0cabaf9ec1"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7851), null, null, true, "OEKO-TEX STEP Environmental Performance Requirements | Yêu cầu về Hiệu suất Môi trường của Oeko - Tex Step", new Guid("92ea68b9-b837-4956-8957-9df4ea0c03d2"), null },
                    { new Guid("89dfb31c-92b4-48e8-a712-fcd3771c02f5"), new DateTime(2024, 3, 9, 11, 40, 8, 285, DateTimeKind.Local).AddTicks(7847), null, null, true, "Are there any subcontractor facilities that trade / handle / process certified products in this scope of certification? If so, please indicate by noting in the List of Activities / Processes", new Guid("92ea68b9-b837-4956-8957-9df4ea0c03d2"), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("e866cbe3-8f78-45d6-af23-113e13f2fb7c"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("12a83536-5327-4392-bd1e-9fceb0a6a2f2"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("5a321af0-7f06-4b1b-98bd-b7efb5622060"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("619b9d7b-77ec-4817-aad5-8cdd06d52c15"));

            migrationBuilder.DeleteData(
                table: "dbproject",
                keyColumn: "Id",
                keyValue: new Guid("70d58ae3-96fc-4a2b-9bea-4a7ce74c92d5"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("0434ef6e-cedf-4077-8c10-2451d28f08e4"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("3c8d8f29-0b80-4b45-a844-3a5899bfbbd3"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("4317d086-f8b4-402f-85c7-d9a49e0f5b17"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("4f9815d8-d21e-4369-8f2a-5635f133d828"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("91d1709f-7106-4ef1-8b17-66c0848e22e6"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("d35e7b38-5327-4da4-8a54-4a954e27d159"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("e7b8d7c9-45f8-4086-b7b1-2413fb821aa6"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("fbdd90f8-335c-4865-92eb-30b4ce69b306"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("096105bf-6598-48ee-932e-2c00f05ea7b0"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("828f184b-4512-4429-96fc-ae0cabaf9ec1"));

            migrationBuilder.DeleteData(
                table: "dbstandardquestion",
                keyColumn: "Id",
                keyValue: new Guid("89dfb31c-92b4-48e8-a712-fcd3771c02f5"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("178d0204-e0d3-499f-8b3c-1d0a9f9331b1"));

            migrationBuilder.DeleteData(
                table: "dbuser",
                keyColumn: "Id",
                keyValue: new Guid("c9e5355c-d8b5-404f-8f75-3816830a3387"));

            migrationBuilder.DeleteData(
                table: "dbclient",
                keyColumn: "Id",
                keyValue: new Guid("9535eb31-2ece-4404-bab7-e00d689c4040"));

            migrationBuilder.DeleteData(
                table: "dbstandard",
                keyColumn: "Id",
                keyValue: new Guid("92ea68b9-b837-4956-8957-9df4ea0c03d2"));

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
        }
    }
}
