using System.Threading.Tasks;
using Anaf.Net.RegCult;
using FluentAssertions;
using Xunit;

namespace Anaf.Net.Tests
{
    public class RegCultTests
    {
        private const int CuiTest = 40790057;

        [Theory]
        [InlineData(CuiTest)]
        public async Task GetInformatiiRegCult(int cui)
        {
            IRegCultAnafClient client = new AnafClient();

            var response = await client.GetInformatiiRegCult(cui);
            response.Success.Should().BeFalse();
        }
    }
}