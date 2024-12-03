using System.Security.Cryptography;
using System.Text;

namespace MainApp.Models;

public class Private : Customer
{
    private readonly string _saltKey = "ABC123";
    
    public string FirstName { get; set; }
    public string LastName { get; set; }


    public override void SetSecurePassword(string password)
    {
        password = $"{_saltKey}{password}";
        base.SetSecurePassword(password);
    }

    public override bool ValidateSecurePassword(string password)
    {
        password = $"{_saltKey}{password}";
        return base.ValidateSecurePassword(password);
    }
}