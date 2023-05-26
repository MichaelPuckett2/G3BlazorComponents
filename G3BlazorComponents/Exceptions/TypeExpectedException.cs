﻿using System.Runtime.CompilerServices;

namespace G3BlazorComponents.Exceptions;

public class TypeExpectedException<T> : Exception
{
    public TypeExpectedException([CallerLineNumber] int callerLineNumber = 0, [CallerMemberName] string callerMemberName = "")
    : base($"The type {typeof(T).Name} was expected but not discovered. At {callerMemberName}, line {callerLineNumber}") { }
}
