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
            string id;
            string query = "SELECT MaPhieuNhap FROM PhieuNhapHang WHERE MaPhieuNhap = @billID";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@billID", billID));
                object obj = command.ExecuteScalar();
                id = obj == null ? "" : obj.ToString();
            }
            return id;
        }

        public static string GetCategoryIDByBillID(string billID)
        {
            string id;
            string query = "select SoLoHang " +
                            "from ChiTietPhieuNhap " +
                            "where MaPhieuNhap = @billID ";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@billID", billID));
                object obj = command.ExecuteScalar();
                id = obj == null ? "" : obj.ToString();
            }
            return id;
        }

        public static int UpdateTableLoHang(string SoLoHang, string MaLoaiHat, DateTime NgaySanXuat, DateTime HanSuDung)
        {
            int rowAffected = 0;
            string updateCommand = "update LoHang " +
                                    "set NgaySanXuat = @ngaySanXuat, HanSuDung = @hanSuDung " +
                                    "where SoLoHang = @soLoHang and MaLoaiHat = @maLoaiHat";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateCommand, connection);
                command.Parameters.Add(new SqlParameter("@ngaySanXuat", NgaySanXuat));
                command.Parameters.Add(new SqlParameter("@hanSuDung", HanSuDung ));
                command.Parameters.Add(new SqlParameter("@soLoHang", SoLoHang));
                command.Parameters.Add(new SqlParameter("@maLoaiHat", MaLoaiHat));

                rowAffected = command.ExecuteNonQuery();                

            }
            return rowAffected;
        }

        public static int UpdateTableChiTietPhieuNhap(string MaPhieuNhap, string SoLoHang, string MaLoaiHat, decimal SoLuong, decimal DonGia)
        {
            int rowAffected = 0;
            string updateCommand = "update ChiTietPhieuNhap " +
                                    "set SoLuong = @soLuong, DonGia = @donGia " +
                                    "where MaPhieuNhap = @maPhieuNhap and SoLoHang = @soLoHang and MaLoaiHat = @maLoaiHat";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateCommand, connection);
                command.Parameters.Add(new SqlParameter("@soLuong", SoLuong));
                command.Parameters.Add(new SqlParameter("@donGia", DonGia));
                command.Parameters.Add(new SqlParameter("@maPhieuNhap", MaPhieuNhap));
                command.Parameters.Add(new SqlParameter("@soLoHang", SoLoHang));
                command.Parameters.Add(new SqlParameter("@maLoaiHat", MaLoaiHat));

                rowAffected = command.ExecuteNonQuery();                

            }
            
            return rowAffected;
        }

        public static int UpdateTablePhieuNhapHang(string MaPhieuNhap, string NhaSanXuat, DateTime NgayNhap)
        {
            int rowAffected = 0;
            string updateCommand = "update PhieuNhapHang " +
                                    "set NhaSanXuat = @nhaSanXuat, NgayNhap = @ngayNhap " +
                                    "where NgayNhap = @ngayNhap";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateCommand, connection);
                command.Parameters.Add(new SqlParameter("@nhaSanXuat", NhaSanXuat));
                command.Parameters.Add(new SqlParameter("@ngayNhap", NgayNhap));
                command.Parameters.Add(new SqlParameter("@maPhieuNhap", MaPhieuNhap));

                rowAffected = command.ExecuteNonQuery();                

            }
            
            return rowAffected;

        }

        public static int DeleteRecordFromChiTietPhieuNhap(string MaPhieuNhap)
        {
            int rowAffected = 0;
            string deleteCommand = "delete from ChiTietPhieuNhap " +
                                    "where MaPhieuNhap = @maPhieuNhap";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(deleteCommand, connection);
                command.Parameters.Add(new SqlParameter("@maPhieuNhap", MaPhieuNhap));
                rowAffected = command.ExecuteNonQuery();                
            }
            return rowAffected;
        }

        public static int DeleteRecordFromChiTietPhieuNhap(string MaPhieuNhap, string SoLoHang, string MaLoaiHat)
        {
            int rowAffected = 0;
            string deleteCommand = "delete from ChiTietPhieuNhap " +
                                    "where MaPhieuNhap = @maPhieuNhap and SoLoHang = @soLoHang and MaLoaiHat = @maLoaiHat";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(deleteCommand, connection);
                command.Parameters.Add(new SqlParameter("@maPhieuNhap", MaPhieuNhap));
                command.Parameters.Add(new SqlParameter("@soLoHang", SoLoHang));
                command.Parameters.Add(new SqlParameter("@maLoaiHat", MaLoaiHat));
                rowAffected = command.ExecuteNonQuery();                
            }
            return rowAffected;
        }

        public static int DeleteRecordFromLoHang(string SoLoHang, string MaLoaiHat)
        {
            int rowAffected = 0;
            string deleteCommand = "delete from LoHang " +
                                    "where SoLoHang = @soLoHang and MaLoaiHat = @maLoaiHat";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(deleteCommand, connection);
                command.Parameters.Add(new SqlParameter("@soLoHang", SoLoHang));
                command.Parameters.Add(new SqlParameter("@maLoaiHat", MaLoaiHat));
                rowAffected = command.ExecuteNonQuery();                
            }
            return rowAffected;
        }
        public static int DeleteRecordFromPhieuNhapHang(string MaPhieuNhap)
        {
            int rowAffected = 0;
            string deleteCommand = "delete from PhieuNhapHang " +
                                    "where MaPhieuNhap = @maPhieuNhap";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(deleteCommand, connection);
                command.Parameters.Add(new SqlParameter("@maPhieuNhap", MaPhieuNhap));
                rowAffected = command.ExecuteNonQuery();                
            }
            return rowAffected;
        }

        public static List<string> GetAllOrigin()
        {
            List<string> origins = new List<string>();
            string query = "select distinct XuatXu from LoaiHatCaPhe";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string line = reader.GetString(0);
                        origins.Add(line);
                    }
                }
            }
            return origins;
        }
        public static List<string> GetAllBeanName()
        {
            List<string> names = new List<string>();
            string query = "select distinct TenLoaiHat from LoaiHatCaPhe";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string line = reader.GetString(0);
                        names.Add(line);
                    }
                }
            }
            return names;
        }
    }
}
