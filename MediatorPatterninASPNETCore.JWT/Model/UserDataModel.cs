namespace MediatorPatterninASPNETCore.JWT.Model;

public class User
{
    public string UserName = "mayoo";
    public string Password = "password";
}

public class UserDataModel
{
    public string UserName { get; set; }
    public string Password { get; set; }
}