using System;
using Core.Models;
using idflApp.Constants;
using idflApp.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace idflApp.Data
{
    public class DataGenerator
    {
        public static void Run(ModelBuilder modelBuilder)
        {
            var account_1 = new UserModel
            {
                Id = Guid.NewGuid(),
                AccountName = "Pham Anh Doan",
                Title = "Developer",
                Email = "test_1@gmail.com",
                Phone = "123587777",
                Icon = "https://picsum.photos/24",
                Roles = Constants.Role.management,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                CreatedAt = DateTime.Now,
                IsActive = true,
                ActiveDateAt = DateTime.Now,
                IsVerified = true,
                VerifiedDateAt = DateTime.Now
            };
            var account_2 = new UserModel
            {
                Id = Guid.NewGuid(),
                AccountName = "Pham Anh Teo",
                Title = "Auditor",
                Email = "test_2@gmail.com",
                Phone = "123587777",
                Roles = Constants.Role.staff,
                Icon = "https://picsum.photos/24",
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                CreatedAt = DateTime.Now,
                IsActive = true,
                ActiveDateAt = DateTime.Now,
                IsVerified = true,
                VerifiedDateAt = DateTime.Now
            };
            var account_3 = new UserModel
            {
                Id = Guid.NewGuid(),
                AccountName = "Tran thanh sang",
                Title = "Auditor Supervisor",
                Email = "test_3@gmail.com",
                Phone = "123587777",
                Icon = "https://picsum.photos/24",
                Roles = Constants.Role.staff,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                CreatedAt = DateTime.Now,
                IsActive = true,
                ActiveDateAt = DateTime.Now,
                IsVerified = true,
                VerifiedDateAt = DateTime.Now
            };
            modelBuilder
            .Entity<UserModel>()
            .HasData(new List<UserModel>
            {
                    account_1, account_2,account_3
            });

            var client_1 = new ClientModel
            {
                Id = Guid.NewGuid(),
                AccountName = "client 1",
                AccountNumber = 128743,
                Email = "client_1@gmail.com",
                Phone = "0983373388",
                ContactPerson = "0982288888",
                FaxNumber = "10099922",
                CompanyName = "CTy TNHH MTV SCC",
                BusinessLicenseFile = "/uploads/docs/122BC4DD.pdf",
                TaxNumber = "12358799",
                Representator = "Client example",
                RepresentatorTitle = "Director Manager",
                IDCardNumber = "1235888570",
                IsThirdParty = false,
                Website = "scc.com",
                Address = "TPHCM",
                Ward = "5",
                District = "10",
                AccountRole = Constants.ClientRole.owner,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                CreatedAt = DateTime.Now,
                IsActive = true,
                ActiveAt = DateTime.Now,
                IsVerified = true,
                VerifiedAt = DateTime.Now
            };
            var client_2 = new ClientModel
            {
                Id = Guid.NewGuid(),
                AccountName = "client 2",
                AccountNumber = 123587,
                Email = "client_2@gmail.com",
                Phone = "0983373388",
                ContactPerson = "0982288888",
                FaxNumber = "10099922",
                CompanyName = "CTy TNHH MTV SCB",
                BusinessLicenseFile = "/uploads/docs/122BC4DD.pdf",
                TaxNumber = "12358799",
                Representator = "Client example",
                RepresentatorTitle = "Director Manager",
                IDCardNumber = "1235888570",
                IsThirdParty = true,
                Website = "scc.com",
                Address = "TPHCM",
                Ward = "5",
                District = "10",
                AccountRole = Constants.ClientRole.owner,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                CreatedAt = DateTime.Now,
                IsActive = true,
                ActiveAt = DateTime.Now,
                IsVerified = true,
                VerifiedAt = DateTime.Now
            };
            modelBuilder
            .Entity<ClientModel>()
            .HasData(new List<ClientModel>
            {
                    client_1, client_2
            });
            var ocs = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "OCS",
                Name = "Organic Content Standard",
                Description = "IDFL may not issue an OCS scope certificate to an organization which holds a GOTS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var gots = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "GOTS",
                Name = "Global Organic Textile Standard",
                Description = "IDFL may not issue a GOTS scope certificate to an organization which holds a OCS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var grs = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "GRS",
                Name = "Global Recycled Standard",
                Description = "IDFL may not issue a GRS scope certificate to an organization which holds a RCS scope certificate with another certification body, unless the RCS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var rcs = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "RCS",
                Name = "Recycled Claim Standard",
                Description = "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var rds = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "RDS",
                Name = "Responsible Down Standard",
                Description = "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var raf = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "RAF",
                Name = "Responsible Animal Fiber",
                Description = "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var rws = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "RWS",
                Name = "Tiêu Chuẩn Len Có Trách Nhiệm",
                Description = "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var rms = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "RMS",
                Name = "Tiêu Chuẩn Mohair Có Trách Nhiệm",
                Description = "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var ras = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "RAS",
                Name = "Tiêu Chuẩn Alpaca Có Trách Nhiệm",
                Description = "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            modelBuilder
            .Entity<StandardModel>()
            .HasData(new List<StandardModel>
             {
                 ocs, raf, rws, rms, ras,gots,grs, rcs, rds,
             });
            var ocs_question_1 = new StandardQuestionModel
            {
                Id = Guid.NewGuid(),
                Question = "Are there any subcontractor facilities that trade / handle / process certified products in this scope of certification? If so, please indicate by noting in the List of Activities / Processes",
                CreatedAt = DateTime.Now,
                StandardId = ocs.Id,
                IsActive = true,
            };
            var ocs_question_2 = new StandardQuestionModel
            {
                Id = Guid.NewGuid(),
                Question = "OEKO-TEX STEP Environmental Performance Requirements | Yêu cầu về Hiệu suất Môi trường của Oeko - Tex Step",
                CreatedAt = DateTime.Now,
                StandardId = ocs.Id,
                IsActive = true,
            };
            var ocs_question_3 = new StandardQuestionModel
            {
                Id = Guid.NewGuid(),
                Question = "SCS Recycled Content Verification | Xác Minh Thành Phần Tái Chế SCS",
                CreatedAt = DateTime.Now,
                StandardId = ocs.Id,
                IsActive = true,
            };
            modelBuilder
            .Entity<StandardQuestionModel>()
            .HasData(new List<StandardQuestionModel>
             {
                 ocs_question_1, ocs_question_2, ocs_question_3,
             });
            var project_1 = new ProjectModel
            {
                Id = Guid.NewGuid(),
                IdflCode = "223787XC",
                StandardId = ocs.Id,
                ClientId = client_1.Id,
                IsAnotherCertification = true,
                IsRenewalCertification = true,
                IsInitialCertification = true,
                LicenseNo = "12233XYUC",
                CertificationBody = "Test",
                Status = ProjectConstant.ProjectStatus.Pending.ToString(),
                IssueCertificated = false,
                CreatedAt = DateTime.Now

            };
            var project_2 = new ProjectModel
            {
                Id = Guid.NewGuid(),
                IdflCode = "223407XC",
                StandardId = ocs.Id,
                ClientId = client_1.Id,
                IsAnotherCertification = true,
                IsRenewalCertification = false,
                IsInitialCertification = true,
                LicenseNo = "12233XYUC",
                CertificationBody = "certification 1",
                CertificationExpirationDate = DateTime.Now,
                Status = ProjectConstant.ProjectStatus.Verified.ToString(),
                IssueCertificated = false,
                CreatedAt = DateTime.Now

            };
            var project_3 = new ProjectModel
            {
                Id = Guid.NewGuid(),
                IdflCode = "223TTT010",
                StandardId = ocs.Id,
                ClientId = client_1.Id,
                IsAnotherCertification = true,
                IsRenewalCertification = false,
                IsInitialCertification = true,
                LicenseNo = "12233XYUC",
                CertificationBody = "certification 2",
                CertificationExpirationDate = DateTime.Now,
                Status = ProjectConstant.ProjectStatus.Certificated.ToString(),
                IssueCertificated = true,
                IssueCertificatedDate = DateTime.Now,
                CreatedAt = DateTime.Now

            };
            var project_4 = new ProjectModel
            {
                Id = Guid.NewGuid(),
                IdflCode = "223TTT009",
                StandardId = ocs.Id,
                ClientId = client_1.Id,
                IsAnotherCertification = true,
                IsRenewalCertification = false,
                IsInitialCertification = true,
                LicenseNo = "12233XYUC",
                CertificationBody = "certification 3",
                Status = ProjectConstant.ProjectStatus.Approved.ToString(),
                IssueCertificated = false,
                CreatedAt = DateTime.Now

            };
            modelBuilder
            .Entity<ProjectModel>()
            .HasData(new List<ProjectModel>
            {
                project_1, project_2,project_3, project_4
            });
        }
    }
}