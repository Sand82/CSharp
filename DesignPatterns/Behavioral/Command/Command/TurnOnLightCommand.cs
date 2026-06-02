namespace Command;

public class TurnOnLightCommand : ICommand
{
    private readonly Light light;

    public TurnOnLightCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.TurnOn();
    }
}
