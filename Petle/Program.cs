// ReSharper disable ConvertToConstant.Local
// ReSharper disable SuggestVarOrType_BuiltInTypes
#pragma warning disable CS0219 // Variable is assigned but its value is never used



var collection = new List<int> { 1, 2, 3 };

// Pętla for
for (int i = 0; i < collection.Count; i++)
{
    Console.WriteLine(collection[i]);
}

// Pętla while
var it = 0;
while (it < collection.Count)
{
    Console.WriteLine(collection[it]);
    it++;
}

// Pętla do..while
var it2 = 0;
do
{
    Console.WriteLine(collection[it2]);
    it2++;
} while (it2 < collection.Count);

// Pętla foreach
foreach (var number in collection)
{
    Console.WriteLine(number);
}