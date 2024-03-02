using CleanSheet.Domain.Enums;
using CleanSheet.Domain.Primitives;

namespace CleanSheet.Domain.Entities;

public class Player(
    Guid id, 
    string name, 
    DateTime birthday, 
    int overall, 
    int kitNumber, 
    PlayerPosition position, 
    PlayerRole role) : Entity(id)
{
    public string Name { get; private set; } = name;
    public DateTime Birthday { get; private set; } = birthday;
    public int Overall { get; private set; } = overall;
    public int KitNumber { get; private set; } = kitNumber;
    public PlayerPosition Position { get; private set; } = position;
    public PlayerRole Role { get; private set; } = role;
    public Team Team { get; private set; } = null!;
    public Guid TeamId { get; private set; }
}
