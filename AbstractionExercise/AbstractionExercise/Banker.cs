using AbstractionExercise.Contracts;

namespace AbstractionExercise
{
    public class Banker : IWorker, IMoneyCounter
    {
        public void CountMoney()
        {
            Console.WriteLine("Counting money every day.");
        }

        public void Work()
        {
            Console.WriteLine("Work in bank.");
        }
    }
}
