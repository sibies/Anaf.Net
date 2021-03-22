
namespace Anaf.Net.Responses
{
    public abstract class AnafBaseResponse
    {
        private const string SuccessMessage = "SUCCESS";
        private const int SuccessCod = 200;

        protected AnafBaseResponse()
        {
            Cod = -1;
            Message = string.Empty;
        }

        /// <summary>
        /// <see cref="SuccessCod"/>
        /// </summary>
        public int Cod { get; set; }
        /// <summary>
        /// SUCCESS
        /// </summary>
        public string Message { get; set; }

        public virtual bool Success => Message.Equals(SuccessMessage) && Cod == SuccessCod;

        public bool Error => !Success;
       
    }
}