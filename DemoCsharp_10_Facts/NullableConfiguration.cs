
namespace DemoCsharp_10_Facts
{
    internal class NullableConfiguration
    {
        public void Enabling_nullable_in_csproj_prevent_null()
        {
            /*
                <Nullable>enable</Nullable>
	            <WarningsAsErrors>Nullable</WarningsAsErrors>
            */


            string nullstring = null;

            nullstring.Should().NotBeNull();
        }
    }
}
