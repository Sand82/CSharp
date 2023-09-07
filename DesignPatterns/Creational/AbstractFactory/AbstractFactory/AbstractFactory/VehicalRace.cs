namespace AbstractFactory
{
    public class VehicalRace
    {
        private Car car;

        private Motor motor;

        public VehicalRace(VehicleFactory vehicleFactory)
        {
            car = vehicleFactory.CreateCars();
            motor = vehicleFactory.CreateMotors();
        }

        public void StartRace()
        {
            motor.Race(car);
        }
    }
}
