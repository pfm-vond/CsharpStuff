using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp_10_Facts
{
    
    public class DebuggingStuff
    {
        [Fact]
        public void DebugView_can_be_enhanced()
        {
            Metre distance = 25200;

            Kilometre distanceInKm = (Kilometre)distance;

            double nbMetre = distance;

            nbMetre.Should().Be(25200);

            distanceInKm.Value.Should().Be(25.2);
        }
    }
}
