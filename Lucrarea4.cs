using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucrarea4_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Drawing.Graphics Desen;
        System.Drawing.Pen Pen_Violet, Pen_Pink;
        System.Drawing.Brush Brush_Green;
        System.Drawing.Font Font_Arial;
        private void rigla(int lungime, int px)
        {
            Desen.Clear(BackColor);
            Desen.DrawRectangle(Pen_Violet, 10, 90, 30 + lungime * px * 10, 80);
            for (int i = 0; i <= lungime * 10; i++)
            {
                if (i % 5 == 0)
                {
                    Desen.DrawLine(Pen_Pink, 30 + px * i, 135, 30 + px * i, 165);
                }
                else Desen.DrawLine(Pen_Pink, 30 + px * i, 150, 30 + px * i, 165);
                if (i % 10 == 0)
                    Desen.DrawString(System.Convert.ToString(i / 10), Font_Arial, Brush_Green, (25 +
                   px * i), 115);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Desen = CreateGraphics();
            Pen_Violet = new System.Drawing.Pen(System.Drawing.Color.BlueViolet, 1);
            Pen_Pink = new System.Drawing.Pen(System.Drawing.Color.DeepPink, 3);
            Brush_Green = new System.Drawing.SolidBrush(System.Drawing.Color.LawnGreen);
            Font_Arial = new System.Drawing.Font("Arial", 10);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n1 = System.Convert.ToInt32(numericUpDown1.Value);
            int n2 = System.Convert.ToInt32(numericUpDown2.Value);
            rigla(n1, n2);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int n1 = System.Convert.ToInt32(numericUpDown1.Value);
            int n2 = System.Convert.ToInt32(numericUpDown2.Value);
            rigla(n1, n2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int n1 = System.Convert.ToInt32(numericUpDown1.Value);
            int n2 = System.Convert.ToInt32(numericUpDown2.Value);
            rigla(n1, n2);
        }
    }
}
