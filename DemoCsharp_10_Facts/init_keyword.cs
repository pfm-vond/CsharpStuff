namespace DemoCsharp_10_Facts
{
    public class init_keyword
    {
        [Fact]
        public void Keyword_init_does_not_mean_required()
        {
            var notInitialized = new AnyClassWithInit();

            // Impossible
            // notInitialized.ImmutableProperty = 2;

            notInitialized.ImmutableProperty.Should().BeNull();
        }

        [Fact]
        public void Keyword_init_is_identical_to_adding_the_property_in_all_constructor_as_optional()
        {
            var initializedViaInit = new AnyClassWithInit() { ImmutableProperty = 2 };
            var initializedViaCtor = new AnyClassWithOptionalCtor(2);

            initializedViaInit.ImmutableProperty.Should().Be(initializedViaCtor.ImmutableProperty);
        }
    }

    /*
    dont exist in c# 10.
    public class AnyClassWithInit
    {
        public required int? ImmutableProperty { get; init; }
    }
    */

    public class AnyClassWithOptionalCtor
    {
        public AnyClassWithOptionalCtor(int? immutableProperty = null)
        {
            ImmutableProperty = immutableProperty;
        }

        public int? ImmutableProperty { get; }
    }

    public class AnyClassWithInit
    {
        public int? ImmutableProperty { get; init; }
    }
}
