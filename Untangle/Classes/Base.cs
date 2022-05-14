using System.Text.Json.Serialization;

namespace Untangle.Classes;

public static class Base
{
    internal class Request
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }
        
        [JsonPropertyName("nonce")]
        public string? Nonce { get; set; }
        
        [JsonPropertyName("method")]
        public string? Method { get; set; }
        
        [JsonPropertyName("params")]
        public object? Params { get; set; }
    }
    
    public class ResponseString
    {
        [JsonPropertyName("result")]
        public string? Result { get; set; }
        
        [JsonPropertyName("id")]
        public int? Id { get; set; }
    }

    internal class ErrorResponse
    {
        [JsonPropertyName("error")]
        public Error? Error { get; set; }
    }

    internal class Error
    {
        [JsonPropertyName("msg")]
        public string? Msg { get; set; }
        
        [JsonPropertyName("code")]
        public int? Code { get; set; }
    }
}