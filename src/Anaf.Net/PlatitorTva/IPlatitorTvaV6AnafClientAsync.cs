using System.Threading.Tasks;
using Anaf.Net.PlatitorTva.Responses;

namespace Anaf.Net.PlatitorTva
{
    public interface IPlatitorTvaV6AnafClientAsync
    {
        Task<PlatitorTvaAnafAsyncResponse> InregistreazaCerereInformatiiPlatitorTvaAsync(params int[] cui);
        Task<PlatitorTvaV8AnafResponse> GetInformatiiPlatitorTvaAsync(string id);
        Task<PlatitorTvaV6AnafResponse> GetInformatiiPlatitorTvaV6Async(string id);
    }
}