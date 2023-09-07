namespace AbstractFactory
{
    public abstract class VehicleFactory
    {
        public abstract Motor CreateMotors();

        public abstract Car CreateCars();
    }
}
