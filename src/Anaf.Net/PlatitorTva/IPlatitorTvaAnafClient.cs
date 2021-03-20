using System.Threading.Tasks;
using Anaf.Net.PlatitorTva.Responses;

namespace Anaf.Net.PlatitorTva
{
    public interface IPlatitorTvaAnafClient
    {
        Task<PlatitorTvaAnafResponse> GetInformatiiPlatitorTva(params int[] cui);
    }
}