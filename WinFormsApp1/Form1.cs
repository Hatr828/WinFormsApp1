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

        private List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            employees.Add(new Employee());

            dataGridView1.DataSource = employees;
            dataGridView1.Columns.Remove("Id");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Employee employee = new Employee()
            {
                Name = textBox1.Text,
                Position = textBox2.Text,
                Department = textBox3.Text

            };
            dataGridView1.AutoGenerateColumns = false;
            employees.Add(employee);
            dataGridView1.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Employee selectedEmployee = dataGridView1.SelectedRows[0].DataBoundItem as Employee;

                employees.Remove(selectedEmployee);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
    }
}
