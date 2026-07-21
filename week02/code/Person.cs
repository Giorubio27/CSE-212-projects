public class Person
{
    public readonly string Name;
    public int Turns { get; set; }
    public bool foreverTurns { get; set; }

    internal Person(string name, int turns)
    {
        Name = name;
        Turns = turns;

        if (Turns <= 0)
        {
            foreverTurns = true;
        }
    }

    public override string ToString()
    {
        return Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})";
    }
}