using Core.Models;
using idflApp.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace idflApp.Data
{
    public class RelationGenerator
    {
        public static void Run(ModelBuilder modelBuilder)
        {
            GenerateUserRelation(modelBuilder);
            GenerateClientRelation(modelBuilder);
            GenerateProjectRelation(modelBuilder);
            GenerateProjectGeneralRelation(modelBuilder);
            GenerateProjectStandardRelation(modelBuilder);
            GenerateBookingRelation(modelBuilder);
            GenerateStandardRelation(modelBuilder);
            GenerateStandardAnswerRelation(modelBuilder);
            GenerateStandardQuestionRelation(modelBuilder);
        }
        private static void GenerateUserRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.ToTable("dbuser");

            });
        }
        private static void GenerateClientRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientModel>(entity =>
            {
                entity.ToTable("dbclient");
            });
        }
        private static void GenerateStandardRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StandardModel>(entity =>
            {
                entity.ToTable("dbstandard");
            });
        }
        private static void GenerateProjectRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectModel>(entity =>
            {
                entity.ToTable("dbproject");
                entity.HasIndex(i => i.IdflCode).IsUnique();
                entity.HasOne(o => o.ClientModel)
                .WithMany(s => s.ProjectModels)
                .HasForeignKey(o => o.ClientId)
                .HasConstraintName("fk_project_client");
                entity.HasOne(o => o.StandardModel)
                 .WithMany(s => s.ProjectModels)
                 .HasForeignKey(o => o.StandardId)
                 .HasConstraintName("fk_project_standard");
                entity.HasOne(o => o.UserModel)
               .WithMany(s => s.ProjectModels)
               .HasForeignKey(o => o.HandledBy)
               .HasConstraintName("fk_project_user");
            });
        }
        private static void GenerateProjectGeneralRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectGeneralModel>(entity =>
            {
                entity.ToTable("dbprojectgeneral");
                entity.HasOne(o => o.ProjectModel)
                .WithOne(m => m.ProjectGeneralModel)
                .HasForeignKey<ProjectGeneralModel>(f => f.ProjectId)
                .HasConstraintName("fk_project_general_project");
            });
        }
        private static void GenerateProjectStandardRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectStandardModel>(entity =>
            {
                entity.ToTable("dbprojectstandard");
                entity.HasOne(o => o.ProjectModel)
                .WithMany(m => m.ProjectStandardModels)
                .HasForeignKey(f => f.ProjectId)
                .HasConstraintName("fk_project_standard_project");
                entity.HasOne(o => o.ProjectStandardCategory)
                .WithMany(m => m.ProjectStandardModels)
                .HasForeignKey(f => f.ProjectStandardCategoryId)
                .HasConstraintName("fk_project_standard_project_standard_category");
            });
        }

        private static void GenerateBookingRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookModel>(entity =>
            {
                entity.ToTable("dbbooking");
                entity.HasOne(o => o.ProjectModel)
                .WithOne(o => o.BookModel)
                .HasForeignKey<BookModel>(k => k.ProjectId);
                entity.HasOne(o => o.UserModel)
                .WithMany(s => s.BookModels)
                .HasForeignKey(f => f.UserId).OnDelete(DeleteBehavior.Cascade);
            });
        }
        private static void GenerateStandardAnswerRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StandardAnswerModel>(entity =>
            {
                entity.ToTable("dbstandardanswer");
                entity.HasOne(o => o.ProjectModel)
                .WithMany(s => s.StandardAnswerModels)
                .HasForeignKey(k => k.ProjectId)
                .HasConstraintName("fk_standard_answer_project");

            });
        }
        private static void GenerateStandardQuestionRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StandardQuestionModel>(entity =>
            {
                entity.ToTable("dbstandardquestion");
                entity.HasOne(o => o.StandardModel)
                .WithMany(m => m.StandardQuestionModels)
                .HasForeignKey(k => k.StandardId)
                .HasConstraintName("fk_standard_question_standard");
            });
        }

    }
}