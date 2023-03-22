using Autofac;
using DemoDependenciesInjection;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDependenciesInjection_Facts
{
    public class PeopleGenTest
    {

        [Fact]
        public void testId()
        {
            using (var fact = AutoMock.GetLoose(
                p => p.Register<Guid>(c => new Guid("32be321c-9756-4b76-aad3-66d10a962316")).AsSelf()))
            {
                var gen = fact.Create<PeopleGen>();

                gen.CreatePerson().Id.Should().Be(new Guid("32be321c-9756-4b76-aad3-66d10a962316"));
            }

            //    var gen = new PeopleGen(() => new Guid("32be321c-9756-4b76-aad3-66d10a962316"));

            //gen.CreatePerson().Id.Should().Be(new Guid("32be321c-9756-4b76-aad3-66d10a962316"));
        }
    }
}
