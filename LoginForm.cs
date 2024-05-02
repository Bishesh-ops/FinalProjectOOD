using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            password.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = "admin";
                string Epassword = "password";

                string enteredUsername = userName.Text;
                string enteredPassword = password.Text;

                if (enteredUsername == username && enteredPassword == Epassword)
                {
                    this.Hide();
                    HomePage homepage = new HomePage();
                    homepage.Show();               
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
