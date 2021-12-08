using System.Linq.Expressions;

namespace G3BlazorComponents.Extensions
{
    public static class ExpressionExtensions
    {
        public static string GetMemberName(this Expression expression)
        {
            return expression.NodeType switch
            {
                ExpressionType.MemberAccess => ((MemberExpression)expression).Member.Name,
                ExpressionType.Convert => GetMemberName(((UnaryExpression)expression).Operand),
                _ => throw new NotSupportedException(expression.NodeType.ToString()),
            };
        }
    }
}
