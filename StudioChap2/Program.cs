using System;
namespace StudioChap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of circle: " + area);
            
           double circumference = 2 * radius;
            Console.WriteLine("Circumference of circle : " + circumference);
            Console.WriteLine("Enter the miles per gallon of their car");
            double milesPerGallon = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Is the radius entered is in miles  Y /N ");
            char milesorNot = Convert.ToChar(Console.ReadLine());
            if (milesorNot == 'Y'|| milesorNot == 'y')
            {
                double gallonsRequired = radius / milesPerGallon;
                Console.WriteLine("Gallons: " + gallonsRequired);
            }
        }
    }
}