using System;

namespace Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            //double num1 = double.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());

            if (name == "square")
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine($"{num * num:f3}");
            }
            else if (name == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{num1 * num2:f3}");
            }
            else if (name == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(radius * radius) * Math.PI:f3}");
            }
            else if (name == "triangle")
            {
                double strana1 = double.Parse(Console.ReadLine());
                double strana2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(strana1 * strana2) / 2:f3}");
            }
        }
    }
}
