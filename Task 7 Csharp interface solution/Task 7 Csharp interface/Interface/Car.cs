using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Csharp_interface.Interface
{
    internal class Car : IMovable
    {
        public string Type { get; set; }

        public Car(string type)
        {
            Type = type;
        }
        public void Move()
        {
            Console.WriteLine($"{Type} is move"); ;
        }
    }
}
