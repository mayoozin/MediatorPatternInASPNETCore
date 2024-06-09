using MediatorPatterninASPNETCore.JWT.Shared;

namespace MediatorPatterninASPNETCore.JWT.Services.Users;

public class UserService : IUserService
{
    private readonly User _users;

    public async Task<UserDataModel> ValidateUserAsync(string username, string password)
    {
        UserDataModel model = new UserDataModel();
        if (_users.UserName == username)
        {
            VerifyPassword(password, _users.Password);
        }

        model.UserName = username;
        model.Password = password;
        return model;
    }

    private bool VerifyPassword(string password, string storedHash)
    {
        var hash = password.ToHash();
        return hash == storedHash;
    }
}