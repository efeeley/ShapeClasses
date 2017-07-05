using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**************************************
 * Name: Elisabeth Feeley
 * Date: 7/2/2012
 * Assignment: HW1-2_EKF (Test Shape)
 * Resources: N/A
 * ***********************************/

namespace HW1_2_EKF
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine(circle.calcArea());

            Rectangle rectangle = new Rectangle(4, 5);
            Console.WriteLine(rectangle.calcArea());

            Console.ReadLine();
        }//end static void
    }//end class program

    public abstract class Shape
    {
        protected double area;

        public abstract double calcArea();
    }//end public abstract class Shape

    public class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }//end public Circle

        public override double calcArea()
        {
            area = 3.14 * (radius * radius);
            return (area);
        }//end override double calcArea
    }//end public class Circle : Shape

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            length = 1;
            width = w;
        }//end public Rectangle

        public override double calcArea()
        {
            area = length * width;
            return (area);
        }//end public override double calcArea
    }//end public class Rectangle : Shape
}//end namespace HW1-2_EKF