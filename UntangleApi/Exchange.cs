namespace UntangleApi;

public static class Exchange
{
    internal class Request
    {
        public int Id { get; } = 297;
        public string Nonce { set; get; }
        public string Method { get; set; } = "system.getNonce";
        public string[] Params { get; set; } = Array.Empty<string>();
    }

    public class ResponseString
    {
        public string Result;
        public int Id;
    }
    
    public class ResponseObject
    {
        public Result Result;
        public int Id;
    }

    public class Result
    {
        public string JavaClass { get; set; }
        public string JsonRpcType { get; set; }
        public uint ObjectId { get; set; }
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