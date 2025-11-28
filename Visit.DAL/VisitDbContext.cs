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
        public virtual DbSet<ExceptionLog>ExceptionLogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source=.;initial catalog=VisitAppDb;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Takhasos>().HasData(
                new Takhasos { ID = 1, Title = "چشم" },
                new Takhasos { ID = 2, Title = "مغز و اعصاب" },
                new Takhasos { ID = 3, Title = "قلب و عروق" },
                new Takhasos { ID = 4, Title = "گوش و حلق و بینی" },
                new Takhasos { ID = 5, Title = "اعصاب و روان" },
                new Takhasos { ID = 6, Title = "روانشناسی" },
                new Takhasos { ID = 7, Title = "اطفال" },
                new Takhasos { ID = 8, Title = "پوست و مو زیبایی" },
                new Takhasos { ID = 9, Title = "گوارش" },
                new Takhasos { ID = 10, Title = "ریه" },
                new Takhasos { ID = 11, Title = "کلیه" },
                new Takhasos { ID = 12, Title = "غدد" },
                new Takhasos { ID = 13, Title = "تغذیه" },
                new Takhasos { ID = 14, Title = "پزشک عمومی" },
                new Takhasos { ID = 15, Title = "مامایی" }
            );


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
                .HasMany(e => e.Chats)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.FromID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Chats1)
                .WithOne(e => e.User1)
                .HasForeignKey(e => e.ToID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Doctor>()
                .HasOne(d => d.User)
                .WithOne(u => u.Doctor)
                .HasForeignKey<Doctor>(d => d.DoctorID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Bimar>()
                .HasOne(b => b.User)
                .WithOne(u => u.Bimar)
                .HasForeignKey<Bimar>(b => b.BimarID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Doctor_Takhasos>()
                .HasOne(d => d.Doctor)
                .WithMany(t => t.Doctor_Takhasoses)
                .HasForeignKey(d => d.DoctorID)
                .OnDelete(DeleteBehavior.Cascade);


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
