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

        private int gameNumber = new Random().Next(1, 100);
        private int tries = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            button1.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameNumber = new Random().Next(1, 100);
            tries = 10;
            textBox6.Text = $"Кол попыток: {tries}";
            textBox5.Text = $"";

            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tries > 1)
            {
                try
                {
                    if (Convert.ToInt32(textBox4.Text) == gameNumber)
                    {
                        MessageBox.Show("Вы выйграли");
                        Application.Exit();
                    }
                    else
                    {
                        tries -= 1;
                        textBox6.Text = $"Кол попыток: {tries}";
                        textBox5.Text = $"Не правильно";
                        textBox4.Text = "";
                    }
                }
                catch (FormatException)
                {
                    tries -= 1;
                    textBox6.Text = $"Кол попыток: {tries}";
                    textBox5.Text = $"Не правильно";
                    textBox4.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Вы проиграли");
                Application.Exit();
            }
        }
    }
}
