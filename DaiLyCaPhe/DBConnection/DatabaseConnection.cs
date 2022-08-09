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
            string query = "SELECT MaLoaiHat FROM LoaiHatCaPhe WHERE TenLoaiHat LIKE @beanOrigin AND XuatXu LIKE @beanOrigin";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@beanOrigin", beanName));
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

        public int UpdateRecordLoHang(string SoLoHang, string MaLoaiHat, DateTime NgaySanXuat, DateTime HanSuDung)
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

        public int UpdateRecordChiTietPhieuNhap(string MaPhieuNhap, string SoLoHang, string MaLoaiHat, decimal SoLuong, decimal DonGia)
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

        public int UpdateRecordPhieuNhapHang(string MaPhieuNhap, string NhaSanXuat, DateTime NgayNhap)
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
            string query = "select distinct C.XuatXu from LoHang L, LoaiHatCaPhe C where L.MaLoaiHat = C.MaLoaiHat and L.SoLoHang = @categoryID and C.TenLoaiHat = @beanOrigin";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@categoryID", categoryID));
                command.Parameters.Add(new SqlParameter("@beanOrigin", beanName));
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
                            "where L.MaLoaiHat = C.MaLoaiHat and L.SoLoHang = @categoryID and C.TenLoaiHat = @beanOrigin and C.XuatXu like @origin";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@categoryId", categoryID));
                command.Parameters.Add(new SqlParameter("@beanOrigin", beanName));
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
            string expireDate;
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
                expireDate = obj == null ? "" : obj.ToString();
            }
            return expireDate;
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

        public int UpdateTablePhieuCheBien(string paperID, string categoryID, string beanID, string processMethodID, string packingMethodID, string employeeID, string productID, bool isGrind, DateTime processDate, int amount)
        {
            int rowAffected = 0;
            string updateCommand = "update PhieuCheBien set MaPPCheBien = @processMethodID, MaCachDongGoi = @packingMethodID, MaNhanVien = @employeeID, MaSanPham = @productID, Xay = @isGrind, NgayCheBien = @processDate, SoLuongCheBien = @state where MaPhieuCheBien = @paperID and SoLoHang = @categoryID and MaLoaiHat = @beanID";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateCommand, connection);
                command.Parameters.Add(new SqlParameter("@paperID", paperID));
                command.Parameters.Add(new SqlParameter("@categoryID", categoryID));
                command.Parameters.Add(new SqlParameter("@beanID", beanID));
                command.Parameters.Add(new SqlParameter("@processMethodID", processMethodID));
                command.Parameters.Add(new SqlParameter("@packingMethodID", packingMethodID));
                command.Parameters.Add(new SqlParameter("@employeeID", employeeID));
                command.Parameters.Add(new SqlParameter("@productID", productID));
                command.Parameters.Add(new SqlParameter("@isGrind", isGrind));
                command.Parameters.Add(new SqlParameter("@processDate", processDate));
                command.Parameters.Add(new SqlParameter("@state", amount));

                rowAffected = command.ExecuteNonQuery();                

            }
            
            return rowAffected;
        }

        public int DeleteRecordFromPhieuCheBien(string paperID)
        {
            int rowAffected = 0;
            string deleteCommand = "delete from PhieuCheBien " +
                                    "where MaPhieuCheBien = @paperID";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(deleteCommand, connection);
                command.Parameters.Add(new SqlParameter("@paperID", paperID));
                rowAffected = command.ExecuteNonQuery();                
            }
            return rowAffected;
        }

        public int UpdateTableSanPham(string productID, string productName, string productType, float weight, DateTime expireDate, int amountLeftOver)
        {
            int rowAffected = 0;
            string updateCommand = "update SanPham set TenSanPham = @productName, LoaiSanPham = @productType, TrongLuong = @weight, HanSuDung = @beanOrigin, SoLuongTon = @amountLeftOver where MaSanPham = @productID";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateCommand, connection);
                command.Parameters.Add(new SqlParameter("@productID", productID));
                command.Parameters.Add(new SqlParameter("@productName", productName));
                command.Parameters.Add(new SqlParameter("@productType", productType));
                command.Parameters.Add(new SqlParameter("@weight", weight));
                command.Parameters.Add(new SqlParameter("@beanOrigin", expireDate));
                command.Parameters.Add(new SqlParameter("@amountLeftOver", amountLeftOver));

                rowAffected = command.ExecuteNonQuery();                

            }
            
            return rowAffected;
        }

        public string GetProductID(string paperID, string categoryID, string beanID)
        {
            string id;
            string query = "select MaSanPham " +
                            "from PhieuCheBien " +
                            "where MaPhieuCheBien = @paperID and SoLoHang = @categoryID and MaLoaiHat = @beanID ";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@paperID", paperID));
                command.Parameters.Add(new SqlParameter("@categoryID", categoryID));
                command.Parameters.Add(new SqlParameter("@beanID", beanID));

                object obj = command.ExecuteScalar();
                id = obj == null ? "" : obj.ToString();
            }
            return id;
        }

        public int GetLeftOverAmount(string categoryID, string beanID)
        {
            int amountLeftOver;
            string query = "select SoLuongTon " +
                            "from LoHang " +
                            "where SoLoHang = @categoryID and MaLoaiHat = @beanID ";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@categoryID", categoryID));
                command.Parameters.Add(new SqlParameter("@beanID", beanID));

                object obj = command.ExecuteScalar();
                amountLeftOver = obj == null ? 0 : int.Parse(obj.ToString());
            }
            return amountLeftOver;
        }

        public string GetProductID(string productName, string productType, string expireDate, float weight)
        {
            string id;
            string query = "select MaSanPham " +
                            "from SanPham " +
                            "where TenSanPham = @productName and LoaiSanPham = @productType and HanSuDung = @beanOrigin and TrongLuong = @weight ";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@productName", productName));
                command.Parameters.Add(new SqlParameter("@productType", productType));
                command.Parameters.Add(new SqlParameter("@beanOrigin", expireDate));
                command.Parameters.Add(new SqlParameter("@weight", weight));

                object obj = command.ExecuteScalar();
                id = obj == null ? "" : obj.ToString();
            }
            return id;
        }

        public long GetPrice(string productID)
        {
            long price;
            string query = "select DonGia " +
                            "from DonGia D, PhieuCheBien P " +
                            "where P.MaLoaiHat = D.MaLoaiHat and P.MaSanPham = @productID and DenNgay is null ";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@productID", productID));

                object obj = command.ExecuteScalar();
                price = obj == null ? 0 : long.Parse(obj.ToString());
            }
            return price;
        }

        public List<string> GetAllProductIDs()
        {
            List<string> ids = new List<string>();
            string query = "select MaSanPham from SanPham";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string line = reader.GetString(0);
                        ids.Add(line);
                    }
                }
            }
            return ids;
        }

        public string GetProductName(string productID)
        {
            string name;
            string query = "select TenSanPham " +
                            "from SanPham " +
                            "where MaSanPham = @productID";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@productID", productID));

                object obj = command.ExecuteScalar();
                name = obj == null ? "" : obj.ToString();
            }
            return name;
        }
        public string GetProductType(string productID)
        {
            string type;
            string query = "select LoaiSanPham " +
                            "from SanPham " +
                            "where MaSanPham = @productID";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@productID", productID));

                object obj = command.ExecuteScalar();
                type = obj == null ? "" : obj.ToString();
            }
            return type;
        }

        public float GetProductWeight(string productID)
        {
            float weight;
            string query = "select TrongLuong " +
                            "from SanPham " +
                            "where MaSanPham = @productID";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@productID", productID));

                object obj = command.ExecuteScalar();
                weight = obj == null ? 0.0f : float.Parse(obj.ToString());
            }
            return weight;
        }

        public int GetProductAmount(string productID)
        {
            int amount;
            string query = "select SoLuongTon " +
                            "from SanPham " +
                            "where MaSanPham = @productID";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@productID", productID));

                object obj = command.ExecuteScalar();
                amount = obj == null ? 0 : int.Parse(obj.ToString());
            }
            return amount;

        }

        public int UpdateRecordChiTietPhieuXuat(string billID, string productID, int amount, long price)
        {
            int rowAffected = 0;
            string updateCommand = "update ChiTietPhieuXuat " +
                                    "set SoLuong = @state, DonGia = @price " +
                                    "where MaPhieuXuat = @billID and MaSanPham = @productID";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateCommand, connection);
                command.Parameters.Add(new SqlParameter("@state", amount));
                command.Parameters.Add(new SqlParameter("@price", price));
                command.Parameters.Add(new SqlParameter("@billID", billID));
                command.Parameters.Add(new SqlParameter("@productID", productID));

                rowAffected = command.ExecuteNonQuery();                

            }
            
            return rowAffected;

        }
        public int UpdateRecordPhieuXuatHang(string billID, string exportPlace, DateTime exportDate)
        {
            int rowAffected = 0;
            string updateCommand = "update PhieuXuatHang " +
                                    "set NoiXuat = @exportPlace, NgayXuat = @exportDate " +
                                    "where MaPhieuXuat = @billID";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateCommand, connection);
                command.Parameters.Add(new SqlParameter("@exportPlace", exportPlace));
                command.Parameters.Add(new SqlParameter("@exportDate", exportDate));
                command.Parameters.Add(new SqlParameter("@billID", billID));

                rowAffected = command.ExecuteNonQuery();                
            }
            return rowAffected;
        }

        public int DeleteRecordFromChiTietPhieuXuat(string billID, string productID)
        {
            int rowAffected = 0;
            string deleteCommand = "delete from ChiTietPhieuXuat where MaPhieuXuat = @billID and MaSanPham = @productID";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(deleteCommand, connection);
                command.Parameters.Add(new SqlParameter("@billID", billID));
                command.Parameters.Add(new SqlParameter("@productID", productID));

                rowAffected = command.ExecuteNonQuery();                
            }
            return rowAffected;
        }

        public int DeleteRecordFromPhieuXuatHang(string billID)
        {
            int rowAffected = 0;
            string deleteCommand = "delete from PhieuXuatHang where MaPhieuXuat = @billID";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(deleteCommand, connection);
                command.Parameters.Add(new SqlParameter("@billID", billID));

                rowAffected = command.ExecuteNonQuery();                
            }
            return rowAffected;
        }

        public object ValidateLoginInfo(string username, string password)
        {
            object state;
            string query = "select VaiTro " +
                            "from ThongTinDangNhap " +
                            "where TenDangNhap = @username and MatKhau = @password";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@username", username));
                command.Parameters.Add(new SqlParameter("@password", password));

                object obj = command.ExecuteScalar();
                state = obj;
            }
            return state;
        }

        public int IsAccountExist(string username)
        {
            int state;
            string query = "select MaThongTin " +
                            "from ThongTinDangNhap " +
                            "where TenDangNhap = @username";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@username", username));

                object obj = command.ExecuteScalar();
                if (obj == null)
                    state = -1;
                else
                    state = int.Parse(obj.ToString());
            }
            return state;
        }

        public int UpdatePrice(string beanID, DateTime date, long newPrice)
        {
            int rowAffected = 0;
            string insertCommand = "insert into DonGia values (@beanID, @date, null, @newPrice)";
            string updateCommand = "update DonGia set DenNgay = @date where MaLoaiHat = @beanID and DenNgay is null";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand icommand = new SqlCommand(insertCommand, connection);
                icommand.Parameters.Add(new SqlParameter("@beanID", beanID));
                icommand.Parameters.Add(new SqlParameter("@date", date));
                icommand.Parameters.Add(new SqlParameter("@newPrice", newPrice));

                SqlCommand ucommand = new SqlCommand(updateCommand, connection);
                ucommand.Parameters.Add(new SqlParameter("@date", date));
                ucommand.Parameters.Add(new SqlParameter("@beanID", beanID));

                rowAffected += ucommand.ExecuteNonQuery();
                rowAffected += icommand.ExecuteNonQuery();                
            }
            return rowAffected;
        }

        public List<string> GetAllBeanIDs()
        {
            List<string> ids = new List<string>();
            string query = "select MaLoaiHat from LoaiHatCaPhe";
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string line = reader.GetString(0);
                        ids.Add(line);
                    }
                }
            }
            return ids;

        }

        public string GetBeanName(string beanID)
        {
            string beanName;
            string query = "select TenLoaiHat " +
                            "from LoaiHatCaPhe " +
                            "where MaLoaiHat = @beanID";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@beanID", beanID));
                object obj = command.ExecuteScalar();
                beanName = obj == null ? "" : obj.ToString();
            }
            return beanName;
        }

        public string GetBeanOrigin(string beanID)
        {
            string beanOrigin;
            string query = "select XuatXu " +
                            "from LoaiHatCaPhe " +
                            "where MaLoaiHat = @beanID";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@beanID", beanID));
                object obj = command.ExecuteScalar();
                beanOrigin = obj == null ? "" : obj.ToString();
            }
            return beanOrigin;
        }
    }
}
