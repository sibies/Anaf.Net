﻿using System.Collections.Generic;
using System.Linq;

namespace Anaf.Net.PlatitorTva.Responses
{
    public class PlatitorTvaAnafResponse
    {
        private const string Success_Message = "SUCCESS";

        public PlatitorTvaAnafResponse()
        {
            Found = new List<PlatitorTvaFoundAnafResponse>();
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
        public List<PlatitorTvaFoundAnafResponse> Found { get; set; }
        public List<object> Notfound { get; set; }
    }
}