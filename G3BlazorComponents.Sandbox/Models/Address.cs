namespace G3BlazorComponents.Sandbox.Models;

public record Address(string Address1, string Address2, string City, string State, string Zip)
{
    public static Address Empty { get; } = new(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
}
