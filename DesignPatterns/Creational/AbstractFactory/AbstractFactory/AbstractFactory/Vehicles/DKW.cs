namespace AbstractFactory.Vehicles
{
    internal class DKW : Motor
    {
        public override void Race(Car car)
        {
            Console.WriteLine($"{this.GetType().Name} race {car.GetType().Name}");
        }
    }
}
