using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Csharp
{
    internal abstract class Shape
    {
        public void Display()
        {
            Console.WriteLine($"Area is {GetArea()}");
        }
        public abstract double GetArea();
    }
}
