﻿namespace DemoCsharp_10_Facts
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
