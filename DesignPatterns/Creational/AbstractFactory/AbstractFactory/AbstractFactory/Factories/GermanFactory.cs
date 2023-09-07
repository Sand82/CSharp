using AbstractFactory.Vehicles;

namespace AbstractFactory.Factories
{
    public class GermanFactory : VehicleFactory
    {
        public override Car CreateCars()
        {
            return new BMW();
        }

        public override Motor CreateMotors()
        {
            return new DKW();
        }
    }
}
