using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp_10_Facts
{
    public class AnonymousTypeAndDeconstructors
    {
        [Fact]
        public void AnonymousType_can_be_handy()
        {
            var keyValue = (key: 1, Value: "orange");

            (int key, string value) = keyValue;

            key.Should().Be(1);
            value.Should().Be("orange");
        }


        [Fact]
        public void AnonymousType_can_be_easily_swap_in_the_future()
        {
            var keyValue = new KeyValueValue(1, "orange", "agrumes");

            (int key, string value) = keyValue;

            key.Should().Be(1);
            value.Should().Be("orange");
        }

        private record KeyValueValue(int Key, string Value, string Value2)
        {
            public void Deconstruct(out int key, out string value)
            {
                key = Key;
                value = Value;
            }
        }
    }

}
