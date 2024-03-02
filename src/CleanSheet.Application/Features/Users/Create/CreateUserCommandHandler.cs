using CleanSheet.Application.Abstractions.Messaging;
using CleanSheet.Domain.Entities;
using CleanSheet.Domain.Errors;
using CleanSheet.Domain.Primitives;
using CleanSheet.Domain.Repositories;

namespace CleanSheet.Application.Features.Users.Create;
using BCrypt.Net;

public class CreateUserCommandHandler(
    IUserRepository userRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<CreateUserCommand, Guid>
{
    private readonly IUserRepository _userRepository = userRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result<Guid>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var isEmailRegistered = await _userRepository.IsEmailRegisteredAsync(request.Email, cancellationToken);

        if (isEmailRegistered) 
            return Result.Failure<Guid>(UserErrors.EmailUnavailable);

        var passwordHash = BCrypt.HashPassword(request.Password);

        var user = new User(Guid.NewGuid(), request.Email, passwordHash);

        _userRepository.Add(user);

        await _unitOfWork.CommitAsync(cancellationToken);

        return user.Id;
    }
}
