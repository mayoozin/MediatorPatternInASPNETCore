namespace MediatorPatterninASPNETCore.JWT.Services.JWTToken;

public interface ITokenService
{
    Task<string> GenerateTokenAsync(string username);
}