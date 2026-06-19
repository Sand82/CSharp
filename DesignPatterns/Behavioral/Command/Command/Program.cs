using Command;

var light = new Light();

bool isLightOn = false;

while (true)
{
    var isOn = isLightOn ? "On" : "Off";
    Console.WriteLine("Do you want to lighs " + isOn + " - Yes/No");
    var input = Console.ReadLine();
    ICommand command = null;

    if (input!.ToLower() == "no")
    {
        break;
    }

    if (input!.ToLower() != "yes")
    {
        continue;
    }    

    command = isLightOn ? new TurnOffLightCommand(light) : new TurnOnLightCommand(light);    

    isLightOn = !isLightOn;
    var remote = new RemoteControl();
    remote.SetCommand(command);
    remote.PressButton();
}
