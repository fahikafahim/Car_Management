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
    public partial class Oder : Form
    {
        // Create objects oder details and interact with the database.
        private place_oder O1 = new place_oder();
        private PlaceOrderDatabase dbHelper = new PlaceOrderDatabase();

        public Oder()
        {
            InitializeComponent();
        }

        //---------------------------------------Constructor(View Available Driver) (View Available Car)-------------------------------------------------------------------------
        public Oder(string driverName, string driverID, string driverContactNo, string noplate, string carcolor, string carmodel)
        {
            InitializeComponent();

            Noplate.Text = noplate;
            Carcolor.Text = carcolor;
            Carmodel.Text = carmodel;
            DriverName.Text = driverName;
            DriverID.Text = driverID;
            DriverContactNo.Text = driverContactNo;
        }
        // Exit the application

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
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

        //-------------------------------------------------------------------Validate input fields and return error message if any field is invalid------------------------------------------//
        private string ValidateFields()
        {
            if (string.IsNullOrEmpty(cusName.Text))
            {
                return "Please enter Your Name.";
            }
            else if (string.IsNullOrEmpty(ContactNo.Text))
            {
                return "Please enter Contact Number.";
            }
            else if (string.IsNullOrEmpty(Location.Text))
            {
                return "Please enter the Location.";
            }
            else if (!int.TryParse(ContactNo.Text, out _))
            {
                return "Please enter a valid numeric Contact Number.";
            }

            else if (string.IsNullOrEmpty(Noplate.Text) || string.IsNullOrEmpty(Carcolor.Text) || string.IsNullOrEmpty(Carmodel.Text))
            {
                return "Please select a Available car.";
            }
            else if (string.IsNullOrEmpty(DriverID.Text) || string.IsNullOrEmpty(DriverName.Text) || string.IsNullOrEmpty(DriverContactNo.Text))
            {
                return "Please select a Available driver.";
            }
            else if (string.IsNullOrEmpty(DropLocation.Text))
            {
                return "Please enter the Drop Location.";
            }
           
            return "";
        }
        // Clear all input fields.
        private void ClearFields()
        {
            cusName.Text = "";
            ContactNo.Text = "";
            Location.Text = "";
            DropLocation.Text = "";
        }

        private void ConfirmOderBtn_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateFields();
            if (string.IsNullOrEmpty(errorMessage))
            {
                O1.cus_name = cusName.Text;
                O1.cus_contact_no = int.Parse(ContactNo.Text);
                O1.location = Location.Text;
                O1.plate_no = Noplate.Text;
                O1.driver_contact_no = int.Parse(DriverContactNo.Text);
                O1.drop_location = DropLocation.Text;

                bool success = dbHelper.InsertOrder(new place_oder
                {
                    cus_name = O1.cus_name,
                    cus_contact_no = O1.cus_contact_no,
                    location = O1.location,
                    plate_no = O1.plate_no,
                    driver_contact_no = O1.driver_contact_no,
                    drop_location = O1.drop_location
                });
                if (success)
                {
                    Confirm C1 = new Confirm();
                    C1.Show();
                    this.Hide();
                    ClearFields();

                }
                else
                {
                    MessageBox.Show("Failed to add Customer Detail.");
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
