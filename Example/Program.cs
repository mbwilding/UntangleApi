// Unreachable code
#pragma warning disable CS0162

var untangle = new Untangle.UntangleApi(
    "192.168.1.1:81",
    "admin",
    "Password123!!");

if (!await untangle.StartAsync()) return;

if (false)
{
    // Local: Change admin password
    untangle.AdminSettings!.Users.List
        .First(x => x.Username == "admin")
        .Password = "Password123!!";
    // Remote: Apply AdminSettings changes
    await untangle.AdminSettings.ApplyAsync();
}

Console.ReadLine(); // Breakpoint here and inspect 'untangle'