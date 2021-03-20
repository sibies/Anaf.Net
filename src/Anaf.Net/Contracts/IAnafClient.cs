using Anaf.Net.Bilant;
using Anaf.Net.PlatitorTva;
using Anaf.Net.RegAgric;
using Anaf.Net.RegCult;

namespace Anaf.Net.Contracts
{
    public interface IAnafClient: IPlatitorTvaAnafClient, IRegAgricAnafClient, IRegCultAnafClient, IBilantAnafClient
    {
        
    }
}