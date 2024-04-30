namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            label8 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox114 = new TextBox();
            textBox113 = new TextBox();
            textBox112 = new TextBox();
            textBox111 = new TextBox();
            groupBox3 = new GroupBox();
            button1 = new Button();
            label10 = new Label();
            label9 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 369);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "автозаправка";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 150);
            textBox2.MaxLength = 4;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 27);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 204);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 8;
            label5.Text = "сумма";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 7;
            label4.Text = "кiлькiсть";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 6;
            label3.Text = "цiна";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 5;
            label2.Text = "бензин";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(6, 241);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(224, 122);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "до сплати";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(185, 99);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 2;
            label8.Text = "грн";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(74, 89);
            label1.TabIndex = 0;
            label1.Text = "0";
            label1.Click += label1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.Location = new Point(79, 201);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 88);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A-100", "A-86", "A-90", "A-95" });
            comboBox1.Location = new Point(79, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "A-100";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(textBox14);
            groupBox2.Controls.Add(textBox13);
            groupBox2.Controls.Add(textBox12);
            groupBox2.Controls.Add(textBox11);
            groupBox2.Controls.Add(textBox114);
            groupBox2.Controls.Add(textBox113);
            groupBox2.Controls.Add(textBox112);
            groupBox2.Controls.Add(textBox111);
            groupBox2.Location = new Point(254, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 369);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "кафе";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Location = new Point(6, 241);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(250, 122);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "до сплати";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(211, 99);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 1;
            label7.Text = "грн";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(74, 89);
            label6.TabIndex = 0;
            label6.Text = "0";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 159);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(77, 24);
            checkBox4.TabIndex = 11;
            checkBox4.Text = "воздух";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 113);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(72, 24);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "водда";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 69);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(66, 24);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "пица";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 24);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "школад";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(144, 157);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(48, 27);
            textBox14.TabIndex = 7;
            textBox14.Text = "3";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(144, 111);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(48, 27);
            textBox13.TabIndex = 6;
            textBox13.Text = "6";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(144, 67);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(48, 27);
            textBox12.TabIndex = 5;
            textBox12.Text = "5";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(144, 22);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(48, 27);
            textBox11.TabIndex = 4;
            textBox11.Text = "4";
            // 
            // textBox114
            // 
            textBox114.Location = new Point(208, 157);
            textBox114.Name = "textBox114";
            textBox114.ReadOnly = true;
            textBox114.Size = new Size(48, 27);
            textBox114.TabIndex = 3;
            textBox114.Text = "0";
            textBox114.TextChanged += textBox114_TextChanged;
            // 
            // textBox113
            // 
            textBox113.Location = new Point(208, 111);
            textBox113.Name = "textBox113";
            textBox113.ReadOnly = true;
            textBox113.Size = new Size(48, 27);
            textBox113.TabIndex = 2;
            textBox113.Text = "0";
            textBox113.TextChanged += textBox113_TextChanged;
            // 
            // textBox112
            // 
            textBox112.Location = new Point(208, 67);
            textBox112.Name = "textBox112";
            textBox112.ReadOnly = true;
            textBox112.Size = new Size(48, 27);
            textBox112.TabIndex = 1;
            textBox112.Text = "0";
            textBox112.TextChanged += textBox112_TextChanged;
            // 
            // textBox111
            // 
            textBox111.Location = new Point(208, 22);
            textBox111.Name = "textBox111";
            textBox111.ReadOnly = true;
            textBox111.Size = new Size(48, 27);
            textBox111.TabIndex = 0;
            textBox111.Text = "0";
            textBox111.TextChanged += textBox111_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(12, 387);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(498, 195);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "касса";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(6, 41);
            button1.Name = "button1";
            button1.Size = new Size(131, 121);
            button1.TabIndex = 4;
            button1.Text = "Оплатить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(143, 29);
            label10.Name = "label10";
            label10.Size = new Size(111, 133);
            label10.TabIndex = 2;
            label10.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(459, 172);
            label9.Name = "label9";
            label9.Size = new Size(33, 20);
            label9.TabIndex = 3;
            label9.Text = "грн";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 10000;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 594);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private GroupBox groupBox4;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox114;
        private TextBox textBox113;
        private TextBox textBox112;
        private TextBox textBox111;
        private GroupBox groupBox5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
        private Button button1;
        private TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}