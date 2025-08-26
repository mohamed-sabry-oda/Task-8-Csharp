using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Csharp_interface.Interface
{
    internal interface IShape
    {
        #region Problem 1
        //// property
        //public int Area { get; }

        ////method
        //public void Draw();
        #endregion

        #region Problem 2
        // property
        public double Area { get; }

        public void Draw();

        // default implementation
        void PrintDetails()
        {
            Console.WriteLine($"Shape Area: {Area}");
        }
        #endregion
    }
}
