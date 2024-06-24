using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SapphireSports.Models;

namespace SapphireSports.Areas.Identity.Data;

public class SapphireSportsContext : IdentityDbContext<IdentityUser>
{
    public SapphireSportsContext(DbContextOptions<SapphireSportsContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<SapphireSports.Models.Payments> Payments { get; set; } = default!;

public DbSet<SapphireSports.Models.Cart> Cart { get; set; } = default!;

public DbSet<SapphireSports.Models.Order> Orders { get; set; } = default!;

public DbSet<SapphireSports.Models.Staff> Staff { get; set; } = default!;

public DbSet<SapphireSports.Models.Product> Product { get; set; } = default!;

public DbSet<SapphireSports.Models.Customer> Customer { get; set; } = default!;

public DbSet<SapphireSports.Models.Categories> Categories { get; set; } = default!;
}
