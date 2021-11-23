using System.Runtime.CompilerServices;

namespace G3BlazorComponents.Exceptions
{
    public class G3FieldNotSetException : Exception
    {
        public G3FieldNotSetException(string fieldName, [CallerLineNumber] int callerLineNumber = 0, [CallerMemberName] string callerMemberName = "")
        : base($"The field, {fieldName}, was not set, and is required. At {callerMemberName}, line {callerLineNumber}") { }
    }
}
