using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public class Circle
    {
        private double _radius;

        public Circle(double radius) 
        {
            _radius = radius;
        }

        public double Area
        {

        get 
            {
                return Math.PI * _radius * _radius; // Area = PI * radius^2
            } 
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Radius {_radius}");
            Console.WriteLine($"Area: {Area}");

        }
    }
    
}
