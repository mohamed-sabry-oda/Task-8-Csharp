using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Csharp
{
    class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike start"); ;
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike stop"); ;
        }
    }
}
