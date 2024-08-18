using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VeiwAvailableDrivers : Form
    {
        // Create objects to  interact with the database.
        private DriverDataBaseHelper dbHelper = new DriverDataBaseHelper();
        private DataTable table;
        public VeiwAvailableDrivers()
        {
            InitializeComponent();
            InitializeDataTable();
            LoadDriverData();
        }
        // Set up the DataTable for displaying car data in the DataGridView.
        private void InitializeDataTable()
        {
            table = new DataTable("DriverTable");
            table.Columns.Add("Driver Name");
            table.Columns.Add("Driver ID");
            table.Columns.Add("Driver Contact No");
            dataGridView1.DataSource = table;
        }
        //---------------------------------------------------------Load Driver data from the database into the DataTable---------------------------------------------------------------------//

        private void LoadDriverData()
        {
            table.Clear();
            List<driver_managment> drivers = dbHelper.LoadDriver();
            foreach (driver_managment driver in drivers)
            {
                table.Rows.Add(driver.Name, driver.Id, driver.TelephoneNo);
            }
        }
        // Exit the application
        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CustomerDasboard A1 = new CustomerDasboard();
            A1.Show();
            this.Hide();
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        // Properties for getting and setting text in text boxes.
        public string TextBox1Text
        {
            get { return DriverName.Text; }
            set { DriverName.Text = value; }
        }

        public string TextBox2Text
        {
            get { return DriverID.Text; }
            set { DriverID.Text = value; }
        }

        public string TextBox3Text
        {
            get { return ContactNo.Text; }
            set { ContactNo.Text = value; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                TextBox1Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TextBox2Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TextBox3Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                // Ensure the form is hidden before showing it as a dialog
                this.Hide();

                // After dialog is closed, show the form again
                this.Show();
            }

        }

        private void ConfirmOderBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DriverName.Text) || string.IsNullOrWhiteSpace(DriverID.Text) || string.IsNullOrWhiteSpace(ContactNo.Text))
            {
                MessageBox.Show("Please Select a driver details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VeiwAvailableDrivers carForm = Application.OpenForms.OfType<VeiwAvailableDrivers>().FirstOrDefault();
            string Noplate = carForm?.TextBox1Text;
            string Carcolor = carForm?.TextBox2Text;
            string Carmodel = carForm?.TextBox3Text;
        
            VeiwAvailableCars A1 = new VeiwAvailableCars();
            A1.Show();
            this.Hide();
        }

       
       
        private void VeiwAvailableDrivers_Load(object sender, EventArgs e)
        {

        }

        private void DriverID_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
