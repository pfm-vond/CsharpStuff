using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCsharp_10_Facts
{
    public class Patterns
    {

        [Fact]
        public void Can_enhanced_lisibility()
        {
            string message = "Nay :( ";

            if (new Kilometre(25.2) is { Value: 25.2 })
            {
                message = "yeah !";
            }

            message.Should().Be("yeah !");
        }
    }
}
