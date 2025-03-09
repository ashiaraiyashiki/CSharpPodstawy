// ReSharper disable ConvertToConstant.Local
// ReSharper disable SuggestVarOrType_BuiltInTypes
#pragma warning disable CS0219 // Variable is assigned but its value is never used


// Wypisanie wiadomości w terminalu (odpowiednik System.out.print)
Console.Write("Hello, World!\n");

// Wypisanie wiadomości w terminalu (odpowiednik System.out.println)
Console.WriteLine("Hello, World!");

// Wypisanie zmiennej
int zmienna = 10;
Console.WriteLine(zmienna);

//--------------------------------------------------------------------------------------------------------------------

/* Operacje na stringach */
// Konkatenacja 1
var value1 = "World";
var stringVar1 = "Hello" + value1 + "!";
    
// Konkatenacja 2 (operator $)
var value2 = "World";
var stringVar2 = $"Hello {value2}!";

//--------------------------------------------------------------------------------------------------------------------
    
// Operator @ - pominięcie znaków ucieczki, wspiera tekst zapisany w wielu liniach, nie zachowuje wcięć.
// Przykładowa ścieżka do pliku bez użycia operatora @
var stringVar3 = "C:\\Users\\User\\Desktop\\CSharpExamples\\Program.cs";

// Ścieżka z wykorzystaniem operatora @, który umożliwia wypisywanie znaków specjalnych bez użycia znaku ucieczki
var stringVar4 = @"C:\Users\User\Desktop\CSharpExamples\Program.cs";

// Użycie cudzysłowia w stringu z operatorem @
var stringVar5 = @"Hello ""World""";

// String zapisany w wielu liniach
var stringVar6 = @"Hello,
    Welcome to c#";

//--------------------------------------------------------------------------------------------------------------------
    
// Raw string - pominięcie operatora ucieczki, wspiera tekst zapisany w wielu liniach, zachowuje wcięcia.
var stringVar7 = """
                 Hello World
                    This line is indented.
                 I can use "" without any problem.
                 """;
