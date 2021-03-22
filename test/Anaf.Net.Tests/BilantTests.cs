using System.Threading.Tasks;
using Anaf.Net.Bilant;
using FluentAssertions;
using Xunit;

namespace Anaf.Net.Tests
{
    public class BilantTests
    {
        private const int CuiTest = 40790057;

        [Theory]
        [InlineData(CuiTest)]
        public async Task GetBilant(int cui)
        {
            const int an = 2019;
            IBilantAnafClient client = new AnafClient();

            var response = await client.GetBilant(cui, an);
            response.Success.Should().BeTrue();
        }
    }
}