using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Visit.DAL
{
    public partial class VisitDbContext : DbContext
    {
        public virtual DbSet<Bimar> Bimars { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Doctor_Takhasos> Doctor_Takhasoses { get; set; }
        public virtual DbSet<Takhasos> Takhasoses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source=.;initial catalog=Visit;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Bimar>()
                .Property(e => e.NationalCode)
                .IsUnicode(false)
                .HasMaxLength(10); // Replace IsFixedLength with HasMaxLength

            modelBuilder.Entity<Bimar>()
                .HasMany(e => e.Visits)
                .WithOne(e => e.Bimar)
                .HasForeignKey(e => e.BimarID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.CodeNezamPezeshki)
                .IsUnicode(false)
                .HasMaxLength(10); // Replace IsFixedLength with HasMaxLength

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Doctor_Takhasoses)
                .WithOne(e => e.Doctor)
                .HasForeignKey(e => e.DoctorID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Visits)
                .WithOne(e => e.Doctor)
                .HasForeignKey(e => e.DoctorID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Takhasos>()
                .HasMany(e => e.Doctor_Takhasoses)
                .WithOne(e => e.Takhasos)
                .HasForeignKey(e => e.TakhasosID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .Property(e => e.MobileNumber)
                .IsUnicode(false)
                .HasMaxLength(11); // Replace IsFixedLength with HasMaxLength


            modelBuilder.Entity<User>()
                .HasOne(e => e.Bimar)
                .WithOne(e => e.User)
                .HasForeignKey<Bimar>(e => e.User.ID); // Explicit FK required

            modelBuilder.Entity<User>()
                .HasMany(e => e.Chats)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.FromID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Chats1)
                .WithOne(e => e.User1)
                .HasForeignKey(e => e.ToID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(e => e.Doctor)
                .WithOne(e => e.User)
                .HasForeignKey<Doctor>(e => e.User.ID); // Explicit FK required

        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Bimar>()
        //        .Property(e => e.NationalCode)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Bimar>()
        //        .HasMany(e => e.Visits)
        //        .WithRequired(e => e.Bimar)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Doctor>()
        //        .Property(e => e.CodeNezamPezeshki)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Doctor>()
        //        .HasMany(e => e.Doctor_Takhasoses)
        //        .WithRequired(e => e.Doctor)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Doctor>()
        //        .HasMany(e => e.Visits)
        //        .WithRequired(e => e.Doctor)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Takhasos>()
        //        .HasMany(e => e.Doctor_Takhasoses)
        //        .WithRequired(e => e.Takhasos)
        //        .HasForeignKey(e => e.TakhasosID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<User>()
        //        .Property(e => e.MobileNumber)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<User>()
        //        .Property(e => e.Email)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<User>()
        //        .HasOptional(e => e.Bimar)
        //        .WithRequired(e => e.User);

        //    modelBuilder.Entity<User>()
        //        .HasMany(e => e.Chats)
        //        .WithRequired(e => e.User)
        //        .HasForeignKey(e => e.FromID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<User>()
        //        .HasMany(e => e.Chats1)
        //        .WithRequired(e => e.User1)
        //        .HasForeignKey(e => e.ToID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<User>()
        //        .HasOptional(e => e.Doctor)
        //        .WithRequired(e => e.User);
        //}
    }
}
