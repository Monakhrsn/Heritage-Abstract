namespace MainApp.Models;

public abstract class Customer
{
    protected string Id { get; set; }
    protected string Email { get; set; }
    
    protected Customer(string id, string email)
    {
        if(string.IsNullOrWhiteSpace(id)) 
            throw new ArgumentException("Invalid customer id", nameof(id));

        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email can not be null or empty",nameof(email));

        Id = id;
        Email = email;
    }
}

