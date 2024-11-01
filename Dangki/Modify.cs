using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dangki
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand; //dùng để truy vấn các câu lệnh insert, update,...
        SqlDataReader dataReader; //dùng để đọc dữ liệu trong bảng
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taikhoanS = new List<TaiKhoan>();

            using (SqlConnection sqlConnection = Connection.GetSQqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taikhoanS.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                } 
                    
                sqlConnection.Close();
            }
            return taikhoanS;
        }
    }
}
