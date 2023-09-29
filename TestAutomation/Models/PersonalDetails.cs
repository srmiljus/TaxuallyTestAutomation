namespace TaxuallyTestAutomation.Models;

public record PersonalDetails
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CountryCode { get; set; }
    public string PhoneNumber { get; set; }
    public string YourEmail { get; set; }
    public string Password { get; set; }
}
