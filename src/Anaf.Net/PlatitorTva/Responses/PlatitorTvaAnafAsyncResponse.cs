namespace Anaf.Net.PlatitorTva.Responses
{
    public class PlatitorTvaAnafAsyncResponse
    {
        public int Cod { get; set; }

        /// <summary>
        /// Successful
        /// </summary>
        public string Message { get; set; }

        public string CorrelationId { get; set; }
    }
}