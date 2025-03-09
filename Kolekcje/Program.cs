// ReSharper disable ConvertToConstant.Local
// ReSharper disable SuggestVarOrType_BuiltInTypes
#pragma warning disable CS0219 // Variable is assigned but its value is never used




// Tablice (kolekcje statyczne)
int[] array = new int[10]; // stworzenie tablicy o długości 10
int[] array2 = [1,2,3,4,5]; // utworzenie oraz zainicjalizowanie tablicy 5 elementami
var intArray = new[] {1, 2, 3, 4, 5}; // tablica utworzona przy użyciu słowa var
    

// Wybrane kolekcje dynamiczne

// Lista
var intList = new List<int>();
intList.Add(1);
intList.Add(2);
intList.Add(2);

// Set
var intHashSet = new HashSet<int>();
intHashSet.Add(1);
intHashSet.Add(2);
intHashSet.Add(1); // ta wartość oczywiście się już nie doda

// Słownik
var intDictionary = new Dictionary<int, string>();
intDictionary.Add(1, "1");
intDictionary.Add(2, "2");
intDictionary.Add(1, "3"); // dostaniemy exception