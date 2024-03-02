using CleanSheet.Application.Messaging;

namespace CleanSheet.Application.Features.Users.Create;
public record CreateUserCommand(
    string Name,
    string Email,
    string Password) : ICommand<Guid>;