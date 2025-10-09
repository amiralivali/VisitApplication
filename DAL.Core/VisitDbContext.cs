using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Visit.DAL
{
    public partial class VisitDbContext : DbContext
    {
        //"data source=.;initial catalog=Visit;integrated security=True;encrypt=False;MultipleActiveResultSets=True;App=EntityFramework"
        public VisitDbContext()
            : base()
        {
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source =.; initial catalog = Visit24; integrated security = True; encrypt = False; MultipleActiveResultSets = True; App = EntityFramework");
        }
        public virtual DbSet<Bimar> Bimars { get; set; }
        public virtual DbSet<Chat> Chats { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Doctor_Takhasos> Doctor_Takhasoses { get; set; }
        public virtual DbSet<Takhasos> Takhasoses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            // Bimar
            modelBuilder.Entity<Bimar>()
                .Property(e => e.NationalCode)
                .HasMaxLength(10)              // EF Core: no IsFixedLength, use HasMaxLength
                .IsUnicode(false);

            modelBuilder.Entity<Bimar>()
                .HasMany(e => e.Visits)
                .WithOne(e => e.Bimar)         // WithRequired → WithOne + IsRequired
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Doctor
            modelBuilder.Entity<Doctor>()
                .Property(e => e.CodeNezamPezeshki)
                .HasMaxLength(10)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Doctor_Takhasoses)
                .WithOne(e => e.Doctor)        // FIX: missing in your EF6 snippet
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Visits)
                .WithOne(e => e.Doctor)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Takhasos
            modelBuilder.Entity<Takhasos>()
                .HasMany(e => e.Doctor_Takhasoses)
                .WithOne(e => e.Takhasos)
                .HasForeignKey(e => e.TakhasosID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // User
            modelBuilder.Entity<User>()
                .Property(e => e.MobileNumber)
                .HasMaxLength(11)
                .IsUnicode(false);

            // One-to-one: User ↔ Bimar
            modelBuilder.Entity<User>()
                .HasOne(u => u.Bimar)
                .WithOne(b => b.User)
                .HasForeignKey<Bimar>(u=>u.User)
                .IsRequired(false);            // HasOptional → IsRequired(false)

            // User ↔ Chats (FromID)
            modelBuilder.Entity<User>()
                .HasMany(u => u.Chats)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.FromID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // User ↔ Chats1 (ToID)
            modelBuilder.Entity<User>()
                .HasMany(u => u.Chats1)
                .WithOne(c => c.User1)
                .HasForeignKey(c => c.ToID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // One-to-one: User ↔ Doctor
            modelBuilder.Entity<User>()
                .HasOne(u => u.Doctor)
                .WithOne(d => d.User)
                .IsRequired(false);
        }

    }
}
