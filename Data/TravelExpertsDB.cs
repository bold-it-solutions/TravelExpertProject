using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            string connnectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=TravelExperts;Integrated Security=True";
            return new SqlConnection(connnectionString);
        }
    }
}
