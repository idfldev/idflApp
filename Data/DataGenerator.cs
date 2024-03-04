using System;
using Core.Models;
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
                AccountName = "Test 1",
                Email = "test_1@gmail.com",
                Phone = "123587777",
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
                AccountName = "Test 1",
                Email = "test_2@gmail.com",
                Phone = "123587777",
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
                    account_1, account_2
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
        }
    }
}