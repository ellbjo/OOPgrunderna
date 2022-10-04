using System;
using OOPgrunderna;

namespace OOPgrunderna
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creates two circle-objects
            Circle small = new Circle(5);
            Circle big = new Circle(6);

            //Prints area and circumference of the circle-objects into the console
            Console.WriteLine(small.getAreaCircle());
            Console.WriteLine(big.getAreaCircle());

            Console.WriteLine(small.getCircumferenceCircle());
            Console.WriteLine(big.getCircumferenceCircle());

            //Prints volume of a sphere-object into the console
            Console.WriteLine(small.getShereVolume());
            Console.WriteLine(big.getShereVolume());

            //Creates one triangle-object
            Triangle one = new Triangle(3, 4);

            //Prints area and perimeter of triangle-object into console
            Console.WriteLine(one.getAreaTriangle());
            Console.WriteLine(one.getPerimeterForRightTriangle());
        }


    }
}
