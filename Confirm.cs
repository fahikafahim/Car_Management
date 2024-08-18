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
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //This will open the CustomerDasboard form and hide the current form.
        private void ConfirmOderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDasboard C1 = new CustomerDasboard();
                C1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        // Exit the application
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
