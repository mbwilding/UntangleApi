namespace UntangleApi;

public static class Exchange
{
    internal class Request
    {
        public int Id = 297;
        public string Nonce;
        public string Method;
        public string[] Params = Array.Empty<string>();
    }

    public class ResponseString
    {
        public string Result;
        public int Id;
    }
    
    #region Error
    
    internal class ErrorResponse
    {
        public Error Error;
    }

    internal class Error
    {
        public string Msg;
        public int Code;
    }
    
    #endregion
    
    #region AppManager
    
    public class ResponseAppManager
    {
        public ResultAppManager Result;
        public int Id;
    }

    public class ResultAppManager
    {
        public string JavaClass;
        public string JsonRpcType;
        public uint ObjectId;
    }

    #endregion
}