using MainApp.Models;
var privateCustomer1 = new Private()
{
    Email = "test@test.com",
    FirstName = "Test",
};


privateCustomer1.SetSecurePassword("BytMig321!");
var result = privateCustomer1.ValidateSecurePassword("BytMig321!");

Console.WriteLine(result);
Console.ReadKey();