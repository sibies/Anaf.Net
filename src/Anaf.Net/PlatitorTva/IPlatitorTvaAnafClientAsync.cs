using System.Threading.Tasks;
using Anaf.Net.PlatitorTva.Responses;

namespace Anaf.Net.PlatitorTva
{
    public interface IPlatitorTvaAnafClientAsync
    {
        Task<PlatitorTvaAnafAsyncResponse> InregistreazaCerereInformatiiPlatitorTvaAsync(params int[] cui);
        Task<PlatitorTvaAnafResponse> GetInformatiiPlatitorTvaAsync(string id);
    }
}