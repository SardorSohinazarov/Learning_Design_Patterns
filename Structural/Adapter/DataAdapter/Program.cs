// See https://aka.ms/new-console-template for more information
using System.Data.Common;

Console.WriteLine("Hello, World!");


var userData = new UserData
{
    Id = 1,
    FullName = "John Doe",
    EmailAddress = "johndue@gmail.com",
    Password = "password",
    Role = "admin",
    Status = "active",
    CreatedAt = DateTime.Now.ToString(),
    UpdatedAt = DateTime.Now.ToString()
};

var adapter = new Adapter();
var user = adapter.Adapt(userData);
var userData2 = adapter.Adapt(user);

public class Adapter
{
    public User Adapt(UserData userData)
    {
        return new User
        {
            Id = userData.Id,
            Name = userData.FullName,
            Email = userData.EmailAddress
        };
    }

    public UserData Adapt(User user)
    {
        return new UserData
        {
            Id = user.Id,
            User = user,
            FullName = user.Name,
            EmailAddress = user.Email
        };
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class UserData
{
    public int Id { get; set; }
    public User User { get; set; }
    public string FullName { get; set; }
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public string Status { get; set; }
    public string CreatedAt { get; set; }
    public string UpdatedAt { get; set; }
}