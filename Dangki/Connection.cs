using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
namespace Dangki
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-IFJSRH7\KNGA;Initial Catalog=DESKTOP-IFJSRH7\KNGA;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public static SqlConnection GetSQqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
