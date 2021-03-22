using System.Collections.Generic;
using System.Linq;
using Anaf.Net.Responses;

namespace Anaf.Net.PlatitorTva.Responses
{
    public class PlatitorTvaAnafResponse : AnafBaseResponse
    {
        public PlatitorTvaAnafResponse()
        {
            Found = new List<PlatitorTvaFoundAnafResponse>();
            Notfound = new List<PlatitorTvaFoundAnafResponse>();
        }

        public override bool Success => base.Success && Found.All(f => f.Success);

        public List<PlatitorTvaFoundAnafResponse> Found { get; set; }
        public List<PlatitorTvaFoundAnafResponse> Notfound { get; set; }
    }
}