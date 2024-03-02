using CleanSheet.Application.Abstractions.Messaging;

namespace CleanSheet.Application.Features.Users.Create;
public record CreateUserCommand(
    string Email,
    string Password) : ICommand<Guid>;