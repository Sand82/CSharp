using AbstractionExercise;
using AbstractionExercise.Contracts;
using System;

namespace Abstraction
{
    public class Program
    {
        private static List<IWorker> workers = new List<IWorker>();

        static void Main(string[] args)
        {
            IMoneyCounter banker = new Banker();
            ICook chef = new Chef();
            IDigger miner = new Miner();

            workers.AddRange(new IWorker[] { banker, chef, miner });

            foreach (var worker in workers)
            {
                worker.Work();
            }

            banker.CountMoney();
            chef.CookDishes();
            miner.Dig();
        }
    }
}