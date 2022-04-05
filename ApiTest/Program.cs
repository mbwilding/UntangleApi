var untangle = new UntangleApi.UntangleApi("192.168.1.1:81", "admin", "password", false);
if (!await untangle.LoginAsync()) return;
Console.WriteLine("YAY");