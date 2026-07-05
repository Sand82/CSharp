using Observer;

var weatherStation = new WeatherStation();

var phone = new PhoneDisplay();
var tv = new TVDisplay();

weatherStation.Attach(phone);
weatherStation.Attach(tv);

weatherStation.SetTemperature(22);

weatherStation.Detach(tv);

weatherStation.SetTemperature(28);