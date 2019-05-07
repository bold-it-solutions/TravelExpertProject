using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class ProductSupplierDB
    {
        public static List<ProductSupplier> GetAllProductSuppliers()
        {
            List<ProductSupplier> psList = new List<ProductSupplier>();
            ProductSupplier ps;

            // create connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // create SELECT command
            string query = "SELECT ProductSupplierId, ProductId, SupplierId "
                            + "From Products_Suppliers " +
                           "ORDER BY ProductSupplierId";
            SqlCommand cmd = new SqlCommand(query, connection);

            // run the SELECT query

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // build ProductSupplier object to return
            while (reader.Read()) // if there is a ProductSupplier with this ID
            {
                ps = new ProductSupplier();
                ps.ProductSupplierId = (int)reader["ProductSupplierId"];
                ps.ProductId = (int)reader["ProductId"];
                ps.SupplierId = (int)reader["SupplierId"];
                psList.Add(ps);

            }

            return psList;
        }
    }
}
