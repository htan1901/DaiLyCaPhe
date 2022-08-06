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

        public string GetBeanTypeIdByNameAndOrigin(string beanName, string beanOrigin)
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

        public DataTable GetImportBillDetails(string billID)
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

        public string SearchForImportBillID(string billID)
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
        public string SearchForExportBillID(string billID)
        { 
            string id;
            string query = "SELECT MaPhieuXuat FROM PhieuXuatHang WHERE MaPhieuXuat = @billID";
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

        public string GetCategoryIDByBillID(string billID)
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

        public int UpdateTableLoHang(string SoLoHang, string MaLoaiHat, DateTime NgaySanXuat, DateTime HanSuDung)
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

        public int UpdateTableChiTietPhieuNhap(string MaPhieuNhap, string SoLoHang, string MaLoaiHat, decimal SoLuong, decimal DonGia)
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

        public int UpdateTablePhieuNhapHang(string MaPhieuNhap, string NhaSanXuat, DateTime NgayNhap)
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

        public int DeleteRecordFromChiTietPhieuNhap(string MaPhieuNhap)
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

        public int DeleteRecordFromChiTietPhieuNhap(string MaPhieuNhap, string SoLoHang, string MaLoaiHat)
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

        public int DeleteRecordFromLoHang(string SoLoHang, string MaLoaiHat)
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
        public int DeleteRecordFromPhieuNhapHang(string MaPhieuNhap)
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

        public List<string> GetAllOrigin()
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
        public List<string> GetAllBeanName()
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

        public List<string> GetAllBeanName(string categoryID)
        {
            List<string> names = new List<string>();
            string query = "select distinct C.TenLoaiHat from LoHang L, LoaiHatCaPhe C where L.MaLoaiHat = C.MaLoaiHat and L.SoLoHang = @categoryID";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@categoryID", categoryID));
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

        public List<string> GetAllOrigin(string categoryID, string beanName)
        {
            List<string> origins = new List<string>();
            string query = "select distinct C.XuatXu from LoHang L, LoaiHatCaPhe C where L.MaLoaiHat = C.MaLoaiHat and L.SoLoHang = @categoryID and C.TenLoaiHat = @beanName";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@categoryID", categoryID));
                command.Parameters.Add(new SqlParameter("@beanName", beanName));
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

        public string GetExpireDate(string categoryID, string beanName, string origin)
        {
            string id;
            string query = "select L.HanSuDung " +
                            "from LoHang L, LoaiHatCaPhe C " +
                            "where L.MaLoaiHat = C.MaLoaiHat and L.SoLoHang = @categoryID and C.TenLoaiHat = @beanName and C.XuatXu like @origin";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@categoryId", categoryID));
                command.Parameters.Add(new SqlParameter("@beanName", beanName));
                command.Parameters.Add(new SqlParameter("@origin", origin));
                object obj = command.ExecuteScalar();
                id = obj == null ? "" : obj.ToString();
            }
            return id;

        }

        public DataTable GetExportBillDetails(string billID)
        {
            string query = "select S.MaSanPham, S.TenSanPham, S.LoaiSanPham, S.TrongLuong, S.HanSuDung, C.SoLuong, C.DonGia " +
                            "from ChiTietPhieuXuat C, SanPham S " +
                            "where C.MaSanPham = S.MaSanPham and MaPhieuXuat = @billID";
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

        public string GetExpireDate(string categoryID, string beanID)
        {
            string id;
            string query = "select HanSuDung " +
                            "from LoHang " +
                            "where SoLoHang = @categoryID and MaLoaiHat = @beanID ";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@categoryID", categoryID));
                command.Parameters.Add(new SqlParameter("@beanID", beanID));
                object obj = command.ExecuteScalar();
                id = obj == null ? "" : obj.ToString();
            }
            return id;
        }

        public List<string> GetAllCategoryID()
        {
            List<string> list = new List<string>();
            string query = "select distinct SoLoHang from LoHang";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string line = reader.GetString(0);
                        list.Add(line);
                    }
                }
            }
            return list;
        }

        public List<string> GetAllProcessMethod()
        {
            List<string> methods = new List<string>();
            string query = "select distinct MoTa from PhuongPhapCheBien";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string line = reader.GetString(0);
                        methods.Add(line);
                    }
                }
            }
            return methods;
        }
        
        public string GetProcessMethodID(string methodDescription)
        {
            string id;
            string query = "select MaPPCheBien " +
                            "from PhuongPhapCheBien " +
                            "where MoTa = @description ";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@description", methodDescription));
                object obj = command.ExecuteScalar();
                id = obj == null ? "" : obj.ToString();
            }
            return id;
        }

        public List<string> GetAllPackingMethod()
        {
            List<string> methods = new List<string>();
            string query = "select distinct MoTa from CachDongGoi";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string line = reader.GetString(0);
                        methods.Add(line);
                    }
                }
            }
            return methods;
        }

        public string GetPackingMethodID(string methodDescription)
        {
            string id;
            string query = "select MaCachDongGoi " +
                            "from CachDongGoi " +
                            "where MoTa = @description ";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@description", methodDescription));
                object obj = command.ExecuteScalar();
                id = obj == null ? "" : obj.ToString();
            }
            return id;
        }

        public float GetPackingWeight(string methodID)
        {
            float id;
            string query = "select SoLuongMoiGoi " +
                            "from CachDongGoi " +
                            "where MaCachDongGoi = @methodID ";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@methodID", methodID));
                object obj = command.ExecuteScalar();
                id = obj == null ? 0.0F : float.Parse(obj.ToString());
            }
            return id;
        }

        public List<string> GetAllEmployeeIDs()
        {
            List<string> employees = new List<string>();
            string query = "select MaNhanVien from NhanVien";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string line = reader.GetString(0);
                        employees.Add(line);
                    }
                }
            }
            return employees;
        }

        public void UpdateTablePhieuCheBien(string paperID, string beanID)
        {

        }
    }
}
