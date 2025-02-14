# Uninitialized Property Access in C#

This example demonstrates a common error in C#: attempting to use a property before it's been assigned a value.  This can easily result in a `NullReferenceException` if the property is a reference type.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file shows how to fix it by initializing the property.

This is a simple but important example of how proper initialization can prevent runtime exceptions.