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
                Name = "Test 1",
                Email = "test_1@gmail.com",
                Roles = Constants.Role.management,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                CreatedAt = DateTime.Now,
                IsActive = true,
                IsVerified = true,
            };
            var account_2 = new UserModel
            {
                Id = Guid.NewGuid(),
                Name = "Test 1",
                Email = "test_2@gmail.com",
                Roles = Constants.Role.staff,
                Password = Utils.HashPasswordUtils.EncryptCode("1234"),
                CreatedAt = DateTime.Now,
                IsActive = true,
                IsVerified = true,
            };
            modelBuilder
       .Entity<UserModel>()
       .HasData(new List<UserModel>
       {
              account_1, account_2
       });
        }
    }
}