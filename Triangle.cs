using System;
using System.Collections.Generic;
using System.Text;

namespace OOPgrunderna
{
    public class Triangle
    {
        //Properties of triangle-class
        private double height;
        private double width;

        //Constructur for triangle-class
        public Triangle (double height, double width)
        {
            this.height = height;
            this.width = width;
        }   

        //Calculates the area of a triangle
        public double getAreaTriangle()
        {
            return (height * width) / 2;
        }

        //Calculates the perimeter for triangles
        //Only supports right triangles
        public double getPerimeterForRightTriangle()
        {
            return Math.Sqrt((width * width) + (height * height));
        }
    }
    
    
}
