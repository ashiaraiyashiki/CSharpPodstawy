// ReSharper disable ConvertToConstant.Local
// ReSharper disable SuggestVarOrType_BuiltInTypes
#pragma warning disable CS0219 // Variable is assigned but its value is never used




var oak = new Oak(10, 20, "Red Oak");
var oak2 = new Oak(5, 200, "Red Oak");
Console.WriteLine(oak);
oak.Species = "Yellow Oak";
Console.WriteLine(oak);
Console.WriteLine(oak2);

oak.OverridableMethod();


// Deklaracja interfejsu
interface ITree
{
    void Grow(double toAdd);
    void Trim(double toSub);
}

// Deklaracja abstrakcyjnej klasy, która implementuje interfejs
abstract class Tree(double height, double numberOfLeaves) : ITree
{
    private static int _nextId;
    
    public int Id { get; } = _nextId++;
    public double Height { get; private set; } = height;
    public double NumberOfLeaves { get; private set; } = numberOfLeaves;
    
    public void Grow(double toAdd)
    {
        Height += toAdd;
    }

    public void Trim(double toSub)
    {
        NumberOfLeaves -= toSub;
    }

    // Deklaracja metody, która może zostać nadpisana (słowo kluczowe virtual w nagłówku)
    public virtual void OverridableMethod()
    {
        Console.WriteLine("I can be replaced or extended!");
    }

    public override string ToString()
    {
        return $"[{Id}], height: {Height}, numberOfLeaves: {NumberOfLeaves}";
    }
}

// Deklaracja klasy, która rozszerza inną klasę
class Oak(double height, double numberOfLeaves, string species) : Tree(height, numberOfLeaves)
{
    public string Species { get; set; } = species;

    public override void OverridableMethod()
    {
        base.OverridableMethod();
        Console.WriteLine("OverridableMethod functionality extended");
    }

    public override string ToString()
    {
        return base.ToString() + $", species: {Species}";
    }
}