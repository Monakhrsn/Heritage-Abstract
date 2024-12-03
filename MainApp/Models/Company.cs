using System.ComponentModel.DataAnnotations;

namespace MainApp.Models;

public class Company : Customer
{
    public string CompanyName { get; set; }
    public string ContactPerson { get; set; }
    
    public Company (string id, string email, string companyName, string contactPerson) : base(id, email)
    {
        CompanyName = companyName;
        ContactPerson = contactPerson;
    }
}

