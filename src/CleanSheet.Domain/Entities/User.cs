using CleanSheet.Domain.Primitives;

namespace CleanSheet.Domain.Entities;

public class User(Guid id, string email, string passwordHash) : Entity(id)
{
    private readonly List<Career> _careers = [];

    public string Email { get; private set; } = email;
    public string PasswordHash { get; private set; } = passwordHash;
    public IReadOnlyCollection<Career> Careers => _careers;
}
