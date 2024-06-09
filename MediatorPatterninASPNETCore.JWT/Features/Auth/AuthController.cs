using MediatorPatterninASPNETCore.JWT.Services.Users;

namespace MediatorPatterninASPNETCore.JWT.Features.Auth;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly ITokenService _tokenService;
    private readonly IUserService _userService;

    public AuthController(ITokenService tokenService, IUserService userService)
    {
        _tokenService = tokenService;
        _userService = userService;
    }

    [HttpPost("token")]
    public async Task<IActionResult> GenerateToken([FromBody] LoginRequestModel requestModel)
    {
        var user = await _userService.ValidateUserAsync(requestModel.UserName, requestModel.Password);
        if (user is null) return Unauthorized("You are not authorized.");
        var token = await _tokenService.GenerateTokenAsync(requestModel.UserName);
        return Ok(new { Token = token });
    }
}