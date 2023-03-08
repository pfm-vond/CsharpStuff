namespace DemoCsharp_10_Facts
{
    public class ExceptionStuffs
    {
        [Fact]
        public void Exception_can_be_enriched()
        {
            ((Action)EnrichedException).Should().Throw<Exception>().Which.Data["enriched"]
                .Should().Be("i was 10 when the method crashed");
        }

        private void EnrichedException()
        {
            int i = 10;
            try
            {
                ThrowsException();
            }
            catch (Exception ex)
            {
                ex.Data.Add("enriched", $"{nameof(i)} was {i} when the method crashed");
                throw;
            }
        }

        private void ThrowsException()
        {
            throw new Exception();
        }
    }
}
