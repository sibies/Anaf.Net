using System.Threading.Tasks;
using Anaf.Net.RegAgric.Responses;

namespace Anaf.Net.RegAgric
{
    /// <summary>
    /// Serviciu web pentru verificarea contribuabililor care sunt inregistrati in Registrul agricultorilor care aplica regimul special
    /// https://static.anaf.ro/static/10/Anaf/Informatii_R/documentatie_SWRARG_v2.txt
    /// </summary>
    public interface IRegAgricAnafClient
    {
        Task<RegAgricAnafResponse> GetInformatiiRegAgric(params int[] cui);
    }
}