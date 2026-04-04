namespace Bridge;

public class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(IDevice device) : base(device)
    {
    }

    public void Mute()
    {
        device.SetVolume(0);
        Console.WriteLine("Device is muted");
    }
}
