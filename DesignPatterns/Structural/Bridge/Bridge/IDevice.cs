namespace Bridge;

public interface IDevice
{
    public bool IsEnabled();
    public void Enable();
    public void Disable();
    public int GetVolume();
    public void SetVolume(int percent);
}
