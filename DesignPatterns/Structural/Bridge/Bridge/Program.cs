using Bridge;
using System.Net.Http.Headers;

var device = new TV();
var remoteControl = new RemoteControl(device);

remoteControl.TogglePower();
remoteControl.VolumeUp();

Console.WriteLine("----------------------------");

IDevice radio = new Radio();
AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(radio);

advancedRemote.TogglePower();
advancedRemote.Mute();