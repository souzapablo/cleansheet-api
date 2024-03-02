using CleanSheet.Domain.Primitives;

namespace CleanSheet.Application.Features.Users.Create;
public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, Guid>
{
    public Task<Result<Guid>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
