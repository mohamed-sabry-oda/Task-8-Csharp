using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Csharp_interface.Interface
{
    internal class CircleShape : IShape
    {
        public  double Radius { get; set; }

        public CircleShape(double radius)
        {
            Radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Radius = {Radius} Area = {Area}");
        }
        public double Area
        {
            get { return 3.14 * Radius * Radius; }
        }
    }
}
