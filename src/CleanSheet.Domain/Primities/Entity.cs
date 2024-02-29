namespace CleanSheet.Domain.Primities;

public abstract class Entity(Guid id)
{
    public Guid Id { get; } = id;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public bool IsDeleted { get; private set; }

    public void Delete() =>
        IsDeleted = true;
}