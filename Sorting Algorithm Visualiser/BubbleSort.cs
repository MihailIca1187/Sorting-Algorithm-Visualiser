using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sorting_Algorithm_Visualiser
{
    class BubbleSort : ISortEngine
    {

        private bool _sorted = false;
        private int[] Array;
        private Graphics graphics1;
        private int maxValue;
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

        public void Sort(int [] Array_In, Graphics graphics_In, int maxValue_In)
        {
            Array = Array_In;
            graphics1 = graphics_In;
            maxValue = maxValue_In;

            while(!_sorted)
            {
                for(int i=0;i<Array.Count()-1;i++)
                {
                    if(Array[i] > Array[i+1])
                    {
                        Swap(i, i + 1);
                    }
                }
                _sorted = IsSorted();
            }
        }
        private void Swap(int i, int p) // Standard bubble sort method
        {
            int temp = Array[i];
            Array[i] = Array[i+1];
            Array[i + 1] = temp;

            graphics1.FillRectangle(BlackBrush, i, 0, 1, maxValue);
            graphics1.FillRectangle(BlackBrush, p, 0, 1, maxValue);

            graphics1.FillRectangle(WhiteBrush, i, maxValue - Array[i], 1, maxValue);
            graphics1.FillRectangle(WhiteBrush, p, maxValue - Array[p], 1, maxValue);
        }

        private bool IsSorted() //function that validates whther the array is sorted or not
        {
            for(int i=0;i<Array.Count()-1;i++)
            {
                if(Array[i] > Array[i+1])
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
