// ReSharper disable ConvertToConstant.Local
// ReSharper disable SuggestVarOrType_BuiltInTypes
#pragma warning disable CS0219 // Variable is assigned but its value is never used



// Najczęściej używane podstawowe typy danych
// Notka: w c# typy podstawowe (pisane z małej litery) są tylko i wyłącznie aliasem do typów złożonych
// Np. string jest aliasem do klasy String, int jest aliasem do klasy Int32 etc.

{
    int intVar = 10;
    double doubleVar = 10.5;
    float floatVar = 10.5f;
    bool boolVar = true;
    char charVar = 'a';
    string stringVar = "Hello, World!";
}

// Słowo kluczowe var (automatyczne typowanie)
{
    var intVar = 10;
    var stringVar = "Hello World!";
    
    // W c# zazwyczaj używa się go wszędzie i unika się deklarowania zmiennych z wykorzystaniem jawnego typu.
    // Jest on przydatny w momencie wykonywania długiego ciągu instrukcji, gdzie nie wiemy dokładnie, jaki typ danych zostanie nam zwrócony.
    // Np.
    var value = new List<int> {1,2,3,4,5}.Where(e => e % 2 == 0).ToList().FindIndex(e => e % 2 == 0) + 1;
}

// Wartość null
{
    // Aby móc przypisać do zmiennej wartość null, taka zmienna musi zawczasu zostać oznaczona jako zmienna nullowalna.
    // Domyślnie żaden obiekt oparty o typ prosty nie może być przez nas w c# wynullowany.
    // Operatorem nullowalności w c# jest znak zapytania (?)
    int? nullableIntVar = 10;
    nullableIntVar = null;
    int notNullableIntVar = 10;
    // notNullableIntVar = null; // błąd

    // W przypadku typów złożonych, jeżeli nie dodamy operatora nullowalności do typu, a mimo to przypiszemy do zmiennej nulla,
    // powinniśmy otrzymać warning w edytorze oraz podczas kompilacji, który będzie nas o tym ostrzegał.
    List<int> list = null;
}
