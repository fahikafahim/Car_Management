using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VeiwAvailableCars : Form
    {
        // Create objects to  interact with the database.
        private DataBaseHelper dbHelper = new DataBaseHelper();
        private DataTable table;


        public VeiwAvailableCars()
        {
            InitializeComponent();
            InitializeDataTable();
            LoadCarData();
           
        }
        // Set up the DataTable for displaying car data in the DataGridView.
        private void InitializeDataTable()
        {
            table = new DataTable("CarTable");
            table.Columns.Add("Plate No");
            table.Columns.Add("Car Model");
            table.Columns.Add("Color");
            dataGridView2.DataSource = table;
        }
        // Exit the application
        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //This will open the CustomerDasboard form and hide the current form.
        private void label3_Click(object sender, EventArgs e)
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
        //This will open the CustomerDasboard form and hide the current form.
        private void pictureBox1_Click(object sender, EventArgs e)
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
        //---------------------------------------------------------Load car data from the database into the DataTable---------------------------------------------------------------------//
        private void LoadCarData()
        {
            table.Clear();
            List<car_managment> cars = dbHelper.LoadCar();
            foreach (car_managment car in cars)
            {
                if (car.availibility == "True")
                {
                    table.Rows.Add(car.plate_no, car.car_model, car.car_color);
                }
            }
        }

        private void DataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //This will open the CustomerDasboard form and hide the current form.
        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDasboard A1 = new CustomerDasboard();
                A1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        //This will open the CustomerDasboard form and hide the current form.
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDasboard A1 = new CustomerDasboard();
                A1.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
        }
        // Properties for getting and setting text in text boxes.
        public string TextBox1Text
        {
            get { return Noplate.Text; }
            set { Noplate.Text = value; }
        }

        public string TextBox2Text
        {
            get { return Carcolor.Text; }
            set { Carcolor.Text = value; }
        }
        public string TextBox3Text
        {
            get { return Carmodel.Text; }
            set { Carmodel.Text = value; }
        }
        private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                TextBox1Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                TextBox2Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                TextBox3Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
              
            }
        }

        private void VeiwAvailableCars_Load(object sender, EventArgs e)
        {
        }

        private void ConfirmOderBtn_Click(object sender, EventArgs e)
        {
               try
                {
                if (string.IsNullOrEmpty(Noplate.Text) || string.IsNullOrEmpty(Carcolor.Text) || string.IsNullOrEmpty(Carmodel.Text))
                {
                    throw new Exception("Please enter car details before proceeding.");
                }

                VeiwAvailableDrivers driverForm = Application.OpenForms.OfType<VeiwAvailableDrivers>().FirstOrDefault();

                   
                    if (driverForm == null)
                    {
                        throw new Exception("Driver selection form is not open.");
                    }

                  
                      string DriverName = driverForm?.TextBox1Text;
                      string DriverID = driverForm?.TextBox2Text;
                     string ContactNo = driverForm?.TextBox3Text;

                if (string.IsNullOrEmpty(DriverName) || string.IsNullOrEmpty(DriverID) || string.IsNullOrEmpty(ContactNo))
                {
                    throw new Exception("Please select a driver before proceeding.");
                }
                
                Oder placeOrderForm = new Oder(DriverName, DriverID, ContactNo, Noplate.Text, Carcolor.Text, Carmodel.Text);
                placeOrderForm.Show();
                this.Close();

            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

        private void Carcolor_Click(object sender, EventArgs e)
        {

        }

        private void Noplate_Click(object sender, EventArgs e)
        {

        }
    }
}
