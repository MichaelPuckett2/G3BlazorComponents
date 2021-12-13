using System;
using System.Runtime.CompilerServices;

namespace G3BlazorComponents.Exceptions
{
    public class G3PropertyNotFoundException<T> : Exception
    {
        public G3PropertyNotFoundException(string propertyName, [CallerLineNumber] int callerLineNumber = 0, [CallerMemberName] string callerMemberName = "")
        : base($"The property, {propertyName}, was not found on {typeof(T).Name}. At {callerMemberName}, line {callerLineNumber}") { }
    }
}
