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
    public partial class coverPage : Form
    {
        private DataBaseHelper dbHelper;
        public coverPage()
        {
            InitializeComponent();
            dbHelper = new DataBaseHelper();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------------------------Executes the login process--------------------------------------------------------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            // Validate fields
            string errorMessage = ValidateFields();
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string userName = LoginUserName.Text;
            string password = LoginPassword.Text;
            // Check if the username and password match admin credentials
            bool isAdmin = userName == "admin" && password == "admin123";
            // Check if the username and password match registered user credentials
            bool isRegisteredUser = dbHelper.IsRegisteredUser(userName, password);
            if (isAdmin)
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
            }
            else if (isRegisteredUser)
            {
                CustomerDasboard C1 = new CustomerDasboard();
                C1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Validates fields and returning  error messages .
        private string ValidateFields()
        {
            if (string.IsNullOrEmpty(LoginUserName.Text))
            {
                return "Please enter a Username.";
            }
            else if (string.IsNullOrEmpty(LoginPassword.Text))
            {
                return "Please enter a password.";
            }
            return ""; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoginPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoginUserName_TextChanged(object sender, EventArgs e)
        {

        }
        //This will open the Register form and hide the current form.
        private void LoginRegister_Click_1(object sender, EventArgs e)
        {
            try
            {
                Register R1 = new Register();
                R1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        // Exit the application
        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}