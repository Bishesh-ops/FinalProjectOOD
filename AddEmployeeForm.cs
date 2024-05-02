using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AddEmployeeForm : Form
    {
        private EmployeeRepository employeeRepository;

        internal AddEmployeeForm(EmployeeRepository employeeRepository)
        {
            InitializeComponent();
            this.employeeRepository = employeeRepository;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string department = txtDepartment.Text;
            string contactInfo = txtContactInfo.Text;
            decimal shourlyWage = decimal.Parse(hourlyWage.Text);
            int shoursWorked = int.Parse(hoursWorked.Text);

            Employee newEmployee = new Employee(name, department, contactInfo, shourlyWage, shoursWorked);

            employeeRepository.AddEmployee(newEmployee);

            Close();
        }

        private void Department_Click(object sender, EventArgs e)
        {
            // Add event handling code if needed
        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {
            // Add event handling code if needed
        }

        private void txtContactInfo_TextChanged(object sender, EventArgs e)
        {
            // Add event handling code if needed
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
