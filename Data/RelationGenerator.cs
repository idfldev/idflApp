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
            GenerateBookingRelation(modelBuilder);
            GenerateStandardRelation(modelBuilder);
            GenerateBookUserRelation(modelBuilder);
            GenerateFactoryRelation(modelBuilder);
            GenerateBookCompletedRelation(modelBuilder);
            GenerateAccountVerifyRelation(modelBuilder);
            GenerateUserInformationRelation(modelBuilder);
            GenerateClientInformationRelation(modelBuilder);
        }
        private static void GenerateUserRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.ToTable("dbuser");
                entity.HasOne(o=>o.DepartmentModel).WithMany(w=>w.UserModels).HasForeignKey(o=>o.DepartmentId); 

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
                entity.HasIndex(i => i.RefCode).IsUnique();
                //project-client
                entity.HasOne(o => o.ClientModel)
                .WithMany(s => s.ProjectModels)
                .HasForeignKey(o => o.ClientId);
                //project-standard
                entity.HasOne(o => o.StandardModel)
                .WithMany(s => s.ProjectModels)
                .HasForeignKey(o => o.StandardId);
                //project-user
                entity.HasOne(o => o.UserModel)
                .WithMany(s => s.ProjectModels)
                .HasForeignKey(o => o.UserId);
            });
        }
        //private static void GenerateProjectGeneralRelation(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProjectGeneralModel>(entity =>
        //    {
        //        entity.ToTable("dbprojectgeneral");
        //        entity.HasOne(o => o.ProjectModel)
        //        .WithOne(m => m.ProjectGeneralModel)
        //        .HasForeignKey<ProjectGeneralModel>(f => f.ProjectId)
        //        .HasConstraintName("fk_project_general_project");
        //    });
        //}
        //private static void GenerateProjectStandardRelation(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ProjectStandardModel>(entity =>
        //    {
        //        entity.ToTable("dbprojectstandard");
        //        entity.HasOne(o => o.ProjectModel)
        //        .WithMany(m => m.ProjectStandardModels)
        //        .HasForeignKey(f => f.ProjectId)
        //        .HasConstraintName("fk_project_standard_project");
        //        entity.HasOne(o => o.ProjectStandardCategory)
        //        .WithMany(m => m.ProjectStandardModels)
        //        .HasForeignKey(f => f.ProjectStandardCategoryId)
        //        .HasConstraintName("fk_project_standard_project_standard_category");
        //    });
        //}

        private static void GenerateBookingRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookModel>(entity =>
            {
                entity.ToTable("dbbooking");
                entity.HasOne(o => o.FactoryModel)
                .WithMany(o => o.BookModels).HasForeignKey(k => k.FactoryId);
                entity.HasOne(o => o.FactoryModel);
            });
        }
        private static void GenerateFactoryRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FactoryModel>(entity =>
            {
                entity.ToTable("dbfactory");
                entity.HasOne(o => o.ProjectModel)
                .WithMany(o => o.FactoryModels).HasForeignKey(k => k.ProjectId);
            });
        }
        //private static void GenerateStandardAnswerRelation(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<StandardAnswerModel>(entity =>
        //    {
        //        entity.ToTable("dbstandardanswer");
        //        entity.HasOne(o => o.ProjectModel)
        //        .WithMany(s => s.StandardAnswerModels)
        //        .HasForeignKey(k => k.ProjectId)
        //        .HasConstraintName("fk_standard_answer_project");

        //    });
        //}
        //private static void GenerateStandardQuestionRelation(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<StandardQuestionModel>(entity =>
        //    {
        //        entity.ToTable("dbstandardquestion");
        //        entity.HasOne(o => o.StandardModel)
        //        .WithMany(m => m.StandardQuestionModels)
        //        .HasForeignKey(k => k.StandardId)
        //        .HasConstraintName("fk_standard_question_standard");
        //    });
        //}
        private static void GenerateBookUserRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookUserModel>(entity =>
            {
                entity.ToTable("dbbookuser");
                entity.HasOne(o => o.UserModel)
                .WithMany(f => f.BookUserModels)
                .HasConstraintName("fk_book_user_table_user")
                .HasForeignKey(k => k.AuditorId);
                entity.HasOne(o => o.BookModel)
                .WithMany(f => f.BookUserModels)
                .HasConstraintName("fk_book_user_table_book")
                .HasForeignKey(k => k.BookId);
            });
        }
        public static void GenerateBookCompletedRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCompleteModel>(entity =>
            {
                entity.ToTable("dbbookcomplete");
                entity.HasOne(o => o.BookModel).WithMany(w => w.BookCompleteModels);
                entity.HasOne(o => o.UserModel).WithMany(w => w.BookCompleteModels);
            });
        }

        public static void GenerateAccountVerifyRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountVerifyModel>(entity =>
            {
                entity.ToTable("dbaccountverify");
                entity.HasOne(o => o.UserModel).WithMany(w => w.AccountVerifyModels);
                entity.HasOne(o => o.ClientModel).WithMany(w => w.AccountVerifyModels);
            });
        }

        public static void GenerateUserInformationRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInformationModel>(entity =>
            {
                entity.ToTable("dbuserinformation");
                entity.HasOne(o => o.UserModel).WithMany(o => o.UserInformationModels);
            });
        }

        public static void GenerateClientInformationRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientInfomationModel>(entity =>
            {
                entity.ToTable("dbclientinformation");
                entity.HasOne(o => o.ClientModel).WithMany(o => o.ClientInfomationModels);
            });
        }
        public static void GenerateDepartmentRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentModel>(entity =>
            {
                entity.ToTable("dbdepartment");
            });
        }
    }
}