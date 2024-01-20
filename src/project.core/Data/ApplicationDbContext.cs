using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using project.core.Models;

namespace project.core.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Seance> seances { get; set; }
    public DbSet<Room> rooms { get; set; }
    public DbSet<Movie> movies { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        ModelBuilderExtensions.Seed(builder);
    }

public DbSet<project.core.Models.Ticket> Ticket { get; set; } = default!;
}
