using System.Collections.Generic;
using System.Linq;
using Anaf.Net.Responses;

namespace Anaf.Net.RegAgric.Responses
{
    public class RegAgricAnafResponse: AnafBaseResponse
    {

        public RegAgricAnafResponse()
        {
            Found = new List<RegAgricFoundAnafResponse>();
            Notfound = new List<RegAgricFoundAnafResponse>();
        }
        public override bool Success => base.Success && Found.All(f => f.Success);

        public List<RegAgricFoundAnafResponse> Found { get; set; }
        public List<RegAgricFoundAnafResponse> Notfound { get; set; }
    }
}