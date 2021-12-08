namespace G3BlazorComponents.Extensions
{
    public static class ColumnExtensions
    {
        public static string GetValue<T>(this Column<T> column, T t)
        {
            var properties = typeof(T).GetProperties().ToList();
            var memberName = column.PropertyName.Body.GetMemberName();
            var property = properties.FirstOrDefault(x => x.Name == memberName);

            string value = property is not null
                ? property.GetValue(t)?.ToString() ?? string.Empty
                : string.Empty;

            return value;
        }
    }
}