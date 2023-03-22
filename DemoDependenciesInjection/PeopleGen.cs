using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDependenciesInjection
{
    public class PeopleGen
    {
        private readonly Func<Guid> guidGenrator;

        public PeopleGen(Func<Guid> guidGenrator, IPrenomGenerator generator)
        {
            this.guidGenrator = guidGenrator;
        }

        public Person CreatePerson() 
        {
            return new Person(guidGenrator());
        }
    }

    public record Person(Guid Id);

    public interface IPrenomGenerator { }
}

