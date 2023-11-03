using System.Threading.Tasks;
using Anaf.Net.PlatitorTva.Responses;

namespace Anaf.Net.PlatitorTva
{
    public interface IPlatitorTvaV6AnafClient
    {
        Task<PlatitorTvaV8AnafResponse> GetInformatiiPlatitorTva(params int[] cui);
        Task<PlatitorTvaV6AnafResponse> GetInformatiiPlatitorTvaV6(params int[] cui);
    }
}