using System.Threading.Tasks;
using Anaf.Net.RegAgric;
using FluentAssertions;
using Xunit;

namespace Anaf.Net.Tests
{
    public class RegAgricTests
    {
        private const int CuiTest = 40790057;

        [Fact]
        public async Task GetInformatiiRegAgric()
        {
            IRegAgricAnafClient client = new AnafClient();

            var response = await client.GetInformatiiRegAgric(CuiTest);
            response.Success.Should().BeTrue();
        }
    }
}