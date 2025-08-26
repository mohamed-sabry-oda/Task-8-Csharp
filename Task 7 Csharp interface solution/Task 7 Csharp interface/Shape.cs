using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Csharp_interface
{
    internal abstract class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

        public abstract double CalculateArea();
    }
}
