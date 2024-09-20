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
        builder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
        });

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole { Id = "2", Name = "Staff", NormalizedName = "STAFF" }
            );

        var harsher = new PasswordHasher<IdentityUser>();
        builder.Entity<IdentityUser>().HasData(

            new IdentityUser
            {
                Id = "1",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@sapphiresports.com",
                NormalizedEmail = "ADMIN@SAPPHIRESPORTS.COM",
                EmailConfirmed = true,
                PasswordHash = harsher.HashPassword(null, "Admin123")
            },
            new IdentityUser
            {
                Id = "2",
                UserName = "Employee",
                NormalizedUserName = "EMPLOYEE",
                Email = "employee@example.com",
                NormalizedEmail = "EMPLOYEE@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = harsher.HashPassword(null, "Employee123")
            }

        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { RoleId = "1", UserId = "1" },
            new IdentityUserRole<string> { RoleId = "2", UserId = "2" }
        );

}

public DbSet<SapphireSports.Models.Payments> Payments { get; set; } = default!;

public DbSet<SapphireSports.Models.Cart> Cart { get; set; } = default!;

public DbSet<SapphireSports.Models.Order> Orders { get; set; } = default!;

public DbSet<SapphireSports.Models.Staff> Staff { get; set; } = default!;

public DbSet<SapphireSports.Models.Product> Product { get; set; } = default!;

public DbSet<SapphireSports.Models.Customer> Customer { get; set; } = default!;

public DbSet<SapphireSports.Models.Categories> Categories { get; set; } = default!;
}
