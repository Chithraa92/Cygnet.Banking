using Microsoft.EntityFrameworkCore;
using Cygnet.Banking.Domain.Aggregates;

namespace Cygnet.Banking.Domain.EntityFramework
{
    public partial class BankingContext : DbContext
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BankingContext"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="DbContextOptions{EventScheduleContext}"/>.</param>
        public BankingContext(DbContextOptions<BankingContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the Customer.
        /// </summary>
        public DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Beneficiary> Beneficiary { get; set; }
        public DbSet<Ifsc> Ifsc { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }
        public DbSet<AccountType> AccountType { get; set; }
       

        ///// <summary>
        ///// The OnConfiguring.
        ///// </summary>
        ///// <param name="optionsBuilder">The optionsBuilder<see cref="DbContextOptionsBuilder"/>.</param>
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //}

        ///// <summary>
        ///// The OnModelCreating.
        ///// </summary>
        ///// <param name="modelBuilder">The modelBuilder<see cref="ModelBuilder"/>.</param>
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
           
        //    //modelBuilder.Entity<TenantAddress>(entity =>
        //    //{
        //    //    entity.Property(e => e.City).HasMaxLength(100);

        //    //    entity.Property(e => e.ContactEmail).HasMaxLength(200);

        //    //    entity.Property(e => e.Country)
        //    //        .HasMaxLength(100)
        //    //        .IsUnicode(false);

        //    //    entity.Property(e => e.CountryCode)
        //    //        .HasMaxLength(100)
        //    //        .IsUnicode(false);

        //    //    entity.Property(e => e.LogoUrl)
        //    //        .HasMaxLength(1024)
        //    //        .IsUnicode(false);

        //    //    entity.Property(e => e.MobilePhoneNumber)
        //    //        .HasMaxLength(100)
        //    //        .IsUnicode(false);

        //    //    entity.Property(e => e.OfficeAddress).HasMaxLength(200);

        //    //    entity.Property(e => e.OfficePhoneNumber)
        //    //        .HasMaxLength(100)
        //    //        .IsUnicode(false);

        //    //    entity.Property(e => e.State).HasMaxLength(100);

        //    //    entity.Property(e => e.TollFreePhoneNumber)
        //    //        .HasMaxLength(100)
        //    //        .IsUnicode(false);

        //    //    entity.Property(e => e.Website)
        //    //        .HasMaxLength(100)
        //    //        .IsUnicode(false);

        //    //    entity.Property(e => e.ZipCode).HasMaxLength(40);

        //    //    entity.HasOne(d => d.Tenant)
        //    //        .WithMany(p => p.TenantAddress)
        //    //        .HasForeignKey(d => d.TenantId)
        //    //        .OnDelete(DeleteBehavior.ClientSetNull)
        //    //        .HasConstraintName("FK__TenantAdd__Tenan__2B0A656D");
        //    //});

        //    OnModelCreatingPartial(modelBuilder);
        //}

        ///// <summary>
        ///// The OnModelCreatingPartial.
        ///// </summary>
        ///// <param name="modelBuilder">The modelBuilder<see cref="ModelBuilder"/>.</param>
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}