using Serilog;

namespace Untangle.SupportClasses;

public static class Logging
{
    /// <summary>
    /// Initializes Serilog
    /// </summary>
    public static void Init(bool verbose = false)
    {
        if (verbose)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Console()
                .CreateLogger();
        }
        else
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .CreateLogger();
        }
    }
}