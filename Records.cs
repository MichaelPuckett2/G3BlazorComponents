using System.Linq.Expressions;

namespace G3BlazorComponents
{
    public record Column<T>(Expression<Func<T, object>> PropertyName, 
                            string Header = "",
                            double Width = double.NaN,
                            double Height = double.NaN);

    internal class Records
    {
        public void Test()
        {
            var grid = new G3DataGrid<Person>();
            grid.Columns = new Column<Person>[]
            {
                new(x => x.Name, "First Name"),
                new(x => x.Id, "ID"),
                new(x => x.Age, "ID"),
            };
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; } 
        public int Age { get; set; }
    }
}
