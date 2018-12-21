using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Projectpro
{
    public class DataUtilities
    {
        public static SqlConnection getConnect()
        {
            string conStr = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection connection = new SqlConnection(conStr);
            return connection;
        }
    }
}