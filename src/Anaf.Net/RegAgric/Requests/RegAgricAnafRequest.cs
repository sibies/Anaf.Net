using System;

namespace Anaf.Net.RegAgric.Requests
{
    public class RegAgricAnafRequest
    {
        public RegAgricAnafRequest(int cui) :
            this(cui, DateTime.Now)
        {
        }

        public RegAgricAnafRequest(int cui, DateTime data)
        {
            Cui = cui;
            _data = data;
        }

        public int Cui { get; set; }

        private DateTime _data;
        public string Data => _data.ToString("yyyy-MM-dd");
    }
}