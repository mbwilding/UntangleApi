﻿var untangle = new UntangleApi.UntangleApi("192.168.1.1:81", "admin", "Password123!!", false, true);
if (!await untangle.StartAsync()) return;