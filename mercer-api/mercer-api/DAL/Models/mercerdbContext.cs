using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace mercer_api.DAL.Models
{
    public partial class mercerdbContext : DbContext
    {
        public mercerdbContext()
        {
        }

        public mercerdbContext(DbContextOptions<mercerdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbilityScoreType> AbilityScoreType { get; set; }
        public virtual DbSet<Alignment> Alignment { get; set; }
        public virtual DbSet<Character> Character { get; set; }
        public virtual DbSet<CharacterRace> CharacterRace { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<SubClass> SubClass { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost,1433;Initial Catalog=mercerdb;Persist Security Info=False;User ID=sa;Password=mercerdb1;MultipleActiveResultSets=False;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbilityScoreType>(entity =>
            {
                entity.Property(e => e.AbilityScoreName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Alignment>(entity =>
            {
                entity.Property(e => e.AlignmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Character>(entity =>
            {
                entity.Property(e => e.CharacterHeight)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CharacterWeight)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PlayerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Alignment)
                    .WithMany(p => p.Character)
                    .HasForeignKey(d => d.AlignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Character__Align__6D0D32F4");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Character)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Character__Class__6E01572D");

                entity.HasOne(d => d.Race)
                    .WithMany(p => p.Character)
                    .HasForeignKey(d => d.RaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Character__RaceI__6EF57B66");

                entity.HasOne(d => d.SubClass)
                    .WithMany(p => p.Character)
                    .HasForeignKey(d => d.SubClassId)
                    .HasConstraintName("FK__Character__SubCl__6FE99F9F");
            });

            modelBuilder.Entity<CharacterRace>(entity =>
            {
                entity.Property(e => e.RaceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.ClassName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.HitDie)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubClass>(entity =>
            {
                entity.Property(e => e.SubClassName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.SubClass)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SubClass__ClassI__6A30C649");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
