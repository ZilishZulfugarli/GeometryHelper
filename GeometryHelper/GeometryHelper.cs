using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryHelper
{
    public static class GeometryHelper
    {
        public static double Base {get;set;}
        public static double Height { get;set;}
        public static void Quadrilateral(double Base, double Height)
        {
            double result = (Base * Height) / 2;
            Console.WriteLine("Area is: " + result);
        }

        public static double A { get;set;}
        public static double B { get;set;}
        public static double C { get;set;}
        public static void Triangel(double A, double B, double C)
        {
            double result = (A + B + C) / 2;
            Console.WriteLine("Area is: " + result);
        }
        public static double R {get; set;}
        public static void Circle(double R)
        {

            double result = Math.PI * R * R ;
            Console.WriteLine("Area is: " + result);
        }
    }
}
