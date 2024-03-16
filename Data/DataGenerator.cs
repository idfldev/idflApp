using idflApp.Constants;
using idflApp.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace idflApp.Data
{
    public class DataGenerator
    {
        public static void Run(ModelBuilder modelBuilder)
        {
            var department_cs = new DepartmentModel
            {
                Id = Guid.NewGuid(),
                DepartmentName = "CS department",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book",
                Status = true,
                CreatedAt = DateTime.Now,
            };
            var department_audit = new DepartmentModel
            {
                Id = Guid.NewGuid(),
                DepartmentName = "Audit department",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book",
                Status = true,
                CreatedAt = DateTime.Now,
            };
            modelBuilder
            .Entity<DepartmentModel>()
            .HasData(new List<DepartmentModel>
            {
                department_cs,   department_audit
            });
            var user_1 = new UserModel
            {
                Id = Guid.NewGuid(),
                DisplayName = "Tom Arrict",
                UserCode = "user001",
                UserRole = Constants.Role.management,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                CreatedAt = DateTime.Now,
                IsActive = true,
                IsVerified = true,
                Email = "john.doe@example.com",
                Status = true,
                DepartmentId = department_audit.Id
            };
            var user_2 = new UserModel
            {
                Id = Guid.NewGuid(),
                DisplayName = "Alice Smith",
                UserCode = "user002",
                UserRole = Constants.Role.management,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                CreatedAt = DateTime.Now,
                IsActive = true,
                IsVerified = true,
                Email = "alice.smith@example.com",
                Status = true,
                DepartmentId = department_audit.Id,
            };
            var user_3 = new UserModel
            {
                Id = Guid.NewGuid(),
                DisplayName = "Emily Johnson",
                UserCode = "user003",
                UserRole = Constants.Role.staff,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                CreatedAt = DateTime.Now,
                IsActive = true,
                IsVerified = true,
                Status = true,
                Email = "emily.johnson@example.com",
                DepartmentId = department_cs.Id,
            };
            var user_4 = new UserModel
            {
                Id = Guid.NewGuid(),
                DisplayName = "Michael Brown",
                UserCode = "user006",
                UserRole = Constants.Role.management,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                CreatedAt = DateTime.Now,
                IsActive = true,
                Email = "michael.brown@example.com",
                IsVerified = true,
                Status = true,
                DepartmentId = department_cs.Id,
            };
            modelBuilder
            .Entity<UserModel>()
            .HasData(new List<UserModel>
            {
                user_1, user_2, user_3, user_4
            });
            var account_info_1 = new UserInformationModel
            {
                Id = Guid.NewGuid(),
                City = "New York",
                Title = "Software Engineer",
                Address = "123 Main St",
                Phone = "123-456-7890",
                UserId = user_1.Id,
                Dob = new DateTime(1994, 5, 15)
            };
            var account_info_2 = new UserInformationModel
            {
                Id = Guid.NewGuid(),
                UserId = user_2.Id,
                City = "Los Angeles",
                Title = "Sales Manager",
                Address = "456 Oak St",
                Phone = "987-654-3210",
                Dob = new DateTime(1980, 8, 25)
            };
            var account_info_3 = new UserInformationModel
            {
                Id = Guid.NewGuid(),
                UserId = user_3.Id,
                City = "Chicago",
                Title = "HR Manager",
                Address = "789 Maple Ave",
                Phone = "111-222-3333",
                Dob = new DateTime(1975, 3, 10)
            };
            var account_info_4 = new UserInformationModel
            {
                Id = Guid.NewGuid(),
                UserId = user_4.Id,
                City = "San Francisco",
                Title = "IT Manager",
                Address = "1010 Pine St",
                Phone = "444-555-6666",
                Dob = new DateTime(1988, 11, 5),
                CreatedAt = DateTime.Now,
            };
            modelBuilder
           .Entity<UserInformationModel>()
           .HasData(new List<UserInformationModel>
           {
               account_info_1, account_info_2,account_info_3,account_info_4
           });
            // Client Models
            var clientModel1 = new ClientModel
            {
                Id = Guid.NewGuid(),
                DisplayName = "Client1 Company",
                ClientCode = 1001,
                ClientRole = ClientRole.owner,
                IsThirdParty = false,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                IsVerified = true,
                IsActive = true,
                Status = "Active",
                Email = "alice@example.com",
                CreatedAt = DateTime.Now,
            };

            var clientModel2 = new ClientModel
            {
                Id = Guid.NewGuid(),
                DisplayName = "Client2 Corporation",
                ClientCode = 1002,
                ClientRole = ClientRole.staff,
                IsThirdParty = false,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                IsVerified = true,
                IsActive = true,
                Status = "Active",
                Email = "bob@example.com",
                CreatedAt = DateTime.Now,
            };

            var clientModel3 = new ClientModel
            {
                Id = Guid.NewGuid(),
                DisplayName = "Client3 Enterprises",
                ClientCode = 1003,
                ClientRole = ClientRole.owner,
                IsThirdParty = false,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                IsVerified = true,
                IsActive = true,
                Status = "Active",
                Email = "emily@example.com",
                CreatedAt = DateTime.Now,
            };

            var clientModel4 = new ClientModel
            {
                Id = Guid.NewGuid(),
                DisplayName = "Client4 Ltd.",
                ClientCode = 1004,
                ClientRole = ClientRole.staff,
                IsThirdParty = false,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                IsVerified = true,
                IsActive = true,
                Email = "michael@example.com",
                Status = "Active"
            };

            var clientModel5 = new ClientModel
            {
                Id = Guid.NewGuid(),
                DisplayName = "Client5 Solutions",
                ClientCode = 1005,
                ClientRole = ClientRole.staff,
                IsThirdParty = false,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                IsVerified = true,
                IsActive = true,
                Status = "Active",
                Email = "sarah@example.com",
                CreatedAt = DateTime.Now,
            };
            modelBuilder
            .Entity<ClientModel>()
            .HasData(new List<ClientModel>
            {
                clientModel1,clientModel2,clientModel3,clientModel4,clientModel5,
            });
            // Client Information Models
            var clientInfo1 = new ClientInfomationModel
            {
                Id = Guid.NewGuid(),
                ClientId = clientModel1.Id,
                CompanyName = "Client1 Company",
                City = "New York",
                Country = "USA",
                ContactPerson = "Alice Smith",
                Title = "CEO",
                Address = "123 Main St",
                Phone = "123-456-7890",
                DeskPhone = "987-654-3210",
                Dob = new DateTime(1985, 5, 20),
                CreatedAt = DateTime.Now,
            };

            var clientInfo2 = new ClientInfomationModel
            {
                Id = Guid.NewGuid(),
                ClientId = clientModel2.Id,
                CompanyName = "Client2 Corporation",
                City = "Los Angeles",
                Country = "USA",
                ContactPerson = "Bob Johnson",
                Title = "Director",
                Address = "456 Oak St",
                Phone = "987-654-3210",
                DeskPhone = "123-456-7890",
                CreatedAt = DateTime.Now,
                Dob = new DateTime(1978, 8, 15),
            };

            var clientInfo3 = new ClientInfomationModel
            {
                Id = Guid.NewGuid(),
                ClientId = clientModel3.Id,
                CompanyName = "Client3 Enterprises",
                City = "Chicago",
                Country = "USA",
                ContactPerson = "Emily Davis",
                Title = "Manager",
                Address = "789 Maple Ave",
                Phone = "111-222-3333",
                DeskPhone = "444-555-6666",
                Dob = new DateTime(1982, 10, 5),
                CreatedAt = DateTime.Now,
            };

            var clientInfo4 = new ClientInfomationModel
            {
                Id = Guid.NewGuid(),
                ClientId = clientModel4.Id,
                CompanyName = "Client4 Ltd.",
                City = "Houston",
                Country = "USA",
                ContactPerson = "Michael Brown",
                Title = "CEO",
                Address = "1010 Pine St",
                Phone = "222-333-4444",
                DeskPhone = "555-666-7777",
                Dob = new DateTime(1975, 12, 10)
            };

            var clientInfo5 = new ClientInfomationModel
            {
                Id = Guid.NewGuid(),
                ClientId = clientModel5.Id,
                CompanyName = "Client5 Solutions",
                City = "San Francisco",
                Country = "USA",
                ContactPerson = "Sarah Adams",
                Title = "Director",
                Address = "789 Market St",
                Phone = "333-444-5555",
                DeskPhone = "666-777-8888",
                Dob = new DateTime(1988, 6, 25),
                CreatedAt = DateTime.Now,
            };

            modelBuilder
           .Entity<ClientInfomationModel>()
           .HasData(new List<ClientInfomationModel>
           {
               clientInfo1,clientInfo2,clientInfo3,clientInfo4,clientInfo5,
           });
            var ocs = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "OCS",
                Displayname = "Organic Content Standard",
                Description = "IDFL may not issue an OCS scope certificate to an organization which holds a GOTS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var gots = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "GOTS",
                Displayname = "Global Organic Textile Standard",
                Description = "IDFL may not issue a GOTS scope certificate to an organization which holds a OCS scope certificate with another certification body, unless the GOTS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var grs = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "GRS",
                Displayname = "Global Recycled Standard",
                Description = "IDFL may not issue a GRS scope certificate to an organization which holds a RCS scope certificate with another certification body, unless the RCS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var rcs = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "RCS",
                Displayname = "Recycled Claim Standard",
                Description = "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var rds = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "RDS",
                Displayname = "Responsible Down Standard",
                Description = "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var raf = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "RAF",
                Displayname = "Responsible Animal Fiber",
                Description = "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var rws = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "RWS",
                Displayname = "Tiêu Chuẩn Len Có Trách Nhiệm",
                Description = "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var rms = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "RMS",
                Displayname = "Tiêu Chuẩn Mohair Có Trách Nhiệm",
                Description = "IDFL may not issue an RCS scope certificate to an organization which holds a GRS scope certificate with another certification body, unless the GRS scope certificate is in the process of being transferred to IDFL.",
                CreatedAt = DateTime.Now,
                IsActive = true,
            };
            var ras = new StandardModel
            {
                Id = Guid.NewGuid(),
                StandardCode = "RAS",
                Displayname = "Tiêu Chuẩn Alpaca Có Trách Nhiệm",
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
            //var ocs_question_2 = new StandardQuestionModel
            //{
            //    Id = Guid.NewGuid(),
            //    Question = "OEKO-TEX STEP Environmental Performance Requirements | Yêu cầu về Hiệu suất Môi trường của Oeko - Tex Step",
            //    CreatedAt = DateTime.Now,
            //    StandardId = ocs.Id,
            //    IsActive = true,
            //};
            //var ocs_question_3 = new StandardQuestionModel
            //{
            //    Id = Guid.NewGuid(),
            //    Question = "SCS Recycled Content Verification | Xác Minh Thành Phần Tái Chế SCS",
            //    CreatedAt = DateTime.Now,
            //    StandardId = ocs.Id,
            //    IsActive = true,
            //};
            //modelBuilder
            //.Entity<StandardQuestionModel>()
            //.HasData(new List<StandardQuestionModel>
            // {
            //     ocs_question_1, ocs_question_2, ocs_question_3,
            // });
            // Project Model 1
            var projectModel1 = new ProjectModel
            {
                Id = Guid.NewGuid(),
                RefCode = "PROJ001",
                CertificationNumber = "CERT123",
                CertificationBody = "Certification Authority",
                Status = "Pending",
                ClientId = clientModel2.Id,
                StandardId = ocs.Id,
                IssueCertificatedDate = DateTime.Now,
                CertificationExpirationDate = DateTime.Now.AddYears(1),
                CreatedAt = DateTime.Now
            };

            // Project Model 2
            var projectModel2 = new ProjectModel
            {
                Id = Guid.NewGuid(),
                RefCode = "PROJ002",
                CertificationNumber = "CERT456",
                CertificationBody = "Certification Authority",
                Status = "Active",
                ClientId = clientModel1.Id,
                StandardId = ras.Id,
                IssueCertificatedDate = DateTime.Now,
                CertificationExpirationDate = DateTime.Now.AddYears(1),
                CreatedAt = DateTime.Now
            };

            // Project Model 3
            var projectModel3 = new ProjectModel
            {
                Id = Guid.NewGuid(),
                RefCode = "PROJ003",
                CertificationNumber = "CERT789",
                CertificationBody = "Certification Authority",
                Status = "Active",
                ClientId = clientModel1.Id,
                StandardId = gots.Id,
                IssueCertificatedDate = DateTime.Now,
                CertificationExpirationDate = DateTime.Now.AddYears(1),
                CreatedAt = DateTime.Now
            };

            // Project Model 4
            var projectModel4 = new ProjectModel
            {
                Id = Guid.NewGuid(),
                RefCode = "PROJ004",
                CertificationNumber = "CERT101",
                CertificationBody = "Certification Authority",
                Status = "Pending",
                ClientId = clientModel2.Id,
                StandardId = ocs.Id,
                IssueCertificatedDate = DateTime.Now,
                CertificationExpirationDate = DateTime.Now.AddYears(1),
                CreatedAt = DateTime.Now
            };
            modelBuilder
            .Entity<ProjectModel>()
            .HasData(new List<ProjectModel>
            {
                projectModel1,projectModel2,projectModel3,projectModel4
            });
            // Factory Model 1
            var factoryModel1 = new FactoryModel
            {
                Id = Guid.NewGuid(),
                ProjectId = projectModel1 .Id,
                UnitName = "Factory A",
                Address = "123 Industrial St",
                Ward = "Ward 1",
                District = "District A",
                City = "City X",
                Country = "Country Y",
                ZipCode = "12345",
                Occupancies = "Manufacturing",
                ActivitiesList = "Production, Assembly",
                IsCertificatePreviously = false
            };

            // Factory Model 2
            var factoryModel2 = new FactoryModel
            {
                Id = Guid.NewGuid(),
                UnitName = "Factory B",
                Address = "456 Commercial St",
                Ward = "Ward 2",
                District = "District B",
                City = "City Y",
                Country = "Country Z",
                ZipCode = "54321",
                Occupancies = "Processing",
                ActivitiesList = "Packaging, Sorting",
                IsCertificatePreviously = true,
                ProjectId = projectModel1.Id,
            };
            // Factory Model 3
            var factoryModel3 = new FactoryModel
            {
                Id = Guid.NewGuid(),
                UnitName = "Factory C",
                Address = "789 Business St",
                Ward = "Ward 3",
                District = "District C",
                City = "City Z",
                Country = "Country X",
                ZipCode = "67890",
                Occupancies = "Fabrication",
                ActivitiesList = "Cutting, Welding",
                IsCertificatePreviously = false,
                ProjectId = projectModel2.Id,

            };

            // Factory Model 4
            var factoryModel4 = new FactoryModel
            {
                Id = Guid.NewGuid(),
                UnitName = "Factory D",
                Address = "101 Residential St",
                Ward = "Ward 4",
                District = "District D",
                City = "City W",
                Country = "Country V",
                ZipCode = "98765",
                Occupancies = "Assembly",
                ActivitiesList = "Assembling, Testing",
                IsCertificatePreviously = true,
                ProjectId = projectModel3.Id,

            };

            // Factory Model 5
            var factoryModel5 = new FactoryModel
            {
                Id = Guid.NewGuid(),
                UnitName = "Factory E",
                Address = "111 Avenue St",
                Ward = "Ward 5",
                District = "District E",
                City = "City V",
                Country = "Country U",
                ZipCode = "13579",
                Occupancies = "Production",
                ActivitiesList = "Machining, Finishing",
                IsCertificatePreviously = false,
                ProjectId = projectModel1.Id,

            };
            modelBuilder
            .Entity<FactoryModel>()
            .HasData(new List<FactoryModel>
            {
                factoryModel1,factoryModel2,factoryModel3,factoryModel4,factoryModel5,
            });
        }
    }
}