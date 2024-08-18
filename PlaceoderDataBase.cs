
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class PlaceOrderDatabase
    {
        private string ConnectionString { get; }

        public PlaceOrderDatabase()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        //---------------------------------------------------------------------- Inserting Order Data into Database ----------------------------------------------------------------------------------
        public bool InsertOrder(place_oder order)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    string sql = "INSERT INTO Place_oder (CusName, ContactNo, Location, CarPlateNo, DriverContactNo, DropLocation) VALUES (@CusName, @ContactNo, @Location, @CarPlateNo, @DriverContactNo, @DropLocation)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@CusName", order.cus_name);
                        cmd.Parameters.AddWithValue("@ContactNo", order.cus_contact_no);
                        cmd.Parameters.AddWithValue("@Location", order.location);
                        cmd.Parameters.AddWithValue("@CarPlateNo", order.plate_no);
                        cmd.Parameters.AddWithValue("@DriverContactNo", order.driver_contact_no);
                        cmd.Parameters.AddWithValue("@DropLocation", order.drop_location);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        isSuccess = rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return isSuccess;
        }

        //------------------------------------------------------------------------- Loading Order Data from Database --------------------------------------------------------------------------------------
        public List<place_oder> LoadOrders()
        {
            List<place_oder> orders = new List<place_oder>();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT CusName, ContactNo, Location, CarPlateNo, DriverContactNo, DropLocation FROM Place_oder";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                place_oder order = new place_oder
                                {
                                    cus_name = reader["CusName"].ToString(),
                                    cus_contact_no = Convert.ToInt32(reader["ContactNo"]),
                                    location = reader["Location"].ToString(),
                                    plate_no = reader["CarPlateNo"].ToString(),
                                    driver_contact_no = Convert.ToInt32(reader["DriverContactNo"]),
                                    drop_location = reader["DropLocation"].ToString(),
                                };
                                orders.Add(order);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return orders;
        }
    }

    
}

