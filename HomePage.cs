using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class HomePage : Form
    {
        private EmployeeRepository employeeRepository;
        private LeaveRequestRepository leaveRequestRepository;
        private List<Employee> employees;

        public HomePage()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
            leaveRequestRepository = new LeaveRequestRepository(employeeRepository);
            this.FormClosed += HomePage_FormClosed;


            listBoxEmployees.DoubleClick += listBoxEmployees_DoubleClick;
        }

       

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            LoadEmployeeList();
            LoadLeaveRequests();
            dataGridViewEmployees.CellDoubleClick += dataGridViewEmployees_CellDoubleClick;
        }
       

        private void LoadEmployeeData()
        {
            dataGridViewEmployees.DataSource = null;
            employees = employeeRepository.GetAllEmployees();
            dataGridViewEmployees.DataSource = employees;
            
        }
        private void LoadEmployeeList()
        {
            foreach (Employee employee in employees)
            {
                listBoxEmployees.Items.Add(employee.Name);
            }
        }
        private void LoadLeaveRequests()
        {
            leaveRequestsDataGridView.DataSource = null;
            List<LeaveRequest> leaveRequests = leaveRequestRepository.GetAllLeaveRequests();
            leaveRequestsDataGridView.DataSource = leaveRequests;
        }


        

        private void tabPageLeaveRequests_Enter(object sender, EventArgs e)
        {
            LoadLeaveRequests();
        }
        private void empManage_Click(object sender, EventArgs e)
        {
            // Add code for managing employees
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            // Add code for handling tab page clicks
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add code for handling cell content clicks
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(employeeRepository);
            addEmployeeForm.FormClosed += AddEmployeeForm_FormClosed;
            addEmployeeForm.ShowDialog();
        }

        private void dataGridViewEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEmployees.Rows[e.RowIndex];

                Employee selectedEmployee = (Employee)row.DataBoundItem;

                MessageBox.Show($"Employee ID: {selectedEmployee.Id}\nName: {selectedEmployee.Name}\nDepartment: {selectedEmployee.Department}\nContact Info: {selectedEmployee.ContactInfo}", "Employee Details");
            }
        }

        private void AddEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadEmployeeData();
            LoadEmployeeList();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                Employee selectedEmployee = (Employee)dataGridViewEmployees.SelectedRows[0].DataBoundItem;

                string newName = Prompt.ShowDialog("Enter the new name:", "Edit Employee", selectedEmployee.Name);
                string newDepartment = Prompt.ShowDialog("Enter the new department:", "Edit Employee", selectedEmployee.Department);
                string newContactInfo = Prompt.ShowDialog("Enter the new contact info:", "Edit Employee", selectedEmployee.ContactInfo);

                selectedEmployee.Name = newName;
                selectedEmployee.Department = newDepartment;
                selectedEmployee.ContactInfo = newContactInfo;

                LoadEmployeeData();
                LoadEmployeeList();
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }

        private void rmvBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                Employee selectedEmployee = (Employee)dataGridViewEmployees.SelectedRows[0].DataBoundItem;

                DialogResult result = MessageBox.Show($"Are you sure you want to remove {selectedEmployee.Name}?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    employeeRepository.RemoveEmployee(selectedEmployee.Id);
                    LoadEmployeeData();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to remove.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add code for handling cell content clicks
        }

        private void reject_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void editRequestsBtn_Click_1(object sender, EventArgs e)
        {
            if (leaveRequestsDataGridView.SelectedRows.Count > 0)
            {

                LeaveRequest selectedLeaveRequest = (LeaveRequest)leaveRequestsDataGridView.SelectedRows[0].DataBoundItem;


                string newStartDate = Prompt.ShowDialog("Enter the new start date:", "Edit Leave Request", selectedLeaveRequest.StartDate.ToShortDateString());
                string newEndDate = Prompt.ShowDialog("Enter the new end date:", "Edit Leave Request", selectedLeaveRequest.EndDate.ToShortDateString());
                string newReason = Prompt.ShowDialog("Enter the new reason:", "Edit Leave Request", selectedLeaveRequest.Reason);

                selectedLeaveRequest.StartDate = DateTime.Parse(newStartDate);
                selectedLeaveRequest.EndDate = DateTime.Parse(newEndDate);
                selectedLeaveRequest.Reason = newReason;

                LoadLeaveRequests();
            }
            else
            {
                MessageBox.Show("Please select a leave request to edit.");
            }
        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in leaveRequestsDataGridView.Rows)
            {
                DataGridViewComboBoxCell statusCell = row.Cells["Status"] as DataGridViewComboBoxCell;

                if (statusCell != null && statusCell.Value != null)
                {
                    
                    LeaveRequestStatus selectedStatus;
                    if (Enum.TryParse(statusCell.Value.ToString(), out selectedStatus))
                    {
                        Guid leaveRequestId = (Guid)row.Cells["EmployeeId"].Value;
                        leaveRequestRepository.UpdateLeaveRequestStatus(leaveRequestId, selectedStatus);
                    }
                }
            }

            LoadLeaveRequests();
        }

        private void updateDataBtn_Click(object sender, EventArgs e)
        {
            List<LeaveRequest> requestsToRemove = new List<LeaveRequest>();

            foreach (LeaveRequest request in leaveRequestRepository.GetAllLeaveRequests())
            {
                if (request.Status == LeaveRequestStatus.Accepted || request.Status == LeaveRequestStatus.Rejected)
                {
                    requestsToRemove.Add(request);
                }
            }

            foreach (LeaveRequest requestToRemove in requestsToRemove)
            {
                leaveRequestRepository.RemoveLeaveRequest(requestToRemove.EmployeeId);
            }

            LoadLeaveRequests();
        }

        private void calculateSalaryBtn_Click(object sender, EventArgs e)
        {
            LoadEmployeeList();
            if (listBoxEmployees.SelectedIndex != -1)
            {
                int selectedIndex = listBoxEmployees.SelectedIndex;
                Employee selectedEmployee = employees[selectedIndex];
                
                decimal salary = selectedEmployee.HourlyWage * selectedEmployee.HoursWorked;
                MessageBox.Show($"Salary for {selectedEmployee.Name}: {salary.ToString("C")}");
            }
        }

        private void changeHourlyWageBtn_Click(object sender, EventArgs e)
        {
            LoadEmployeeList();
            if (listBoxEmployees.SelectedIndex != -1)
            {
                int selectedIndex = listBoxEmployees.SelectedIndex;
                Employee selectedEmployee = employees[selectedIndex];

                string newHourlyWageString = Prompt.ShowDialog("Enter the new hourly wage:", "Change Hourly Wage", selectedEmployee.HourlyWage.ToString());
                if (decimal.TryParse(newHourlyWageString, out decimal newHourlyWage))
                {
                    selectedEmployee.HourlyWage = newHourlyWage;
                    MessageBox.Show($"Hourly wage for {selectedEmployee.Name} changed to {newHourlyWage.ToString("C")}");
                }
                else
                {
                    MessageBox.Show("Invalid input for hourly wage. Please enter a valid numeric value.");
                }
            }
        }
        private void listBoxEmployees_DoubleClick(object sender, EventArgs e)
        {
            LoadEmployeeList();
            if (listBoxEmployees.SelectedIndex != -1)
            {
                int selectedIndex = listBoxEmployees.SelectedIndex;
                Employee selectedEmployee = employees[selectedIndex];

                MessageBox.Show($"Employee ID: {selectedEmployee.Id}\nName: {selectedEmployee.Name}\nDepartment: {selectedEmployee.Department}\nContact Info: {selectedEmployee.ContactInfo}\nHourly Wage: {selectedEmployee.HourlyWage.ToString("C")}\n Hours Woked: {selectedEmployee.HoursWorked.ToString("C")}", "Employee Details");
            }
        }
    }
}
