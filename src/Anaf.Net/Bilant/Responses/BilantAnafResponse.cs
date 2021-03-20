using System.Collections.Generic;

namespace Anaf.Net.Bilant.Responses
{
    public class BilantAnafResponse
    {
        public int An { get; set; }
        public int Cui { get; set; }
        public string Deni { get; set; }
        public int Caen { get; set; }
        public string den_caen { get; set; }

        public List<BilantIAnafResponse> I { get; set; }

    }
}