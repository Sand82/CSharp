using AbstractionExercise.Contracts;

namespace AbstractionExercise
{
    public class Chef : IWorker, ICook
    {
        public void CookDishes()
        {
            Console.WriteLine("Cooking breakfastm, lunch and diner.");
        }

        public void Work()
        {
            Console.WriteLine("Work in kitchen.");
        }
    }
}
