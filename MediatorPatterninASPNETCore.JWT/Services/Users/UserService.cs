using MediatorPatterninASPNETCore.JWT.Shared;

namespace MediatorPatterninASPNETCore.JWT.Services.Users;

public class UserService : IUserService
{
    public async Task<UserDataModel> ValidateUserAsync(string username, string password)
    {
        UserDataModel model = new UserDataModel
        {
            UserName = "mayoo",
            Password = "mayoo123"
        };

        if (model.UserName == username)
        {
            VerifyPassword(password, model.Password);
        }

        return model;
    }

    private bool VerifyPassword(string password, string storedHash)
    {
        var hash = password.ToHash();
        return hash == storedHash;
    }
}