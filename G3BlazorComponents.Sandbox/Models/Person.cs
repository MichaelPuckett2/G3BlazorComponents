namespace G3BlazorComponents.Sandbox.Models;

public class Person
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public Address Address { get; set; } = Address.Empty;
    public int Age { get; set; }
}
