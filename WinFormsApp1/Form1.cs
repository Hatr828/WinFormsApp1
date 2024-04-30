using System.Linq.Expressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int[] price = { 4, 5, 6, 7 };
        int moneyEarn = 0;
        public Form1()
        {
            InitializeComponent();
            Intialize();
        }

        public void Intialize()
        {
            textBox1.Text = price[0] + " грн";
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = price[comboBox1.SelectedIndex] + " грн";
            try
            {
                textBox3.Text = (Convert.ToInt32(textBox2.Text) * price[comboBox1.SelectedIndex]).ToString();
                label1.Text = (Convert.ToInt32(textBox2.Text) * price[comboBox1.SelectedIndex]).ToString();
            }
            catch (System.FormatException)
            {
                textBox3.Text = "0";
                label1.Text = "0";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = (Convert.ToInt32(textBox2.Text) * price[comboBox1.SelectedIndex]).ToString();
                label1.Text = (Convert.ToInt32(textBox2.Text) * price[comboBox1.SelectedIndex]).ToString();
            }
            catch (System.FormatException)
            {
                textBox3.Text = "0";
                label1.Text = "0";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox111.ReadOnly = !checkBox1.Checked;
            groupBox2_Ressit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox112.ReadOnly = !checkBox1.Checked;
            groupBox2_Ressit();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox113.ReadOnly = !checkBox1.Checked;
            groupBox2_Ressit();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox114.ReadOnly = !checkBox1.Checked;
            groupBox2_Ressit();
        }

        private void groupBox2_Ressit()
        {
            int sum = 0;
            try
            {
                if (checkBox1.Checked)
                {
                    sum += Convert.ToInt32(textBox11.Text) * Convert.ToInt32(textBox111.Text);
                }
                if (checkBox2.Checked)
                {
                    sum += Convert.ToInt32(textBox12.Text) * Convert.ToInt32(textBox112.Text);
                }
                if (checkBox3.Checked)
                {
                    sum += Convert.ToInt32(textBox13.Text) * Convert.ToInt32(textBox113.Text);
                }
                if (checkBox4.Checked)
                {
                    sum += Convert.ToInt32(textBox11.Text) * Convert.ToInt32(textBox114.Text);
                }

                label6.Text = sum.ToString();

            }
            catch (System.FormatException)
            {
                label6.Text = "0";
            }
        }

        private void textBox111_TextChanged(object sender, EventArgs e)
        {
            groupBox2_Ressit();
        }

        private void textBox112_TextChanged(object sender, EventArgs e)
        {
            groupBox2_Ressit();
        }

        private void textBox113_TextChanged(object sender, EventArgs e)
        {
            groupBox2_Ressit();
        }

        private void textBox114_TextChanged(object sender, EventArgs e)
        {
            groupBox2_Ressit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_Ressit();
        }

        private void timer_Ressit()
        {
            try
            {
                label10.Text = (Convert.ToInt32(label1.Text) + Convert.ToInt32(label6.Text)).ToString();
            }
            catch (System.FormatException)
            {
                label10.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            if(temp2)
            {
                moneyEarn += Convert.ToInt32(label10.Text);
                temp2 = false;
            }
        }

        bool temp2 = true;
        bool temp;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (temp)
            {
                timer2.Enabled = false;
                temp2 = true;
                Application.Restart();
            }
            else
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите очистить?", "Подтверждение", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    timer2.Enabled = false;
                    temp2 = true;
                    Application.Restart();
                }
                else
                {
                    temp = true;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"денег заработано: {moneyEarn}", "Подтверждение", MessageBoxButtons.YesNo);
        }
    }

}