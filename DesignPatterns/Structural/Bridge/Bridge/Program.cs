using Bridge;

IDevice device;

while (true)
{
    Console.WriteLine("Create TV or Radio Device");

    var input = Console.ReadLine();

    if (input?.ToLower() == "tv")
    {
        device = new TV();
    }
    else if (input?.ToLower() == "radio")
    {
        device = new Radio();
    }
    else
    {
        break;
    }

    Console.WriteLine("Use remote device command Toggle Power, Volume Up, Volume Down or Mute");

    var advancedRemoteDevice = new AdvancedRemoteControl(device);

    while (true)
    {
        var deviceCommand = Console.ReadLine();

        if (deviceCommand?.ToLower() == "toggle power")
        {
            advancedRemoteDevice.TogglePower();
        }
        else if (deviceCommand?.ToLower() == "volume up")
        {
            advancedRemoteDevice.VolumeUp();
        }
        else if (deviceCommand?.ToLower() == "volume down")
        {
            advancedRemoteDevice.VolumeDown();
        }
        else if (deviceCommand?.ToLower() == "mute")
        {
            advancedRemoteDevice.Mute();
        }
        else
        {
            Console.WriteLine("Do you want to use another device");
            break;
        }
    }
}