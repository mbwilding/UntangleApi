namespace UntangleApi;

internal static class Exchange
{
    internal class Request
    {
        public int Id { get; } = 297;
        public string Nonce { get; } = "ec61pq84h9ov52ev9nurmldr95";
        public string Method { get; set; } = "system.getNonce";
        public string[] Params { get; set; } = Array.Empty<string>();
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