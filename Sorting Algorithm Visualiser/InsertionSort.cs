using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sorting_Algorithm_Visualiser
{
    class InsertionSort : ISortEngine
    {

        private bool _sorted = false;
        private int[] Array;
        private Graphics graphics1;
        private int maxValue;
        Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

        public void Sort(int[] Array_In, Graphics graphics_In, int maxValue_In)
        {
            Array = Array_In;
            graphics1 = graphics_In;
            maxValue = maxValue_In;
            int i, j, insert;

            while (!_sorted)
            {
                for(i=1;i<maxValue;i++)
                {
                    insert = Array[i];
                    j = i;

                    while((j>0) && (Array[j-1] > insert))
                    {
                        Array[j] = Array[j - 1];
                        j = j - 1;

                        graphics1.FillRectangle(BlackBrush, i, 0, 1, maxValue);
                        graphics1.FillRectangle(BlackBrush, j, 0, 1, maxValue);

                        graphics1.FillRectangle(WhiteBrush, i, maxValue - Array[i], 1, maxValue);
                        graphics1.FillRectangle(WhiteBrush, j, maxValue - Array[j], 1, maxValue);
                    }
                    Array[j] = insert;
                    
                }
                _sorted = true;
            }
        }
       

        private bool IsSorted() //function that validates whther the array is sorted or not
        {
            for (int i = 0; i < Array.Count() - 1; i++)
            {
                if (Array[i] > Array[i + 1])
                {
                    return false;
                }

            }
            return true;
        }
    }
}
