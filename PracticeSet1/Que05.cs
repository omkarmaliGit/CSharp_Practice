using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuetions1
{
    /* 5.Create base class called shape. Use this class to store two double type values that could be used to compute the area of figures. Derive three specific classes called triangle, circle and rectangle from the base shape. Add to the base class, a member function get_data() to initialize base class data members and display_area() to compute and display area. Make display_area() as a virtual function. */

    class Shape
    {
        private protected double value1;
        private protected double value2;

        internal void get_data()
        {
            value1 = 10;
            value2 = 20;
        }

        internal virtual void display_area()
        {

        }
    }
    class Triangle : Shape
    {
        double triangleArea;
        internal override void display_area()
        {
            triangleArea = 0.5 * value1 * value2;
            Console.WriteLine($"Triangle Area : {triangleArea}");
        }
    }
    class Circle : Shape
    {
        double circleArea;
        internal override void display_area()
        {
            circleArea = 3.14 * value1 * value2;
            Console.WriteLine($"Circle Area : {circleArea}");
        }
    }
    class Rectangle : Shape
    {
        double rectangleArea;
        internal override void display_area()
        {
            rectangleArea = value1 * value2;
            Console.WriteLine($"Rectangle Area : {rectangleArea}");

        }
    }
    internal class Que05
    {
        internal void derive_area()
        {
            Shape s = new Triangle(); //Que5
            s.get_data();
            s.display_area();
            s = new Circle();
            s.get_data();
            s.display_area();
            s = new Rectangle();
            s.get_data();
            s.display_area();
        }
    }
}
