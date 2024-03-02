namespace CleanSheet.Domain.Primitives;

public abstract class Entity(Guid id)
{
    public Guid Id { get; init; } = id;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public bool IsDeleted { get; private set; }

    public void Delete() =>
        IsDeleted = true;
}