using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http.HttpResults;

namespace MediatorPatternInASPNETCore.Services.JWTToken;

public class TokenService : ITokenService
{
    private readonly IConfiguration _configuration;

    public TokenService(IConfiguration configuration) => _configuration = configuration;

    public async Task<string> GenerateTokenAsync(string username)
    {
        string test = "";
        return test;
    }
}