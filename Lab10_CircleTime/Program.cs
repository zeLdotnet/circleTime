using System;

namespace Lab10_CircleTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool go = true;
            while (go)
            {
                Console.Write("Please enter a radius! \t");
                try
                {
                    double input = double.Parse(Console.ReadLine());
                    Circle circle = new Circle(input);

                    double circumference = circle.CalculateCircumference(input);
                    double area = circle.CalculateArea(input);

                    Console.WriteLine($"\nCircle Area: {area}");
                    Console.WriteLine($"Cirle Circumference: {circumference}");
                    count++;
                }
                catch
                {
                    Console.WriteLine("\nWhoa there! Gotta enter a number!");
                }

                Console.Write("\ncontinue? [y/n] \t");
                string userChoice = Console.ReadLine();

                if (userChoice == "y" || userChoice == "yes")
                {

                    go = true;
                }
                else if (userChoice == "n" || userChoice == "no")
                {
                    Console.WriteLine($"\nYou made {count} circles. Later!");
                    go = false;
                }
            }
        }
    }
}
