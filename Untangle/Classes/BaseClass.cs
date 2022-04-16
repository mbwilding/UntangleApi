//Non-nullable field is uninitialized
#pragma warning disable CS8618
// Non-accessed field
#pragma warning disable CS0414
// Unassigned field
#pragma warning disable CS0649

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global

namespace UntangleApi.Classes;

public static class BaseClass
{
    internal class Request
    {
        public uint Id = 297;
        public string Nonce;
        public string Method;
        public string[] Params = Array.Empty<string>();
    }
    
    public class ResponseString
    {
        public string Result;
        public uint Id;
    }
    
    public class ResultObject
    {
        public string JavaClass;
        public string JsonRpcType;
        public uint ObjectId;
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

    public class Translations
    {
        // ReSharper disable InconsistentNaming
        public string? Thousand_Sep;
        public string? TimeStamp_Fmt;
        public string? Date_Fmt;
        public string? Decimal_Sep;
        // ReSharper enable InconsistentNaming
    }

    public class LanguageSettings
    {
        public string OverrideDateFmt;
        public string OverrideTimestampFmt;
        public int LastSynchronized;
        public string OverrideDecimalSep;
        public string JavaClass;
        public string Language;
        public string RegionalFormats;
        public string OverrideThousandSep;
        public string Source;
    }
}