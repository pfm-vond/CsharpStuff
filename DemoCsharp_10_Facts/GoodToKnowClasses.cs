using Microsoft.VisualStudio.TestPlatform.Utilities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace DemoCsharp_10_Facts
{
    public class GoodToKnowClasses
    {
        [Fact]
        public void System_IDisposable_when_Behviour_should_be_done_before_after_or_both()
        {
            List<int> list = new List<int>();

            using (var toto = new Disposable(list))
            {
                list.Add(1);
                list.Add(2);

                list.Count().Should().Be(2);
            }

            list.Count().Should().Be(0);
        }

        private class Disposable : System.IDisposable
        {
            public Disposable(List<int> list)
            {
                _list = list;
            }

            private List<int> _list { get; }

            public void Dispose()
            {
                _list.Clear();
            }
        }

        [Fact]
        public void System_FormatableString_for_accessing_to_the_arg_of_a_string()
        {
            int id = 1;
            string name = "pierre";
            System.FormattableString ex = $"the id for {name} is {id}";

            ex.GetArgument(0).Should().Be(name);
            ex.GetArgument(1).Should().Be(id);
        }

        [Fact]
        public void System_Diagnostics_CodeAnalysis_NotNullAttribute_for_preventing_null()
        {
            string name = "pierre";

            CantBeNull(out name);

            name.Should().NotBeNull();

            string? name2 = null;

            CantBeNull(out name2);

            name2.Should().NotBeNull();
        }

        private void CantBeNull([System.Diagnostics.CodeAnalysis.NotNull] out string? s)
        {
            s = "";
        }

        [Fact]
        public void System_Dynamic_ExpandoObject_to_define_an_dictionnary_string_Object_from_code()
        {
            dynamic o = new System.Dynamic.ExpandoObject();
            o.toto = 1;
            o.titi = "string";

            IDictionary<string, object?> dictionaire = o;
            dictionaire.Keys.Should().Contain("toto");
            dictionaire.Keys.Should().Contain("titi");

            dictionaire["toto"].Should().Be(1);
            dictionaire["titi"].Should().Be("string");
            ((Func<object?>)(() => dictionaire["plop"])).Should().Throw<KeyNotFoundException>();
        }

        [Fact]
        public void System_Runtime_CompilerServices_CallerMemberNameAttribute_to_access_the_name_of_the_caller()
        {
            string toto = "plop";

            CallerName(toto).Should().Be(nameof(System_Runtime_CompilerServices_CallerMemberNameAttribute_to_access_the_name_of_the_caller));
        }

        private string CallerName(string value,
            [System.Runtime.CompilerServices.CallerMemberName] string name = "")
        {
            return name;
        }


        [Fact]
        public void System_Runtime_CompilerServices_CallerArgumentExpression_to_access_the_name_of_the_parameter()
        {
            string toto = "plop";

            NameOf(toto).Should().Be(nameof(toto));
        }

        private string NameOf(string value,
            [System.Runtime.CompilerServices.CallerArgumentExpression("value")] string name = "")
        {
            return name;
        }
    }
}