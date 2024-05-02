namespace FinalProject
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.payroll = new System.Windows.Forms.TabPage();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.calculateSalaryBtn = new System.Windows.Forms.Button();
            this.changeHourlyWageBtn = new System.Windows.Forms.Button();
            this.leaveReq = new System.Windows.Forms.TabPage();
            this.leaveRequestsDataGridView = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.submitBtn = new System.Windows.Forms.Button();
            this.editRequestsBtn = new System.Windows.Forms.Button();
            this.updateDataBtn = new System.Windows.Forms.Button();
            this.empManage = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.rmvBtn = new System.Windows.Forms.Button();
            this.EmployeeManager = new System.Windows.Forms.TabControl();
            this.payroll.SuspendLayout();
            this.leaveReq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveRequestsDataGridView)).BeginInit();
            this.empManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.EmployeeManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // payroll
            // 
            this.payroll.Controls.Add(this.changeHourlyWageBtn);
            this.payroll.Controls.Add(this.calculateSalaryBtn);
            this.payroll.Controls.Add(this.listBoxEmployees);
            this.payroll.Location = new System.Drawing.Point(4, 29);
            this.payroll.Name = "payroll";
            this.payroll.Padding = new System.Windows.Forms.Padding(3);
            this.payroll.Size = new System.Drawing.Size(725, 404);
            this.payroll.TabIndex = 2;
            this.payroll.Text = "Payroll Processer";
            this.payroll.UseVisualStyleBackColor = true;
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 20;
            this.listBoxEmployees.Location = new System.Drawing.Point(6, 6);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(320, 144);
            this.listBoxEmployees.TabIndex = 0;
            // 
            // calculateSalaryBtn
            // 
            this.calculateSalaryBtn.Location = new System.Drawing.Point(6, 156);
            this.calculateSalaryBtn.Name = "calculateSalaryBtn";
            this.calculateSalaryBtn.Size = new System.Drawing.Size(160, 40);
            this.calculateSalaryBtn.TabIndex = 1;
            this.calculateSalaryBtn.Text = "Calculate Salary";
            this.calculateSalaryBtn.UseVisualStyleBackColor = true;
            this.calculateSalaryBtn.Click += new System.EventHandler(this.calculateSalaryBtn_Click);
            // 
            // changeHourlyWageBtn
            // 
            this.changeHourlyWageBtn.Location = new System.Drawing.Point(332, 6);
            this.changeHourlyWageBtn.Name = "changeHourlyWageBtn";
            this.changeHourlyWageBtn.Size = new System.Drawing.Size(160, 40);
            this.changeHourlyWageBtn.TabIndex = 2;
            this.changeHourlyWageBtn.Text = "Change Wage";
            this.changeHourlyWageBtn.UseVisualStyleBackColor = true;
            this.changeHourlyWageBtn.Click += new System.EventHandler(this.changeHourlyWageBtn_Click);
            // 
            // leaveReq
            // 
            this.leaveReq.Controls.Add(this.updateDataBtn);
            this.leaveReq.Controls.Add(this.editRequestsBtn);
            this.leaveReq.Controls.Add(this.submitBtn);
            this.leaveReq.Controls.Add(this.leaveRequestsDataGridView);
            this.leaveReq.Location = new System.Drawing.Point(4, 29);
            this.leaveReq.Name = "leaveReq";
            this.leaveReq.Padding = new System.Windows.Forms.Padding(3);
            this.leaveReq.Size = new System.Drawing.Size(725, 404);
            this.leaveReq.TabIndex = 1;
            this.leaveReq.Text = "Leave Requests";
            this.leaveReq.UseVisualStyleBackColor = true;
            // 
            // leaveRequestsDataGridView
            // 
            this.leaveRequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaveRequestsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status});
            this.leaveRequestsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.leaveRequestsDataGridView.Name = "leaveRequestsDataGridView";
            this.leaveRequestsDataGridView.RowHeadersWidth = 62;
            this.leaveRequestsDataGridView.RowTemplate.Height = 28;
            this.leaveRequestsDataGridView.Size = new System.Drawing.Size(725, 150);
            this.leaveRequestsDataGridView.TabIndex = 0;
            this.leaveRequestsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Items.AddRange(new object[] {
            "Pending",
            "Accepted",
            "Rejected"});
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(6, 157);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(153, 34);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click_1);
            // 
            // editRequestsBtn
            // 
            this.editRequestsBtn.Location = new System.Drawing.Point(566, 157);
            this.editRequestsBtn.Name = "editRequestsBtn";
            this.editRequestsBtn.Size = new System.Drawing.Size(153, 34);
            this.editRequestsBtn.TabIndex = 4;
            this.editRequestsBtn.Text = "Edit";
            this.editRequestsBtn.UseVisualStyleBackColor = true;
            this.editRequestsBtn.Click += new System.EventHandler(this.editRequestsBtn_Click_1);
            // 
            // updateDataBtn
            // 
            this.updateDataBtn.Location = new System.Drawing.Point(330, 156);
            this.updateDataBtn.Name = "updateDataBtn";
            this.updateDataBtn.Size = new System.Drawing.Size(75, 35);
            this.updateDataBtn.TabIndex = 5;
            this.updateDataBtn.Text = "Update";
            this.updateDataBtn.UseVisualStyleBackColor = true;
            this.updateDataBtn.Click += new System.EventHandler(this.updateDataBtn_Click);
            // 
            // empManage
            // 
            this.empManage.Controls.Add(this.rmvBtn);
            this.empManage.Controls.Add(this.editBtn);
            this.empManage.Controls.Add(this.btnAddEmployee);
            this.empManage.Controls.Add(this.dataGridViewEmployees);
            this.empManage.Location = new System.Drawing.Point(4, 29);
            this.empManage.Name = "empManage";
            this.empManage.Padding = new System.Windows.Forms.Padding(3);
            this.empManage.Size = new System.Drawing.Size(725, 404);
            this.empManage.TabIndex = 0;
            this.empManage.Text = "Employee Management";
            this.empManage.UseVisualStyleBackColor = true;
            this.empManage.Click += new System.EventHandler(this.empManage_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 62;
            this.dataGridViewEmployees.RowTemplate.Height = 28;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(719, 218);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(6, 227);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(189, 29);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add New Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(7, 263);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(188, 31);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit Employee Details";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // rmvBtn
            // 
            this.rmvBtn.Location = new System.Drawing.Point(7, 301);
            this.rmvBtn.Name = "rmvBtn";
            this.rmvBtn.Size = new System.Drawing.Size(188, 33);
            this.rmvBtn.TabIndex = 3;
            this.rmvBtn.Text = "Remove Employee";
            this.rmvBtn.UseVisualStyleBackColor = true;
            this.rmvBtn.Click += new System.EventHandler(this.rmvBtn_Click);
            // 
            // EmployeeManager
            // 
            this.EmployeeManager.Controls.Add(this.empManage);
            this.EmployeeManager.Controls.Add(this.leaveReq);
            this.EmployeeManager.Controls.Add(this.payroll);
            this.EmployeeManager.Location = new System.Drawing.Point(13, 13);
            this.EmployeeManager.Name = "EmployeeManager";
            this.EmployeeManager.SelectedIndex = 0;
            this.EmployeeManager.Size = new System.Drawing.Size(733, 437);
            this.EmployeeManager.TabIndex = 0;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.EmployeeManager);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.payroll.ResumeLayout(false);
            this.leaveReq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leaveRequestsDataGridView)).EndInit();
            this.empManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.EmployeeManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage payroll;
        private System.Windows.Forms.Button changeHourlyWageBtn;
        private System.Windows.Forms.Button calculateSalaryBtn;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.TabPage leaveReq;
        private System.Windows.Forms.Button updateDataBtn;
        private System.Windows.Forms.Button editRequestsBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.DataGridView leaveRequestsDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.TabPage empManage;
        private System.Windows.Forms.Button rmvBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.TabControl EmployeeManager;
    }
}