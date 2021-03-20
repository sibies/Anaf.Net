using System.Collections.Generic;
using System.Linq;

namespace Anaf.Net.RegCult.Responses
{
    public class RegCultAnafResponse
    {
        private const string Success_Message = "SUCCESS";

        public RegCultAnafResponse()
        {
            Found = new List<RegCultFoundAnafResponse>();
            Notfound = new List<object>();
        }
        /// <summary>
        /// 200
        /// </summary>
        public int Cod { get; set; }

        public bool Success => Message.Equals(Success_Message) && Found.All(f => f.Success);

        public bool Error => !Success;
        /// <summary>
        /// SUCCESS
        /// </summary>
        public string Message { get; set; }
        public List<RegCultFoundAnafResponse> Found { get; set; }
        public List<object> Notfound { get; set; }
    }
}