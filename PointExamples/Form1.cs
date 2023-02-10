using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Point point1 = new Point();
            point1.X = 50;
            point1.Y = 100;

            Point point2 = new Point(140, 75);
            Point point3 = new Point(100, 200);
            Point point4 = new Point(60, 75);

            Graphics g = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 5);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            Point[] points = { point1, point2, point3, point4 };

            g.DrawPolygon(redPen, points);
            g.FillPolygon(blueBrush, points);

            //g.DrawLine(redPen, point1, point2);
            //g.DrawLine(redPen, point2, point3);
            //g.DrawLine(redPen, point3, point1);
        }
    }
}
