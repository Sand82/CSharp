using System;

namespace Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int extrinsicstate = 22;
            FlyweightFactory factory = new FlyweightFactory();
            
            var fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            var fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            var fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            var fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);

            var fa = factory.GetFlyweight("A");
            fa.Operation(--extrinsicstate);
        }
    }
}