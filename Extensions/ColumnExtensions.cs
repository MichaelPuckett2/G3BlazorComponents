using System.Linq;

namespace G3BlazorComponents.Extensions
{
    public static class ColumnExtensions
    {
        /// <summary>
        /// Used to retrieve the value of the current T for the PropertyName of the column.
        /// </summary>
        /// <typeparam name="T">The T parameter</typeparam>
        /// <param name="column">Current column</param>
        /// <param name="t">Instantiated T to lookup column value.</param>
        /// <returns>Value of column that relates to the PropertyName of the column.</returns>
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

        /// <summary>
        /// Gets the auto generated header used for this column.
        /// </summary>
        /// <typeparam name="T">The T parameter</typeparam>
        /// <param name="column">Current column</param>
        /// <returns>string value of the auto generated header.</returns>
        public static string GetAutoHeader<T>(this Column<T> column, bool isSplitCamelCaseWithSpace = true)
        {            
            return isSplitCamelCaseWithSpace
                ? column.PropertyName.Body.GetMemberName().SplitCamelCase()
                : column.PropertyName.Body.GetMemberName();
        }

        /// <summary>
        /// Gets the actual header used for this column. If one is supplied by the Header property that is used, if not, then the AutoHeader is generated and used.
        /// </summary>
        /// <typeparam name="T">The T parameter</typeparam>
        /// <param name="column">Current column</param>
        /// <returns>string based on either the supplied Header or the auto generated header from the PropertyName.</returns>
        public static string GetActualHeader<T>(this Column<T> column, bool isSplitCamelCaseWithSpace = true)
        {
            return string.IsNullOrEmpty(column.Header) ? column.GetAutoHeader(isSplitCamelCaseWithSpace) : column.Header;
        }
    }
}