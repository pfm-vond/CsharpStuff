using FluentAssertions;
using Xunit;


namespace DemoCsharp_48_Facts
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
            var keyValue = new KeyValue(1, "orange", "agrumes");

            (int key, string value) = keyValue;

            key.Should().Be(1);
            value.Should().Be("orange");
        }

        private class KeyValue
        {
            public KeyValue(int key, string value, string value2)
            {
                Key = key;
                Value = value;
                Value2 = value2;
            }

            public int Key { get; set; }
            public string Value { get; set; }
            public string Value2 { get; set; }

            public void Deconstruct(out int key, out string value)
            {
                key = Key;
                value = Value;
            }
        }
    }

}
