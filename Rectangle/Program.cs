namespace Program
{
    // using System;

    class Program
    {
        static void Main(string[] args)
        {

            Rectangle parent1 = new Rectangle(10, 15, "yellow");
            Console.WriteLine("Parent1 is:");
            parent1.printRectangle();

            Rectangle parent2 = new Rectangle(4, 8, "red");
            Console.WriteLine("Parent2 is:");
            parent2.printRectangle();

            Rectangle baby = parent1.MakeMeRectangle(parent2);
            Console.WriteLine("Baby is:");
            baby.printRectangle();

            Console.WriteLine("And now parent1 replaces parent2!");

            Rectangle baby2 = parent2.MakeMeRectangle(parent1);
            Console.WriteLine("Baby2  is:");
            baby2.printRectangle();


        }
    }

}