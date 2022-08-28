using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Algorithm_Visualiser
{
    public partial class Form1 : Form
    {

        int[] Array;
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            graphics = panel1.CreateGraphics();
            int numEntries = panel1.Width; //number of entries is based on the width of the panel
            int maxValue = panel1.Height; // maximum value is based on the height of the panel
            Array = new int[numEntries];

            graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, numEntries, maxValue); //Initialise the background of the panel as black

            Random rand = new Random();

            for(int i =0; i<numEntries;i++) // Initialises the array to numEntries random numbers of a maxValue maximum value
            {
                Array[i] = rand.Next(0, maxValue);
            }


            for(int i=0;i<numEntries;i++)
            {
                graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, maxValue - Array[i], 1, maxValue);
                // Draws the integers from Array as 1 pixel wide rectangle with other dimensions based on maxValue
            }
        }

        private void Sort_Click(object sender, EventArgs e) // When the sort button is pressed, the algorithm selected is ran
        {
            ISortEngine se = new InsertionSort();
            se.Sort(Array, graphics, panel1.Height);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
