using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DaiLyCaPhe.DBConnection
{
    public class DatabaseConnection
    {
        private string _connectionString = "Data Source=localhost;Initial Catalog=DaiLyCaPhe; User ID =sa; Password=1234";

        private DataTable getAllData(string tableName)
        {
            DataTable data = new DataTable();
            string queryString = "select * from @tableName";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand query = new SqlCommand(queryString, connection);
                query.Parameters.Add(new SqlParameter("@tableName", tableName));
                using ( SqlDataReader reader = query.ExecuteReader())
                {
                    data.Load(reader);
                }
            }
            return data;
        }
    }
}
