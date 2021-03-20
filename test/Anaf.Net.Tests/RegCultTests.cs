using System.Threading.Tasks;
using Anaf.Net.RegCult;
using FluentAssertions;
using Xunit;

namespace Anaf.Net.Tests
{
    public class RegCultTests
    {
        private const int CuiTest = 40790057;

        [Fact]
        public async Task GetInformatiiRegCult()
        {
            IRegCultAnafClient client = new AnafClient();

            var response = await client.GetInformatiiRegCult(CuiTest);
            response.Success.Should().BeTrue();
        }
    }
}