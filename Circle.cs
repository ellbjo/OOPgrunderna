using System;
using System.Collections.Generic;
using System.Text;


namespace OOPgrunderna                  //Ellinor Vonck .NET22
{
    public class Circle
    {
        //Properties of circle-class
        private const double pi = 3.14;
        public int radius;

        //Constructor for circle-class
        public Circle(int radius)
        {
            this.radius = radius;
        }

        //Calculates the area of a circle
         public double getAreaCircle()
        {
            return (radius * radius) * pi;
        }

        //Calculates the circumference of a circle
        public double getCircumferenceCircle()
        {
            return (radius * 2) * pi;
        }

        //Calculates the volume of a sphere
        public double getShereVolume()
        {
            return (4 * pi * (radius ^ 3)) / 3;
        }


    }
}

