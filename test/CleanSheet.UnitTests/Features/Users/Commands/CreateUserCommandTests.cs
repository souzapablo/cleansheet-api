using CleanSheet.Application.Features.Users.Create;

namespace CleanSheet.UnitTests.Features.Users.Commands;
public class CreateUserCommandTests
{
    private static readonly IUserRepository _userRepository = Substitute.For<IUserRepository>();
    private static readonly IUnitOfWork _unitOfWork = Substitute.For<IUnitOfWork>();

    [Fact]
    [DisplayName("CreateUserCommand should create a new user when e-mail is available")]
    public async Task CreateUserCommand_Should_CreateANewUser_When_EmailIsAvailabe()
    {
        // Arrange
        var command = new CreateUserCommand("jhondoe@email.com", "JhonDoePass");

        _userRepository.IsEmailRegisteredAsync(Arg.Any<string>())
            .Returns(false);


        // Act
        var result = await CommandHandler
            .Handle(command, CancellationToken.None);

        // Assert
        result.Should().NotBe(Guid.Empty);
        result.IsSuccess.Should().BeTrue();
        _userRepository.Received(1).Add(Arg.Any<User>());
        await _unitOfWork.Received(1).CommitAsync();
    }

    [Fact]
    [DisplayName("CreateUserCommand should return error when e-mail is unavailable")]
    public async Task CreateUserCommand_Should_ReturnError_When_EmailIsUnavailabe()
    {
        // Arrange
        var command = new CreateUserCommand("jhondoe@email.com", "JhonDoePass");

        _userRepository.IsEmailRegisteredAsync(Arg.Any<string>())
            .Returns(true);

        // Act
        var result = await CommandHandler
            .Handle(command, CancellationToken.None);

        // Assert
        result.IsSuccess.Should().BeFalse();
        result?.Error?.Message.Should().Be("E-mail is already in use.");
    }

    private static CreateUserCommandHandler CommandHandler =>
        new(_userRepository, _unitOfWork);
    
}
