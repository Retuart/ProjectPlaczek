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

    public DbSet<Seance> Seances { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<OrderDetails> TicketOrders { get; set; }
    public DbSet<Order> Orders { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        ModelBuilderExtensions.Seed(builder);
    }

}
