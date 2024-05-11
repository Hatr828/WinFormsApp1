using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Point points;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            points = new Point(e.X,e.Y);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Random rd = new Random();
            var brushes = new Brush[]
            {
                Brushes.AliceBlue,
                Brushes.Aqua,
                Brushes.Beige,
                Brushes.BurlyWood,
                Brushes.DarkOrchid,
                Brushes.LightGreen
            };
            int circleSize = rd.Next(10, 70);
                g.FillEllipse(brushes[rd.Next(0, brushes.Length)], points.X, points.Y, circleSize, circleSize);
        }
    }
}
