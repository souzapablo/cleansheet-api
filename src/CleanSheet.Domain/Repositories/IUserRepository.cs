using CleanSheet.Domain.Entities;

namespace CleanSheet.Domain.Repositories;
public interface IUserRepository
{
    void Add(User user);
    Task<bool> IsEmailRegisteredAsync(string email, CancellationToken cancellationToken = default);
}
