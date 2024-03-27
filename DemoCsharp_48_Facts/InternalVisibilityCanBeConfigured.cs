using DemoCsharp_48;
using FluentAssertions;
using Xunit;

namespace DemoCsharp_48_Facts
{
    public class InternalVisibility
    {

        [Fact]
        public void InternalCanBeVisibleToOtherProject()
        {
            new InvisibleToCustomer().Should().NotBeNull();
        }
    }
}
