using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sorting_Algorithm_Visualiser
{
    interface ISortEngine 
    {
        void Sort(int[] Array, Graphics graphics, int maxVal);
    }
}
