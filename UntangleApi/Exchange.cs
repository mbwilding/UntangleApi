namespace UntangleApi;

internal static class Exchange
{
    internal class GetAuthenticationTokenRequest
    {
        public int Id = 297;
        public string Nonce = "";
        public string Method = "system.getNonce";
        public string[] Params = Array.Empty<string>();
    }

    internal class GetAuthenticationTokenResponse
    {
        public string Result;
        public int Id;
    }

    internal class ErrorResponse
    {
        public Error Error;
    }

    internal class Error
    {
        public string Msg;
        public int Code;
    }
}