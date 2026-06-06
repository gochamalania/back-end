namespace lecture7;

internal class User
{
    // public string UserName;
    // public string Email;

    public User(string userName, string email)
    {
        this.UserName = userName;
        this.Email = email;
    }

    public string UserName { get; set; }
    public string Email { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"User Name: {UserName} - Email: {Email}");
    }

    
    // public User (string userName, string email)
    // {
    //     UserName = userName;
    //     Email = email;
    // }
    
}