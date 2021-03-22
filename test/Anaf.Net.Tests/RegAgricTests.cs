using System.Threading.Tasks;
using Anaf.Net.RegAgric;
using FluentAssertions;
using Xunit;

namespace Anaf.Net.Tests
{
    public class RegAgricTests
    {
        private const int CuiTest = 40790057;

        [Theory]
        [InlineData(CuiTest)]
        public async Task GetInformatiiRegAgric(int cui)
        {
            IRegAgricAnafClient client = new AnafClient();

            var response = await client.GetInformatiiRegAgric(cui);
            response.Success.Should().BeFalse();
        }
    }
}