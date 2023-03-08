using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using DemoKilometre = DemoCsharp_10.Kilometre;


namespace DemoCsharp_10_Facts
{
    public class UsingAreAliases
    {

        [Fact]
        public void Are_not_import()
        {
            // no class nor library will be included because none are used
            // using are just an preprocessor Alias thingy.
        }


        [Fact]
        public void Can_rename_things()
        {
            var d = new DemoKilometre(24);
            var d2 = new Kilometre();
        }

        private record struct Kilometre();
    }
}
