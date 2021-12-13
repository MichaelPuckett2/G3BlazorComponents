using System;
using System.Linq.Expressions;

namespace G3BlazorComponents
{
    public record Column<T>(Expression<Func<T, object>> PropertyName, 
                            string Header = "",
                            double Width = double.NaN);
}
