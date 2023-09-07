using AbstractFactory.Vehicles;

namespace AbstractFactory.Factories
{
    public class JapanFactory : VehicleFactory
    {
        public override Car CreateCars()
        {
            return new Mazda();
        }

        public override Motor CreateMotors()
        {
            return new Honda();
        }
    }
}
