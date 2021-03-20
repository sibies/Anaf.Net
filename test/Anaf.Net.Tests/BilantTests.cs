using System.Threading.Tasks;
using Anaf.Net.Bilant;
using FluentAssertions;
using Xunit;

namespace Anaf.Net.Tests
{
    public class BilantTests
    {
        private const int CuiTest = 40790057;

        [Fact]
        public async Task GetBilant()
        {
            const int an = 2019;
            IBilantAnafClient client = new AnafClient();

            var response = await client.GetBilant(CuiTest, an);
            response.Cui.Should().BeGreaterThan(0);
        }
    }
}