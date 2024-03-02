using CleanSheet.Domain.Primitives;

namespace CleanSheet.Domain.Entities;

public class Career(Guid id, string manager) : Entity(id)
{
    private readonly List<Team> _teams = [];
    public string Manager { get; private set; } = manager;
    public IReadOnlyCollection<Team> Teams => _teams;
    public Guid UserId { get; private set; }
    public User User { get; private set; } = null!;
}
