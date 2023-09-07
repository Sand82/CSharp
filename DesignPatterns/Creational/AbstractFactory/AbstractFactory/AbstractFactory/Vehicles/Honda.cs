namespace AbstractFactory.Vehicles
{
    public class Honda : Motor
    {
        public override void Race(Car car)
        {
            Console.WriteLine($"{this.GetType().Name} race {car.GetType().Name}");
        }
    }
}
