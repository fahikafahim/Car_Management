using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OrderDetails : Form
    {
        // Create objects  interact with the database.
        private PlaceOrderDatabase dbHelper = new PlaceOrderDatabase();
        private DataTable table;
        // Constructor for the Oder form. Sets up the form and loads data
        public OrderDetails()
        {
            InitializeComponent();
            InitializeDataTable();
            OderData();
        }
        // Set up the DataTable for displaying booked oder data in the DataGridView.
        private void InitializeDataTable()
        {
            table = new DataTable("OderTable");
            table.Columns.Add("CusName");
            table.Columns.Add("ContactNo");
            table.Columns.Add("Pick Location");
            table.Columns.Add("CarPlateNo");
            table.Columns.Add("DriverContactNo");
            table.Columns.Add("DropLocation");
        
            dataGridView1.DataSource = table;
        }
        //---------------------------------------------------------Load Oder data from the database into the DataTable---------------------------------------------------------------------//
        private void OderData()
        {
            table.Clear();
            List<place_oder> orders = dbHelper.LoadOrders();
            foreach (place_oder order in orders)
            {
                table.Rows.Add(
                    order.cus_name,
                    order.cus_contact_no,
                    order.location,
                    order.plate_no,
                    order.driver_contact_no,
                    order.drop_location
                   
                );
            }
        }

        // Exit the application
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //This will open the AdminDashboard form and hide the current form.
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                AdminDashboard C1 = new AdminDashboard();
                C1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        //This will open the coverPage form and hide the current form.
        private void button5_Click(object sender, EventArgs e)
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
    }
}
