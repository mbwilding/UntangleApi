var untangle = new Untangle.UntangleApi(
    "192.168.1.1:81",
    "admin",
    "Password123!!",
    false,
    true);
if (!await untangle.StartAsync())
    Console.WriteLine("Start up failed");

if (false)
{
    untangle.AdminSettings!.Users.List.FirstOrDefault()!.Password = "Password123!!";
    await untangle.SetAdminSettingsAsync();
}

Console.ReadLine(); // Breakpoint here and inspect 'untangle'