namespace MainApp.Models;

public class Private : Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public Private(string id, string firstName, string lastName, string email ) : base(id, email)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string GetId()
    {
        return Id;
    }

    public void SetId(string id)
    {
        Id = "P-" + id;
    }
}