using Command;

var light = new Light();

bool isLightOn = false;

while (true)
{
    var isOn = isLightOn  ? "On" : "Off";
    Console.WriteLine("Do you want to lighs " + isOn + " - Yes/No");
    var input = Console.ReadLine();
    ICommand command = null;

    if (input!.ToLower() != "yes" || input!.ToLower() != "no")
    {
        continue;
    }

    if (input!.ToLower() == "no")
    {
        break;
    }    

    if (isLightOn == false)
    {        
        command = new TurnOnLightCommand(light);
    }

    if (isLightOn == true)
    {       
        command = new TurnOffLightCommand(light);
    }

    isLightOn = !isLightOn;
    var remote = new RemoteControl();
    remote.SetCommand(command);
    remote.PressButton();
}



//var turnOn = new TurnOnLightCommand(light);
//var turnOff = new TurnOffLightCommand(light);

//var remote = new RemoteControl();

//remote.SetCommand(turnOn);
//remote.PressButton();

//remote.SetCommand(turnOff);
//remote.PressButton();