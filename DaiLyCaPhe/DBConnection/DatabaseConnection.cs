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
        private static string _connectionString = "Data Source=localhost;Initial Catalog=DaiLyCaPhe; User ID =sa; Password=1234";

        public static string GetBeanTypeIdByNameAndOrigin(string beanName, string beanOrigin)
        {
            string data = "";
            string query = "SELECT MaLoaiHat FROM LoaiHatCaPhe WHERE TenLoaiHat LIKE @beanName AND XuatXu LIKE @beanOrigin";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@beanName", beanName));
                command.Parameters.Add(new SqlParameter("@beanOrigin", beanOrigin));
                object obj = command.ExecuteScalar();
                data = obj == null? "" : obj.ToString();
            }
            return data;
        }

        public static DataTable GetBillDetails(string billID)
        {
            string query = "SELECT DISTINCT LH.TenLoaiHat, LH.XuatXu, L.NgaySanXuat, SoLuong, C.DonGia " +
                            "FROM ChiTietPhieuNhap C, LoaiHatCaPhe LH, LoHang L " +
                            "WHERE C.MaLoaiHat = LH.MaLoaiHat AND " +
                            "C.SoLoHang = L.SoLoHang AND " +
                            "L.MaLoaiHat = C.MaLoaiHat AND  " +
                            "MaPhieuNhap = @billID";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@billID", billID));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    if(reader.HasRows)
                    {
                        dataTable.Load(reader);
                        return dataTable;
                    }
                    return null;
                }
            }
        }

        public static string GetBillByID(string billID)
        {
            string query = "SELECT MaPhieuNhap FROM PhieuNhapHang WHERE MaPhieuNhap = @billID";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@billID", billID));
                object obj = command.ExecuteScalar();
                string id = obj == null ? "" : obj.ToString();
                return id;
            }
        }
    }
}
