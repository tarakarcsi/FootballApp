namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }
    public required string UserName { get; set; }
    public byte[] PasswordHash { get; set; } = [];
    public byte[] PasswordSalt { get; set; } = [];
    public required string Nickname { get; set; }
    public Photo? Photo { get; set; }
    public required string Email { get; set; }
}
