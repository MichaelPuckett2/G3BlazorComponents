using G3BlazorComponents.Sandbox.Models;
using Specky6;
using System.Collections.Immutable;

namespace G3BlazorComponents.Sandbox.ViewModels;

[Singleton]
public class PersonsViewModel
{
    public PersonsViewModel()
    {
        var persons = new List<Person>();
        for (int i = 15, y = 0; i < 25; i++, y++)
            persons.Add(new()
            {
                FirstName = $"FirstMock{i}",
                LastName = $"LastMock{i}",
                Address = new Address($"Street Mock {i}", string.Empty, $"City Mock {i}", $"State Mock {i}", $"{i}{i}{i}{i}{i}"),
                Age = i,
                Email = $"FirstMock{i}.LastMock{i}@fakeplace.comm",
                Phone = $"{y}{y}{y}-{y}{y}{y}-{y}{y}{y}{y}"
            });
        Persons = ImmutableList.Create(persons.ToArray());
    }
    public IEnumerable<Person> Persons { get; set; } = Enumerable.Empty<Person>();
}
