namespace Command;

public class TurnOffLightCommand : ICommand
{
    private readonly Light light;

    public TurnOffLightCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.TurnOff();
    }
}
