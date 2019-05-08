using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;

namespace Data
{

    public static class SuppliersDB
    {
        //public static int SupplierId { get; private set; }

        //public static SqlConnection GetConnection()  //method which needs a call and return  
        //    //this will be called in the StateDB (when connection needs to be made)
        //{
        //    string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog = TravelExperts; Integrated Security = True";  
        //    //@ allows you to put the entire path 
        //    //regardless of special characters
        //    return new SqlConnection(connectionString);
        //}

        public static List<Supplier> GetAllSuppliers()  //name in <> has to match a class name
        {
            List<Supplier> supplier = new List<Supplier>();  //empty list
            Supplier sup;  //for reading

            using (SqlConnection connection = TravelExpertsDB.GetConnection())

            {
                string query = "SELECT SupplierID, SupName " +
                               "FROM Suppliers " +
                               "ORDER by SupplierID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        sup = new Supplier(); //empty supplier object
                        //fill with data from the reader
                        sup.SupplierId = (int)reader["SupplierId"];
                        sup.SupName = reader["SupName"].ToString(); ;
                        supplier.Add(sup);  //add to the list
                    }
                } //cmd object recycled
            }//connection object recycled

            return supplier;

            //-----------------------
        }
        //add supplier
        public static int AddSupplier(Supplier sup)
        {
            // create connection
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // create INSERT command
                // SupplierID is IDENTITY so no value provided
                string query = "insert into Suppliers(SupplierId, SupName) values(@SupplierId, @SupName)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                //string insertStatement =
                //"INSERT INTO Suppliers(SupplierId, SupName ) " +
                //"OUTPUT inserted.SupplierId " +
                //"VALUES(@SupplierId, @SupName)";
                //SqlCommand cmd = new SqlCommand(insertStatement, connection);
                //cmd.Parameters.AddWithValue("@SupplierId", sup.SupplierId);

                {
                    cmd.Parameters.AddWithValue(" @SupName", sup.SupName);
                    //cmd.Parameters.AddWithValue("@SupplierId");
                    connection.Open();

                    // execute insert command and get inserted ID
                    int SupplierId = (int)cmd.ExecuteNonQuery();

                    if (SupplierId > 0)
                        return SupplierId;
                    else return -1;

                    // retrieve generate customer ID to return
                    //string selectStatement =
                    //   "SELECT IDENT_CURRENT('Suppliers')";
                    // SqlCommand selectCmd = new SqlCommand(selectStatement, connection);
                    // SupplierId = Convert.ToInt32(selectCmd.ExecuteScalar()); // returns single value
                    //         // (int) does not work in this case
                }
                //catch (Exception ex)
                //{
                //    throw ex;
                //}
                //finally
                //{
                //    connection.Close();
                //}
            }
            //return custID;
        }


        //public static bool DeleteSupplier(Supplier sup)
        //{
        //    bool success = false;

        //    // create connection
        //    using (SqlConnection connection = TravelExpertsDB.GetConnection())
        //    {

        //        // create DELETE command
        //        string deleteStatement =
        //        "DELETE FROM Suppliers " +
        //        "WHERE SupplierID = @SupplierID " + // needed for identification
        //        "AND SupName = @SupName "; // the rest - for optimistic concurrency

        //        SqlCommand cmd = new SqlCommand(deleteStatement, connection);
        //        cmd.Parameters.AddWithValue("@SupplierId", sup.SupplierId);
        //        cmd.Parameters.AddWithValue("@SupName", sup.SupName);

        //        try
        //        {
        //            connection.Open();

        //            // execute the command
        //            int count = cmd.ExecuteNonQuery();
        //            // check if successful
        //            if (count > 0)
        //                success = true;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }
        //    return success;
        //}
    }


}




