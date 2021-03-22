using System.Collections.Generic;
using Anaf.Net.Responses;

namespace Anaf.Net.Bilant.Responses
{
    public class BilantAnafResponse: AnafBaseResponse
    {
        public int An { get; set; }
        public int Cui { get; set; }
        public string Deni { get; set; }
        public int Caen { get; set; }
        public string den_caen { get; set; }

        public List<BilantIAnafResponse> I { get; set; }

        public override bool Success => !string.IsNullOrEmpty(Deni);
    }
}