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

struct EnumLikeStructure
{
    public static EnumLikeStructure CLE1 = new EnumLikeStructure("cle1", "index1");
    public static EnumLikeStructure CLE2 = new EnumLikeStructure("cle2", "index2");
    public static EnumLikeStructure CLE3 = new EnumLikeStructure("cle3", "index3");
    public static EnumLikeStructure CLE4 = new EnumLikeStructure("cle4", "index4");

    public static EnumLikeStructure[] Values => new[] { CLE1, CLE2, CLE3, CLE4 };

    private EnumLikeStructure(string key, string value )
    {
        Key = key;
        Value = value;
    }

    public string Key { get; }
    public string Value { get; }
}