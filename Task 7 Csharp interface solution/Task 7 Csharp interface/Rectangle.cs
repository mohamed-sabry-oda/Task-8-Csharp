using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Csharp_interface
{
    internal class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width; Height = height;
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
