namespace MediatorPatternInASPNETCore.Services.JWTToken;

public class TokenService : ITokenService
{
    private readonly IConfiguration _configuration;

    public TokenService(IConfiguration configuration) => _configuration = configuration;
}