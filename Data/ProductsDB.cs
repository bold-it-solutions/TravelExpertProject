using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Data

{
    public static class ProductsDB
    {
        //public static SqlConnection GetConnection()
        //    {
        //    string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog = TravelExperts; Integrated Security = True";
        //    //@ allows you to put the entire path
        //    //regardless of special characters
        //    return new SqlConnection(connectionString);
        //    }

        public static List<Product> GetProducts()  //name in <> has to match a class name
        {
            List<Product> product = new List<Product>();  //empty list
            Product prod;  //for reading

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT ProductID, ProdName " +
                                "From Products " + //name in sqlserver database
                               "ORDER BY ProductID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    // build product object to return
                    while (reader.Read())
                    {
                        prod = new Product();//empty
                        prod.ProductID = (int)reader["ProductID"];//fill with data from the reader
                        prod.ProdName = reader["ProdName"].ToString();
                        product.Add(prod); //adds prod to list
                    }
                }//cmd object recycled
            }
            return product;

        }


        //add product
        public static int AddNewProduct(Product p)
        {
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "insert into Products(ProdName) values(@ProductName)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductName", p.ProdName);

                    connection.Open();
                    int productID = (int)cmd.ExecuteNonQuery();

                    if (productID > 0)
                        return productID;
                    else return -1;
                }
            }
        }
        //archive/delete product
        //public static void DeleteProduct(Product p)
        //{
        //    using (SqlConnection connection = TravelExpertsDB.GetConnection())
        //    {
        //        string query = "delete from Products Products(ProdName) values(@ProductName)";
        //            using (SqlCommand cmd = new SqlCommand(query, connection))
        //        {
        //            connection.Open();
        //            cmd.Parameters.RemoveAt("@ProductName", p.ProdName);

        //            string ProductName= string cmd.ExecuteNonQuery();

        //            if (productID > 0)
        //                return productID;
        //            else return -1;
        //        }
        //    }
        //}
    }

}