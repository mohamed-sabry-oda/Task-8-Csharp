using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Csharp
{
    class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("car start"); ;
        }

        public void StopEngine()
        {
            Console.WriteLine("car stop"); ;
        }
    }
}
