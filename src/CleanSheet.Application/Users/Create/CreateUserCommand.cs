using CleanSheet.Domain.Primities;
using MediatR;

namespace CleanSheet.Application.Users.Create;
public record CreateUserCommand(
    string Name,
    string Email,
    string Password) : IRequest<Result<Guid>>;