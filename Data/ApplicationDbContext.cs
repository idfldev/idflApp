using Core.Models;
using idflApp.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace idflApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserModel> User { get; set; }
        public DbSet<ClientModel> Client { get; set; }
        public DbSet<StandardModel> Standard { get; set; }
        public DbSet<ProjectModel> ProjectModel { get; set; }
        public DbSet<ProjectStandardModel> ProjectStandard { get; set; }
        public DbSet<ProjectGeneralModel> ProjectGeneral { get; set; }
        public DbSet<BookModel> Book { get; set; }
        public DbSet<ProjectStandardCategoryModel> ProjectStandardCategory { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
        .EnableSensitiveDataLogging();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
             DataGenerator.Run(modelBuilder);
             RelationGenerator.Run(modelBuilder);
        }
    }
}