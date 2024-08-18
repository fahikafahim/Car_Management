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
    public partial class CustomerDasboard : Form
    {
        public CustomerDasboard()
        {
            InitializeComponent();
        }
        //This will open the VeiwAvailableCars form and hide the current form.
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                VeiwAvailableCars V1 = new VeiwAvailableCars();
                V1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        //This will open the VeiwAvailableDrivers form and hide the current form.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VeiwAvailableDrivers V2 = new VeiwAvailableDrivers();
                V2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        //This will open the PlaceOder form and hide the current form.
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                VeiwAvailableDrivers P1 = new VeiwAvailableDrivers();
                P1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        //This will open the coverPage form and hide the current form.
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                coverPage C1 = new coverPage();
                C1.Show();
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
    }
}
