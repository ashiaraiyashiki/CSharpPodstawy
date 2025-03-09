// ReSharper disable ConvertToConstant.Local
// ReSharper disable SuggestVarOrType_BuiltInTypes
#pragma warning disable CS0219 // Variable is assigned but its value is never used



// Notka: w c# typy dzielone są na dwie główne kategorie - typy proste (value types), które w bezpośredni sposób przechowują dane (struct) oraz
// typy referencyjne, które przechowują referencję do jakiegoś obiektu (stworzonego na bazie klasy).
// Nazewnictwo typów podstawowych (pierwsza mała litera) to nic innego jak tzw. cukier składniowy.
// Przykładowo nazwa int wskazuje na struct Int32, nazwa double na struct Double, a nazwa string na klasę String.


// Najczęściej używane podstawowe typy danych
{
    // Typy proste (value types)
    int intVar = 10;
    double doubleVar = 10.5;
    float floatVar = 10.5f;
    bool boolVar = true;
    char charVar = 'a';
    // String jako przykład typu referencyjnego (reference types)
    string stringVar = "Hello, World!";
}

// Słowo kluczowe var (automatyczne typowanie)
{
    var intVar = 10;
    var stringVar = "Hello World!";
    
    // W c# w dużych aplikacjach zazwyczaj unika się deklarowania zmiennych z wykorzystaniem jawnego typu.
    // Jest on przydatny w momencie przypisywania wartości długiego ciągu instrukcji do zmiennej, gdzie nie wiemy dokładnie,
    // jaki typ danych zostanie nam zwrócony.
    // Np.
    var value = new List<int> {1,2,3,4,5}.Where(e => e % 2 == 0).ToList().FindIndex(e => e % 2 == 0) + 1;
}

// Wartość null
{
    // Aby móc przypisać do zmiennej wartość null, taka zmienna musi zawczasu zostać oznaczona jako zmienna nullowalna.
    // Domyślnie żaden obiekt oparty o typ prosty (value type) nie może być przez nas w c# wynullowany.
    // Operatorem nullowalności w c# jest znak zapytania (?)
    int? nullableIntVar = 10;
    nullableIntVar = null;
    int notNullableIntVar = 10;
    // notNullableIntVar = null; // błąd

    // W przypadku typów referencyjnych, jeżeli nie dodamy operatora nullowalności do typu, a mimo to przypiszemy do zmiennej nulla,
    // powinniśmy otrzymać warning w edytorze oraz podczas kompilacji, który będzie nas ostrzegał o wszelkich niebezpiecznych operacjach.
    List<int> list = null;
    
    // Zanim wykonamy jakąś operację na typie nullowalnym, powinniśmy sprawdzić, czy aby przypadkiem nie zawiera on wartości null:
    if (nullableIntVar is not null)
    {
        Console.WriteLine(nullableIntVar + 10);
    }
    
    // Ewentualnie taką wartość w przypadku bycia nullem, możemy zfallbackować na inną wartość, używając operatora ??
    Console.WriteLine(nullableIntVar ?? 0 + 10);
}
