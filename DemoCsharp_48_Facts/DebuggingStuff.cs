using System.Diagnostics;
using FluentAssertions;
using Xunit;

namespace DemoCsharp_48_Facts
{
    
    public class DebuggingStuff
    {
        [Fact]
        public void DebugView_can_be_enhanced()
        {
            Kilometre distanceInKm = new Kilometre() { Value = 25.2 };

            distanceInKm.Value.Should().Be(25.2);
        }

        [DebuggerDisplay("{Value} km")]
        private class Kilometre
        {
            public double Value { get; set; }
        }
    }
}
