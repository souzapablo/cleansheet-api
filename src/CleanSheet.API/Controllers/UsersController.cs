using CleanSheet.Application.Features.Users.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanSheet.API.Controllers;

[ApiController]
[Route("api/v1/users")]
public class UsersController(ISender sender) : ControllerBase
{
    private readonly ISender _sender = sender;

    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUserInput input)
    {
        var command = new CreateUserCommand(input.Email, input.Password);

        var result = await _sender.Send(command);

        if (!result.IsSuccess)
            return BadRequest(result);

        return Ok(result);
    }
}
