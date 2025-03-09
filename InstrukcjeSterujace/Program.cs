// ReSharper disable ConvertToConstant.Local
// ReSharper disable SuggestVarOrType_BuiltInTypes
#pragma warning disable CS0219 // Variable is assigned but its value is never used



int value = 10;

// Instrukcja if - działanie oraz składnia takie same jak w javie
if (value >= 10)
{
    Console.WriteLine(">= 10");
} else if (value < 10 && value > 0)
{
    Console.WriteLine("< 10 && > 0");
}
else
{
    Console.WriteLine("<= 0");
}

// Switch - działanie oraz składnia takie same jak w javie
switch (value)
{
    case 1: Console.WriteLine("1"); break;
    case 2: Console.WriteLine("2"); break;
    default: Console.WriteLine("0"); break;
}

// Zapisywanie warunków logicznych
bool condition1 = (value > 0 && value < 10) || value > 100;

// Zapisywanie warunków logicznych korzystając z patternu
bool condition2 = value is > 0 and < 10 or > 100;