namespace Anaf.Net.Responses
{
    public class ErrorAnafResponse: AnafBaseResponse
    {
        public ErrorAnafResponse()
        {
            Cod = -1;
            Message = "Error";
        }
    }
}