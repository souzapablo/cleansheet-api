using CleanSheet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanSheet.Infrastructure;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; private set; }
    public DbSet<Career> Careers { get; private set; }
    public DbSet<Team> Teams { get; private set; }
    public DbSet<Player> Players { get; private set; }
}
