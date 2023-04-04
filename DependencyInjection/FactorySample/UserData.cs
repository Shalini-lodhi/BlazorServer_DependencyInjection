namespace DependencyInjection.FactorySample;

public interface IUserData
{
    string? UserName { get; set; }
}

public class UserData : IUserData
{
    public string? UserName { get; set; }
}
