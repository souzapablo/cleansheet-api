using CleanSheet.Domain.Primities;

namespace CleanSheet.Domain.Entities;

public class Team(Guid id, string name, string stadium) : Entity(id)
{
    private readonly List<Player> _players = [];

    public string Name { get; private set; } = name;
    public string Stadium { get; private set; } = stadium;
    public Guid CareerId { get; private set; }
    public Career Career { get; private set; } = null!;
    public IReadOnlyCollection<Player> Players => _players;
}
