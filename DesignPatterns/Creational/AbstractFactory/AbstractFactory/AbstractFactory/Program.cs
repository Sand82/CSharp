using AbstractFactory.Factories;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            VehicleFactory german = new GermanFactory();
            VehicalRace vehicalRace = new VehicalRace(german);
            vehicalRace.StartRace();

            VehicleFactory japan = new JapanFactory();
            vehicalRace = new VehicalRace(japan);
            vehicalRace.StartRace();
        }
    }
}