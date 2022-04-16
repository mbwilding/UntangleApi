using Serilog;
using Serilog.Core;

var untangle = new UntangleApi.UntangleApi("192.168.1.1:81", "admin", "Password123!!", false, true);
if (!await untangle.LoginAsync()) return;
var test = await untangle.GetWebuiStartupInfo();
int i = 0;