using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace oop7
{
    public partial class FormChild : Form
    {
        
        public FormChild()
        {
            InitializeComponent();
        }
        private int Red = 0;
        private int Green = 0;
        private int Blue = 0;
        private int count2;
        SolidBrush solid;
        private void FormChild_Load(object sender, EventArgs e)
        {
          
        }

        private void FormChild_Paint(object sender, PaintEventArgs e)
        {
            Random random = new Random();
            int count = random.Next(0, 4);
            count2 = count;
            Graphics graphics;

            SelectFigure(count);

        }

        private void SelectFigure(int count)
        {
            Graphics graphics;
            if (count == 0)
            {
                // круг 
                graphics = CreateGraphics();
                solid = new SolidBrush(Color.FromArgb(Red, Green, Blue)); // определение цвета 

                graphics.FillEllipse(solid, 200, 200, 250, 250);
            }
            if (count == 1)
            {
                // элепс 
                graphics = CreateGraphics();
                solid = new SolidBrush(Color.FromArgb(Red, Green, Blue)); // определение цвета 

                graphics.FillEllipse(solid, 200, 200, 250, 150);


            }
            if (count == 2)
            {
                // квадрат 
                graphics = CreateGraphics();
                solid = new SolidBrush(Color.FromArgb(Red, Green, Blue)); // определение цвета 


                graphics.FillRectangle(solid, 200, 200, 200, 200);


            }
            if (count == 3)
            {
                // прямоугольник 
                graphics = CreateGraphics();
                solid = new SolidBrush(Color.FromArgb(Red, Green, Blue));// определение цвета 


                graphics.FillRectangle(solid, 200, 200, 300, 150);


            }

           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Red = Convert.ToInt32(trackBar1.Value);
            SelectFigure(count2);
           
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Green = Convert.ToInt32(trackBar1.Value);
            SelectFigure(count2);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Blue = Convert.ToInt32(trackBar1.Value);
            SelectFigure(count2);
        }
    }
}
