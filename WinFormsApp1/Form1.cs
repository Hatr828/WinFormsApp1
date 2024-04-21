namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int level;
        private int answer;
        private int correctAnswers = 0;
        private int incorrectAnswers = 0;
        private int quastions = 1;
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Random rd = new Random();
            int temp1 = rd.Next(0, 20);
            int temp2 = rd.Next(0, 20);

            panel1.Visible = true;
            StartButton.Visible = true;
            button1.Visible = false;
            textBox3.Visible = false;
            answer = temp1 * temp2;
            textBox1.Text = temp1 + " * " + temp2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var Panel in Controls.OfType<Panel>())
            {
                this.Controls.Remove(Panel);
            }
            this.Controls.Remove((Control)sender);
            button1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            level = radioButton1.Checked ? 1 : radioButton2.Checked ? 2 : 3;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (quastions < 10)
            {
                Random rd = new Random();
                int temp1 = rd.Next(0, 20);
                int temp2 = rd.Next(0, 20);

                if (string.Equals(answer.ToString(), textBox2.Text))
                {
                    correctAnswers += 1;
                }
                else
                {
                    incorrectAnswers += 1;
                }
                quastions += 1;
                answer = temp1 * temp2 * level * level;
                textBox2.Text = "";
                textBox1.Text = (temp1 * level) + " * " + (temp2 * level);
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
                textBox3.Visible = true;
                textBox3.Text = "Correct answers: " + correctAnswers + "\n\n Incorrect answers: " + incorrectAnswers;
            }
        }
    }
}