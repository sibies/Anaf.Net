using System;
using Anaf.Net.Requests;
using Newtonsoft.Json;

namespace Anaf.Net.RegCult.Requests
{
    public class RegCultAnafRequest: AnafBaseRequest
    {
        public RegCultAnafRequest(int cui) : base(cui)
        {
        }

        public RegCultAnafRequest(int cui, DateTime data) : base(cui, data)
        {
        }
    }
}