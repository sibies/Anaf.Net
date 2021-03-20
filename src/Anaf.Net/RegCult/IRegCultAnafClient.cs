using System.Threading.Tasks;
using Anaf.Net.RegCult.Responses;

namespace Anaf.Net.RegCult
{
    /// <summary>
    /// Serviciu web pentru verificarea contribuabililor care sunt inregistrați in Registrul entităților/unităților de cult
    /// https://static.anaf.ro/static/10/Anaf/Informatii_R/index_cult_v2.html
    /// </summary>
    public interface IRegCultAnafClient
    {
        Task<RegCultAnafResponse> GetInformatiiRegCult(params int[] cui);

    }
}