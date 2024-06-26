﻿namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        { 
            var mainComponent = new MainComponent();

            var setComponent = Setup(mainComponent);

            Client(setComponent);
        }

        private static void Client(MainComponent mainComponent)
        {
            Console.WriteLine(mainComponent.GetNumber());
        }

        private static MainComponent Setup(MainComponent mainComponent)
        {
            var firstLeaf = new LeafOne();
            var secondLeaf = new LeafTwo();
            var thirdLeaf = new LeafThree();
            var fourthLeaf = new LeafFour();
            var fifthLeaf = new LeafFive();
            var sixthLeaf = new LeafSix();

            var firstComponent = new ComponentOne();
            firstComponent.AddChild(firstLeaf);
            firstComponent.AddChild(secondLeaf);
            firstComponent.AddChild(thirdLeaf);

            var secondComponent = new ComponentTwo();
            secondComponent.AddChild(fourthLeaf);
            secondComponent.AddChild(fifthLeaf);
            secondComponent.AddChild(sixthLeaf);

            mainComponent.AddChild(firstComponent);
            mainComponent.AddChild(secondComponent);

            return mainComponent;
        }
    }
}