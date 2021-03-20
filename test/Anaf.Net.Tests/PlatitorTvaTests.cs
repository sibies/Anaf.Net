using System;
using System.Threading.Tasks;
using Anaf.Net.PlatitorTva;
using FluentAssertions;
using Xunit;

namespace Anaf.Net.Tests
{
    public class PlatitorTvaTests
    {
        private const int CuiTest = 40790057;

        [Fact]
        public async Task GetInformatiiPlatitorTvaSync()
        {
            IPlatitorTvaAnafClient client = new AnafClient();

            var response = await client.GetInformatiiPlatitorTva(CuiTest);
            response.Success.Should().BeTrue();
        }

        [Fact]
        public async Task InregistreazaCerereInformatiiPlatitorTvaAsync()
        {
            IPlatitorTvaAnafClientAsync client = new AnafClient();

            var response = await client.InregistreazaCerereInformatiiPlatitorTvaAsync(CuiTest);
            response.Cod.Should().Be(200);
        }

        [Fact]
        public async Task GetInformatiiPlatitorTvaAsync()
        {
            const string id = "31d97e61-4f51-4549-b7fc-482b7410f71f";
            IPlatitorTvaAnafClientAsync client = new AnafClient();

            var response = await client.GetInformatiiPlatitorTvaAsync(id);
            response.Success.Should().BeTrue();
        }
    }
}