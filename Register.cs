using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        // Create objects to register details and interact with the database.
        private register_1 cus = new register_1();
        private DataBaseHelper dbHelper = new DataBaseHelper();

        public Register()
        {
            InitializeComponent();
        }
        //This will open the coverPage form and hide the current form.
        private void LoginRegister_Click(object sender, EventArgs e)
        {
            try
            {
                coverPage F1 = new coverPage();
                F1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        // Exit the application
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Toggles password visibility based on the RegistercheckBox1 state.
        private void LogincheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegisterPassword.UseSystemPasswordChar = !RegistercheckBox1.Checked;
        }
        // Validates fields and returning  error messages .
        private string ValidateFields()
        {
            if (string.IsNullOrEmpty(RegisterUserName.Text))
            {
                return "Please enter a Username.";
            }
            else if (string.IsNullOrEmpty(RegisterEmail.Text))
            {
                return "Please enter an Email.";
            }
            else if (!IsValidEmail(RegisterEmail.Text))
            {
                return "Please enter a valid Email address.";
            }
            else if (string.IsNullOrEmpty(RegisterPassword.Text))
            {
                return "Please enter a password.";
            }
            return ""; 
        }
        // Checks if the given email address is valid.
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        // Handles registration and shows the customer dashboard.
        private void button1_Click_1(object sender, EventArgs e)
        {
            string errorMessage = ValidateFields();
            if (string.IsNullOrEmpty(errorMessage))
            {
               
                CustomerDasboard C1 = new CustomerDasboard();
                C1.Show();
                this.Hide();
                
                cus.User_name = RegisterUserName.Text;
                cus.Email = RegisterEmail.Text;
                cus.Password = RegisterPassword.Text;
                bool success = dbHelper.AddCustomer(cus);
                if (success)
                {
                    MessageBox.Show("New customer is added!");
                }
                else
                {
                    MessageBox.Show("Failed to add customer.");
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterUserName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
