using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace MainApp.Models;

public class Company : Customer
{
    public string CompanyName { get; set; } = null!;
    
    public string ContactPerson { get; set; } = null!;
}

