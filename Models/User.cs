public class User
{
    public string Id { get; set; }
    public string UpiId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }

    public User()
    {
        UpiId = string.Empty; // or some default value
    }
}
