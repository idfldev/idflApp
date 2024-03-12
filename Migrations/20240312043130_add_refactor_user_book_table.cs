using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace idflApp.Migrations
{
    /// <inheritdoc />
    public partial class add_refactor_user_book_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "StartedAt",
                table: "dbbooking",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Purpose",
                table: "dbbooking",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "EndedAt",
                table: "dbbooking",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "CompletedAt",
                table: "dbbooking",
                newName: "CompletedDate");

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

            migrationBuilder.AddColumn<string>(
                name: "BgColor",
                table: "dbbooking",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Occupancy",
                table: "dbbooking",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "dbbooking",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Icon",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "dbuser");

            migrationBuilder.DropColumn(
                name: "BgColor",
                table: "dbbooking");

            migrationBuilder.DropColumn(
                name: "Occupancy",
                table: "dbbooking");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "dbbooking");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "dbbooking",
                newName: "Purpose");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "dbbooking",
                newName: "StartedAt");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "dbbooking",
                newName: "EndedAt");

            migrationBuilder.RenameColumn(
                name: "CompletedDate",
                table: "dbbooking",
                newName: "CompletedAt");

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
    }
}
