namespace MediatorPatterninASPNETCore.JWT.Services.Users;

public interface IUserService
{
    Task<UserDataModel> ValidateUserAsync(string username, string password);
}