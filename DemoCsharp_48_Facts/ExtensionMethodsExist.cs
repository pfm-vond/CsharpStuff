using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace DemoCsharp_48_Facts
{
    public class ExtensionMethodsExist
    {


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

    public static class DateOnlyExtensions
    {
        public static DateTime janvier(this int day, int year)
        {
            return new DateTime(year, 1, day);
        }
    }
}