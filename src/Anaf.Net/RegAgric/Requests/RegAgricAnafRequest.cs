using System;
using Anaf.Net.Requests;

namespace Anaf.Net.RegAgric.Requests
{
    public class RegAgricAnafRequest: AnafBaseRequest
    {
        public RegAgricAnafRequest(int cui) : base(cui)
        {
        }

        public RegAgricAnafRequest(int cui, DateTime data) : base(cui, data)
        {
        }
    }
}