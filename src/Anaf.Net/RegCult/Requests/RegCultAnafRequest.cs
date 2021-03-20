using System;

namespace Anaf.Net.RegCult.Requests
{
    public class RegCultAnafRequest
    {
        public RegCultAnafRequest(int cui) :
            this(cui, DateTime.Now)
        {
        }

        public RegCultAnafRequest(int cui, DateTime data)
        {
            Cui = cui;
            _data = data;
        }

        public int Cui { get; set; }

        private DateTime _data;
        public string Data => _data.ToString("yyyy-MM-dd");
    }
}