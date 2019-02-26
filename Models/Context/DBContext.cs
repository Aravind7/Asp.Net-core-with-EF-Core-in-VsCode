using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using QuizApi.Models;
namespace QuizApi.Models
{
    public  class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblMstQuestions> TblMstQuestions { get; set; }
        public virtual DbSet<TblMstQuizCategory> TblMstQuizCategory { get; set; }

        // Unable to generate entity type for table 'dbo.tbl_mst_QuizOptions'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.100.8.148;Database=training;Trusted_Connection=False;User ID=training;password=training;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<TblMstQuestions>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("tbl_mst_Questions");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Questions).IsUnicode(false);
            });

            modelBuilder.Entity<TblMstQuizCategory>(entity =>
            {
                entity.HasKey(e => e.QuizId)
                    .HasName("PK_QuizId_tbl_mst_QuizCategory");

                entity.ToTable("tbl_mst_QuizCategory");

                entity.Property(e => e.QuizId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.QuizName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
        }
    }
}
