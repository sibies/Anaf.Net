using System;
using Newtonsoft.Json;

namespace Anaf.Net.Requests
{
    public abstract class AnafBaseRequest
    {
        protected AnafBaseRequest(int cui) :
            this(cui, DateTime.Now)
        {
        }

        protected AnafBaseRequest(int cui, DateTime data)
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