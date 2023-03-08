using System.Diagnostics;

namespace DemoCsharp_10;



[DebuggerDisplay("{Value} lumens")]
public readonly record struct lumens(double Value);


[DebuggerDisplay("{Value} km")]
public readonly record struct Kilometre(double Value)
{
    public static explicit operator Metre(Kilometre d) => new Metre(d.Value * 1000);
}

[DebuggerDisplay("{Value} m")]
public readonly record struct Metre(double Value)
{
    public static explicit operator Kilometre(Metre d) => new Kilometre(d.Value / 1000);

    public static implicit operator double(Metre d) => d.Value;
    public static implicit operator Metre(double d) => new Metre(d);
}

internal readonly record struct InvisibleToCustomer();

public class toto
{
    public string Name { get; }
}

struct Champs
{
    public static Champs CLE1 = new Champs("cle1", "index1");
    public static Champs CLE2 = new Champs("cle2", "index2");
    public static Champs CLE3 = new Champs("cle3", "index3");
    public static Champs CLE4 = new Champs("cle4", "index4");

    public static Champs[] Values => new[] { CLE1, CLE2, CLE3, CLE4 };

    private Champs(string key, string value )
    {
        Key = key;
        Value = value;
    }

    public string Key { get; }
    public string Value { get; }
}