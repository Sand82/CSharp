namespace Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweightDictionary = new Dictionary<string, Flyweight>();

        public FlyweightFactory()
        {
            flyweightDictionary.Add("X", new ConcreteFlyweight());
            flyweightDictionary.Add("Y", new ConcreteFlyweight());
            flyweightDictionary.Add("Z", new ConcreteFlyweight());
            flyweightDictionary.Add("A", new UnsharedConcreteFlyweight());
            flyweightDictionary.Add("B", new UnsharedConcreteFlyweight());
            flyweightDictionary.Add("C", new UnsharedConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return flyweightDictionary[key];
        }
    }
}
