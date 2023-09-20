using System.Runtime.CompilerServices;

namespace G3BlazorComponents.Exceptions;

[ExcludeFromCodeCoverage(Justification = "Custom Exception")]
[Serializable]
public class PropertyNotFoundException<T> : Exception
{
    internal PropertyNotFoundException(string propertyName, [CallerLineNumber] int callerLineNumber = 0, [CallerMemberName] string callerMemberName = "")
    : base($"The property, {propertyName}, was not found on {typeof(T).Name}. At {callerMemberName}, line {callerLineNumber}") { }
}
