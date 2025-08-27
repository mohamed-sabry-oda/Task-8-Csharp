using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Csharp
{
    internal class SquareSeries : IShapeSeries
    {
        private int side;
        public int CurrentShapeArea { get ; set ; }

        public void GetNextArea()
        {
            side++;
            CurrentShapeArea = side * side;
        }

        public void ResetSeries()
        {
            side = 0;
            CurrentShapeArea = 0;
        }
    }
}
