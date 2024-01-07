using BilbiotekaMVCmodel.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BilbiotekaMVCmodel.Models;

namespace BilbiotekaMVCmodel.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    private class ApplicationUserEntityConfiguration :
        IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(255);
            builder.Property(x => x.LastName).HasMaxLength(255);
        }
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<User>()
            .HasOne(u => u.LibraryCard)
            .WithOne(lc => lc.User)
            .HasForeignKey<LibraryCard>(lc => lc.UserId); 
        
        // builder.Entity<BookLoan>()
        //     .HasKey(bl => new { bl.BookId, bl.UserId });
        // builder.Entity<BookLoan>()
        //     .HasOne(bl => bl.Book)
        //     .WithMany(b => b.BookLoans)
        //     .HasForeignKey(bl => bl.BookId)
        //     .OnDelete(DeleteBehavior.Cascade); // or DeleteBehavior.Restrict if you don't want automatic deletion
        //
        // builder.Entity<BookLoan>()
        //     .HasOne(bl => bl.User)
        //     .WithMany(u => u.BookLoans)
        //     .HasForeignKey(bl => bl.UserId)
        //     .OnDelete(DeleteBehavior.Cascade);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
    public DbSet<BilbiotekaMVCmodel.Models.Author>? Author { get; set; }
    public DbSet<BilbiotekaMVCmodel.Models.Book>? Book { get; set; }
    public DbSet<BilbiotekaMVCmodel.Models.BookLoan>? BookLoan { get; set; }
    public DbSet<BilbiotekaMVCmodel.Models.LibraryCard>? LibraryCard { get; set; }
    public DbSet<BilbiotekaMVCmodel.Models.User>? User { get; set; }
}
