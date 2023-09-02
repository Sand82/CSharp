using AbstractionExercise.Contracts;

namespace AbstractionExercise
{
    public class Miner : IWorker, IDigger
    {
        public void Dig()
        {
            Console.WriteLine("Dig for coals.");
        }

        public void Work()
        {
            Console.WriteLine("Work in mine!");
        }
    }
}
