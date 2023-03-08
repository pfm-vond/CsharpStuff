using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp_10_Facts;

public class ExtensionMethodsExist
{

    [Fact]
    public void Exist()
    {
        3.AsKm().Should().BeOfType<Kilometre>();
    }


    [Fact]
    public void CanBeUseFullForDate()
    {
        3.janvier(2020).Should().HaveDay(3).And.HaveMonth(1).And.HaveYear(2020);
    }


    [Fact]
    public void But_are_static_so_keep_them_simple()
    {
        // you can't simply inject stuff in them.
    }
}

public static class KmExtensions
{
    public static Kilometre AsKm(this int value)
    {
        return new Kilometre(value);
    }
}
public static class DateOnlyExtensions
{
    public static DateOnly janvier(this int day, int year)
    {
        return new DateOnly(year, 1, day);
    }
}
