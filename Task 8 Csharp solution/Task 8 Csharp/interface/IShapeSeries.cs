using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_Csharp
{
    interface IShapeSeries
    {
        int CurrentShapeArea { get; set; }
        void GetNextArea();
        void ResetSeries();
    }
}
