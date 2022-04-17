using Serilog;

namespace Untangle.SupportClasses;

public static class Logging
{
    /// <summary>
    /// Initializes Serilog
    /// </summary>
    internal static void Init()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Verbose()
            .WriteTo.Console()
            .CreateLogger();
    }
}