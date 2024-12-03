using System.Security.Cryptography;
using System.Text;

namespace MainApp.Models;

public abstract class Customer
{
    public string Id { get; private set; }
    public string Email { get; set; } = null!;
    protected string Password { get; set; } = null!;

    protected string Salt { get; set; } = null!;

    public Customer()
    {
        Id = Guid.NewGuid().ToString();
    }

    public virtual void SetSecurePassword(string password)
    {
        using var hmac = new HMACSHA256();
        Salt = Convert.ToBase64String(hmac.Key);
        var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        Password = Convert.ToBase64String(hashBytes);
    }

    public virtual bool ValidateSecurePassword(string password)
    {
        var saltBytes = Convert.FromBase64String(Salt);
        using var hmac = new HMACSHA256(saltBytes);
        var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        var hashedPassword = Convert.ToBase64String(hashBytes);
        
        return Password == hashedPassword;
        
    }
}

