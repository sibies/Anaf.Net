using System.Threading.Tasks;
using Anaf.Net.Bilant.Responses;

namespace Anaf.Net.Bilant
{
    /// <summary>
    /// Serviciu web pentru obtinerea  informatiilor publice din situatiile financiare/raportarile contabile anuale aferente agentilor economici.
    /// </summary>
    public interface IBilantAnafClient
    {
        Task<BilantAnafResponse> GetBilant(int cui, int an);
    }
}