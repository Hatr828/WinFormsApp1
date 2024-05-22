using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly EmployeeViewModel _viewModel;

        public Form1()
        {
            InitializeComponent();
            _viewModel = new EmployeeViewModel();
            InitializeDataBindings();
        }

        private void InitializeDataBindings()
        {
            textBox1.DataBindings.Add("Text", _viewModel, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add("Text", _viewModel, "Age", true, DataSourceUpdateMode.OnPropertyChanged);

            dataGridView1.DataSource = _viewModel.Employees;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _viewModel.AddEmployee();
        }
    }

    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private string _name;
        private int _age;
        private BindingList<Employee> _employees;

        public event PropertyChangedEventHandler? PropertyChanged;

        public EmployeeViewModel()
        {
            _employees = new BindingList<Employee>();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }

        public BindingList<Employee> Employees
        {
            get { return _employees; }
            set
            {
                _employees = value;
                OnPropertyChanged("Employees");
            }
        }

        public void AddEmployee()
        {
            Employees.Add(new Employee { Name = Name, Age = Age });
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}