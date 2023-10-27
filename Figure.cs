using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uspadtask
{
    
    
        internal abstract class Figure
        {
            abstract public double CalculateArea();

            abstract public double CalculatePerimeter();


        }
        class Circle : Figure
        {
            public double Radius { get; set; }

            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }

            public override double CalculatePerimeter()
            {
                return 2 * Math.PI * Radius;
            }
        }
        class Rectangle : Figure
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public override double CalculateArea()
            {
                return Width * Height;
            }

            public override double CalculatePerimeter()
            {
                return 2 * (Width + Height);
            }
        }

    }

