using CleanSheet.Domain.Entities;
using CleanSheet.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CleanSheet.Infrastructure.Repositories;
public class UserRepository(ApplicationDbContext context) : IUserRepository
{
    private readonly ApplicationDbContext _context = context;

    public void Add(User user) =>
        _context.Users
        .Add(user);

    public Task<bool> IsEmailRegisteredAsync(string email, CancellationToken cancellationToken) =>
        _context.Users
        .AnyAsync(u => u.Email == email, cancellationToken);
}
