using MaterialSkin.Controls;
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
    public partial class Form1 : MaterialForm
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Task.Run(() => Button_Move());
        }

        private void Button_Move()
        {
            if (button1.Location.X > 10 && this.Location.X > button1.Location.X)
            {
                this.Invoke(new EventHandler(delegate
                {
                    button1.Location = new Point(button1.Location.X + hScrollBar1.Value, button1.Location.Y);
                }));
            }
            else
            {
                this.Invoke(new EventHandler(delegate
                    {
                        button1.Location = new Point(button1.Location.X - hScrollBar1.Value, button1.Location.Y);
                    }));
            }
        }
    }

}
