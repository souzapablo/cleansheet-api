using CleanSheet.Domain.Enums;
using CleanSheet.Domain.Primities;

namespace CleanSheet.Domain.Entities;

public class Player(Guid id, string name, DateOnly birthday, int overall, int kitNumber, PlayerPosition playerPosition) : Entity(id)
{
    public string Name { get; private set; } = name;
    public DateOnly Birthday { get; private set; } = birthday;
    public int Overall { get; private set; } = overall;
    public int KitNumber { get; private set; } = kitNumber;
    public PlayerPosition PlayerPosition { get; private set; } = playerPosition;
    public Team Team { get; private set; } = null!;
    public Guid TeamId { get; private set; }
}
