using System;
using Anaf.Net.Requests;

namespace Anaf.Net.PlatitorTva.Requests
{
    public class PlatitorTvaAnafRequest : AnafBaseRequest
    {
        public PlatitorTvaAnafRequest(int cui) : base(cui)
        {
        }

        public PlatitorTvaAnafRequest(int cui, DateTime data) : base(cui, data)
        {
        }
    }
}