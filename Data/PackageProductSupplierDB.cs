using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class PackageProductSupplierDB
    {
        public static List<PackageProductSupplier> GetAllPackageProductSuppliers()
        {
            List<PackageProductSupplier> ppsList = new List<PackageProductSupplier>();
            PackageProductSupplier pps;

            // create connection
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // create SELECT command
            string query = "SELECT PackageId, ProductSupplierId "
                            + "From Packages_Products_Suppliers " +
                           "ORDER BY PackageId";
            SqlCommand cmd = new SqlCommand(query, connection);

            // run the SELECT query

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            // build ProductSupplier object to return
            while (reader.Read()) // if there is a ProductSupplier with this ID
            {
                pps = new PackageProductSupplier();
                pps.PackageId = (int)reader["PackageId"];
                pps.ProductSupplierId = (int)reader["ProductSupplierId"];
                
                ppsList.Add(pps);

            }

            return ppsList;
        }
    }
}
