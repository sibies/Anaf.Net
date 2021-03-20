using System;
using Newtonsoft.Json;

namespace Anaf.Net.PlatitorTva.Requests
{
    public class PlatitorTvaAnafRequest
    {
        public PlatitorTvaAnafRequest(int cui): 
            this(cui, DateTime.Now)
        {
        }

        public PlatitorTvaAnafRequest(int cui, DateTime data)
        {
            Cui = cui;
            _data = data;
        }

        [JsonProperty("cui")]
        public int Cui { get; set; }

        private DateTime _data;
        [JsonProperty("data")]
        public string Data => _data.ToString("yyyy-MM-dd");
    }
}