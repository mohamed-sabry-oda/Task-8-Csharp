using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Csharp
{
    internal class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot is walking in its normal way.");
        }
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is walking as defined by IWalkable interface."); 
        }
    }
}
