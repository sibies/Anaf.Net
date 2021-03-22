using System.Collections.Generic;
using System.Linq;
using Anaf.Net.Responses;

namespace Anaf.Net.RegCult.Responses
{
    public class RegCultAnafResponse : AnafBaseResponse
    {

        public RegCultAnafResponse()
        {
            Found = new List<RegCultFoundAnafResponse>();
            Notfound = new List<object>();
        }

        public override bool Success => base.Success && Found.All(f => f.Success);

        public List<RegCultFoundAnafResponse> Found { get; set; }
        public List<object> Notfound { get; set; }
    }
}