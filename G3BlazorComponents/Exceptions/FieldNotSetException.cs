using System.Runtime.CompilerServices;

namespace G3BlazorComponents.Exceptions;

[ExcludeFromCodeCoverage(Justification = "Custom Exception")]
[Serializable]
public class FieldNotSetException : Exception
{
    internal FieldNotSetException(string fieldName, [CallerLineNumber] int callerLineNumber = 0, [CallerMemberName] string callerMemberName = "")
    : base($"The field, {fieldName}, was not set, and is required. At {callerMemberName}, line {callerLineNumber}") { }
}
