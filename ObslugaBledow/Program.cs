// ReSharper disable ConvertToConstant.Local
// ReSharper disable SuggestVarOrType_BuiltInTypes
#pragma warning disable CS0219 // Variable is assigned but its value is never used




// Standardowa obsługa błędów - Działa ona w dokładnie taki sam sposób, jak w javie.

try
{
    // throw new Exception("Error");
    throw new MyCustomException("My custom error");
}
catch (MyCustomException e)
{
    // Wylapanie naszego bledu
    Console.WriteLine(e);
}
catch (Exception e)
{
    // Wylapanie dowolnego bledu (uzycie nadklasy exception)
    Console.WriteLine(e);
}


// Deklaracja naszego własnego błędu
class MyCustomException(string message) : Exception(message);