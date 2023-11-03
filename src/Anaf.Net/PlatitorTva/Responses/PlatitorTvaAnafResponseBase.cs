using System.Collections.Generic;
using Anaf.Net.Responses;

namespace Anaf.Net.PlatitorTva.Responses
{
    public class PlatitorTvaAnafResponseBase<TResponse> : AnafBaseResponse
    {
        public PlatitorTvaAnafResponseBase()
        {
            Found = new List<TResponse>();
            Notfound = new List<string>();
        }

        //public override bool Success => base.Success && Found.All(f => f.Success);

        public List<TResponse> Found { get; set; }
        public List<string> Notfound { get; set; }
    }
}