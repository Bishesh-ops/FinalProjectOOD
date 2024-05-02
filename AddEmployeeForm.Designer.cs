namespace FinalProject
{
    partial class AddEmployeeForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this._Name = new System.Windows.Forms.Label();
            this.ADepartment = new System.Windows.Forms.Label();
            this.Contact_Info = new System.Windows.Forms.Label();
            this.hourlyWage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hoursWorked = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(190, 107);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 26);
            this.txtDepartment.TabIndex = 2;
            this.txtDepartment.TextChanged += new System.EventHandler(this.txtDepartment_TextChanged);
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(190, 139);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(100, 26);
            this.txtContactInfo.TabIndex = 3;
            this.txtContactInfo.TextChanged += new System.EventHandler(this.txtContactInfo_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(190, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // _Name
            // 
            this._Name.AutoSize = true;
            this._Name.Location = new System.Drawing.Point(101, 75);
            this._Name.Name = "_Name";
            this._Name.Size = new System.Drawing.Size(83, 20);
            this._Name.TabIndex = 5;
            this._Name.Text = "Username";
            // 
            // ADepartment
            // 
            this.ADepartment.AutoSize = true;
            this.ADepartment.Location = new System.Drawing.Point(90, 107);
            this.ADepartment.Name = "ADepartment";
            this.ADepartment.Size = new System.Drawing.Size(94, 20);
            this.ADepartment.TabIndex = 6;
            this.ADepartment.Text = "Department";
            this.ADepartment.Click += new System.EventHandler(this.Department_Click);
            // 
            // Contact_Info
            // 
            this.Contact_Info.AutoSize = true;
            this.Contact_Info.Location = new System.Drawing.Point(90, 139);
            this.Contact_Info.Name = "Contact_Info";
            this.Contact_Info.Size = new System.Drawing.Size(97, 20);
            this.Contact_Info.TabIndex = 8;
            this.Contact_Info.Text = "Contact Info";
            // 
            // hourlyWage
            // 
            this.hourlyWage.Location = new System.Drawing.Point(190, 171);
            this.hourlyWage.Name = "hourlyWage";
            this.hourlyWage.Size = new System.Drawing.Size(100, 26);
            this.hourlyWage.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hours Worked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hourly Wage";
            // 
            // hoursWorked
            // 
            this.hoursWorked.Location = new System.Drawing.Point(190, 203);
            this.hoursWorked.Name = "hoursWorked";
            this.hoursWorked.Size = new System.Drawing.Size(100, 26);
            this.hoursWorked.TabIndex = 12;
            this.hoursWorked.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 410);
            this.Controls.Add(this.hoursWorked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourlyWage);
            this.Controls.Add(this.Contact_Info);
            this.Controls.Add(this.ADepartment);
            this.Controls.Add(this._Name);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtName);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label _Name;
        private System.Windows.Forms.Label ADepartment;
        private System.Windows.Forms.Label Contact_Info;
        private System.Windows.Forms.TextBox hourlyWage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hoursWorked;
    }
}