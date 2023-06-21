using GlenEdenTakeaways.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GlenEdenTakeaways.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GlenEdenTakeaways.Areas.Identity.Data;

public class IdentityContext : IdentityDbContext<GlenEdenTakeawaysUser>
{
    public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
    {
    }

    //create generic constructor to inheritance to point to base options. 
    protected IdentityContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }

    public DbSet<GlenEdenTakeaways.Models.Customer> Customer { get; set; } = default!;

    public DbSet<GlenEdenTakeaways.Models.Employee> Employee { get; set; } = default!;

    public DbSet<GlenEdenTakeaways.Models.Order> Order { get; set; } = default!;

    public DbSet<GlenEdenTakeaways.Models.Payment> Payment { get; set; } = default!;

    public DbSet<GlenEdenTakeaways.Models.PaymentType> PaymentType { get; set; } = default!;
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<GlenEdenTakeawaysUser>
{
    public void Configure(EntityTypeBuilder<GlenEdenTakeawaysUser> builder)
    {
       builder.Property(u => u.FirstName) .HasMaxLength(255);
        builder.Property(u => u.LastName) .HasMaxLength(255);
    }
}