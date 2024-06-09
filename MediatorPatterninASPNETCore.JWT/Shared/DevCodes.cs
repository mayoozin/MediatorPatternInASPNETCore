namespace MediatorPatterninASPNETCore.JWT.Shared;

public static class DevCodes
{
    public static string ToHash(this string password)
    {
        using var sha256 = System.Security.Cryptography.SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(password);
        var hash = sha256.ComputeHash(bytes);
        var passwordHash = Convert.ToBase64String(hash);
        return passwordHash;
    }
}