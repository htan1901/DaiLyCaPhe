using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using DaiLyCaPhe.DBConnection;

namespace DaiLyCaPhe.Forms
{
    public partial class ExportBillForm : DevExpress.XtraEditors.XtraForm
    {

        private const string DEFAULT_DATE_FORMAT = "dd/MM/yyyy";
        private const string MIN_DATE_VALUE = "01/01/2000";
        private List<ExportBillItem> deletedItems = new List<ExportBillItem>();
        private bool editable = true;
        private DatabaseConnection database = new DatabaseConnection();

        public ExportBillForm()
        {
            InitializeComponent();
        }

        #region Utility Methods
        private void ChangeState(bool state)
        {
            buttonAddBill.Enabled = !state;
            buttonModifyBill.Enabled = !state;
            buttonDeleteBill.Enabled = !state;

            buttonSaveBill.Enabled = state;
            buttonCancel.Enabled = state;
            buttonAddItem.Enabled = state;
        }       

        private void ClearFilterData()
        {
            textBoxExportPlaceFilter.Text = null;
            textBoxProductNameFilter.Text = null;
            dateEditFromDateFilter.Text = null;
            dateEditToDateFilter.Text = null;
            comboBoxProductTypeFilter.Text = null;
        }

        private void ClearCurrentData()
        {
            textBoxBillID.Text = null;
            textBoxExportPlace.Text = null;
            dateEditExportDate.Text = null;
            panelBillDetails.Controls.Clear();
        }

        private void ToggleEditing(bool isAllow)
        {
            textBoxExportPlace.Enabled = isAllow;
            dateEditExportDate.Enabled = isAllow;
            foreach(Control item in panelBillDetails.Controls)
                item.Enabled = isAllow;
        }
        public string GenerateProductID(string beanID, string processMethodID)
        {
            Random random = new Random();
            string prefix = beanID + "-" + processMethodID + "-";
            for(int i = 0; i < 3; i++)
            {
                int randNum = random.Next(100);
                prefix += (randNum < 10) ? ("0" + randNum) : randNum.ToString();
            }
            return prefix;
        }

        public string GenerateBillID()
        {
            string prefix = "PXH";
            Random random = new Random();
            for(int i = 0; i<3; i++)
            {
                int randNum = random.Next(100);
                prefix += randNum<10 ? ("0" + randNum) : randNum.ToString();
            }
            return prefix;
        }

        private void AddEventToItem(ExportBillItem item)
        {
            item.comboBoxIDValueChanged += new EventHandler((sndr, evnt) =>
            {
                string productId = item.ProductID;
                
                foreach(Control i in panelBillDetails.Controls)
                {
                    ExportBillItem billItem = i as ExportBillItem;

                    if (billItem == item)
                        continue;

                    if(billItem.ProductID == productId)
                    {
                        MessageBox.Show("Trùng sản phẩm", "Thông báo", MessageBoxButtons.OK);
                        panelBillDetails.Controls.Remove(item);
                        return;
                    }
                }

                string name = database.GetProductName(productId);
                string type = database.GetProductType(productId);
                float weight = database.GetProductWeight(productId);
                long price = database.GetPrice(productId);
                decimal maximum = database.GetProductAmount(productId);

                if(maximum == 0)
                {
                    MessageBox.Show("Sản phẩm này đã hết trong kho", "Thông báo", MessageBoxButtons.OK);
                    panelBillDetails.Controls.Remove(item);
                    return;
                }

                item.ProductName = name;
                item.ProductType = type;
                item.Weight = weight.ToString();
                item.Price = price;
                item.Maximum = maximum;
                item.Minimum = 1;
            });
        }

        #endregion

        #region Buttons Event
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ClearCurrentData();
            ClearFilterData();
            ChangeState(!editable);
            ToggleEditing(!editable);
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            ExportBillItem item = new ExportBillItem
            {
                Dock = DockStyle.Top
            };
            item.deleteEvent += new EventHandler(DeleteBillItemEvent);
            List<string> ids = database.GetAllProductIDs();
            item.AddProductIDsItem(ids);
            item.deleteEvent += new EventHandler(DeleteBillItemEvent);
            AddEventToItem(item);
            panelBillDetails.Controls.Add(item);
        }

        private void DeleteBillItemEvent(object sender, EventArgs e)
        {
            panelBillDetails.Controls.Remove((ExportBillItem)sender);
        }

        private void UpdateBill_DeleteItem(object sender, EventArgs e)
        {
            ExportBillItem item = sender as ExportBillItem;
            deletedItems.Add(item);
            panelBillDetails.Controls.Remove(item);
        }

        private void ButtonModifyBill_Click(object sender, EventArgs e)
        {
            ChangeState(editable);
            ToggleEditing(editable);
            textBoxExportPlace.Focus();
        }

        private void ButtonAddBill_Click(object sender, EventArgs e)
        {
            ClearCurrentData();
            ChangeState(editable);
            ToggleEditing(editable);
            textBoxExportPlace.Focus();
        }

        #endregion

        #region Fill Events
        private void PlaceAndDateFillEvent(object sender, EventArgs e)
        {
            string exportPlace = textBoxExportPlaceFilter.Text.Trim();
            DateTime fromDate;
            if(dateEditFromDateFilter.Text == null || dateEditFromDateFilter.Text == "")
                fromDate = DateTime.ParseExact(MIN_DATE_VALUE, DEFAULT_DATE_FORMAT, null);
            else
                fromDate = DateTime.ParseExact(dateEditFromDateFilter.Text, DEFAULT_DATE_FORMAT, null);
            DateTime toDate;
            if (dateEditToDateFilter.Text == null || dateEditToDateFilter.Text == "")
                toDate = DateTime.MaxValue;
            else
                toDate = DateTime.ParseExact(dateEditToDateFilter.Text, DEFAULT_DATE_FORMAT, null);

            phieuXuatHangTableAdapter.FillByPlaceAndDate(daiLyCaPheDataSet.PhieuXuatHang,exportPlace, fromDate, toDate);
        }

        private void NameAndTypeFillEvent(object sender, EventArgs e)
        {

            string name = textBoxProductNameFilter.Text.Trim();
            string type = comboBoxProductTypeFilter.Text.Trim();
            string billID = dataGridViewImportBill.SelectedCells[0].Value.ToString().Trim();

            CTPX_SanPhamTableAdapter.FillByNameAndType(daiLyCaPheDataSet.CTPX_SanPham, name, type, billID);
        }

        #endregion

        #region Other Events

        private void ExportBillForm_Load(object sender, EventArgs e)
        {
            this.phieuXuatHangTableAdapter.Fill(this.daiLyCaPheDataSet.PhieuXuatHang);
        }

        private void dataGridViewExportBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeState(!editable);
            ClearFilterData();
            panelBillDetails.Controls.Clear();
            if(e.RowIndex < 0)
                return;

            int index = e.RowIndex;
            string billID = dataGridViewImportBill.Rows[index].Cells[0].Value.ToString();
            string exportPlace = dataGridViewImportBill.Rows[index].Cells[1].Value.ToString();
            string exportDate =  dataGridViewImportBill.Rows[index].Cells[2].Value.ToString();

            textBoxBillID.Text = billID;
            textBoxExportPlace.Text = exportPlace;
            dateEditExportDate.Text = exportDate.Substring(0,10);

            textBoxBillID.Text = billID;
            CTPX_SanPhamTableAdapter.FillByBillID(daiLyCaPheDataSet.CTPX_SanPham, billID);

            DataTable dataTable = database.GetExportBillDetails(billID);
            if (dataTable == null)
                return;
            foreach(DataRow row in dataTable.Rows)
            {
                string productID = row["MaSanPham"].ToString();
                string productName = row["TenSanPham"].ToString();
                string productType = row["LoaiSanPham"].ToString();
                string expireDate = row["HanSuDung"].ToString().Substring(0,10);
                string weight = row["TrongLuong"].ToString();
                long amount = long.Parse(row["SoLuong"].ToString());
                long price = long.Parse(row["DonGia"].ToString());

                ExportBillItem item = new ExportBillItem
                {
                    Dock = DockStyle.Top,
                    Enabled = false,
                    ProductID = productID,
                    ProductName = productName,
                    ProductType = productType,
                    Weight = weight,
                    Amount = amount,
                    Price = price
                };
                List<string> ids = database.GetAllProductIDs();
                item.AddProductIDsItem(ids);
                item.deleteEvent += new EventHandler(UpdateBill_DeleteItem);
                AddEventToItem(item);
                panelBillDetails.Controls.Add(item);
            }
        }

        #endregion

        private void UpdateBill()
        {
            string billID = textBoxBillID.Text.Trim();
            string exportPlace = textBoxExportPlace.Text.Trim();

            if(exportPlace == null || exportPlace == "")
            {
                MessageBox.Show("Nơi xuất không được rỗng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DateTime exportDate;
            string exportDateStr = dateEditExportDate.Text.Trim();
            if (exportDateStr == null || exportDateStr == "")
                exportDate = DateTime.ParseExact(MIN_DATE_VALUE, DEFAULT_DATE_FORMAT, null);
            else
                exportDate = DateTime.ParseExact(exportDateStr, DEFAULT_DATE_FORMAT, null);

            database.UpdateRecordPhieuXuatHang(billID, exportPlace, exportDate);
            
            foreach(Control item in panelBillDetails.Controls)
            {
                ExportBillItem billItem = item as ExportBillItem;

                decimal amount = billItem.Amount;
                string productID = billItem.ProductID;
                long price = billItem.Price;

                if(amount == 0 || productID == "" || productID == null || price == 0)
                {
                    MessageBox.Show("Sản phẩm có trường thông tin rỗng. Bỏ qua sản phẩm", "Thông báo", MessageBoxButtons.OK);
                    continue;
                }

                int rowAffected = database.UpdateRecordChiTietPhieuXuat(billID, productID, (int)amount, price);

                if(rowAffected == 0)
                    chiTietPhieuXuatTableAdapter.Insert(billID, productID, (int)amount, price);
            }

            foreach(ExportBillItem item in deletedItems)
            {
                database.DeleteRecordFromChiTietPhieuXuat(billID, item.ProductID);
            }
        }

        private void SaveBill()
        {
            string billID = GenerateBillID();
            string exportPlace = textBoxExportPlace.Text.Trim();

            if(exportPlace == null || exportPlace == "")
            {
                MessageBox.Show("Nơi xuất không được rỗng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DateTime exportDate;
            string exportDateStr = dateEditExportDate.Text.Trim();
            if (exportDateStr == null || exportDateStr == "")
                exportDate = DateTime.ParseExact(MIN_DATE_VALUE, DEFAULT_DATE_FORMAT, null);
            else
                exportDate = DateTime.ParseExact(exportDateStr, DEFAULT_DATE_FORMAT, null);

            phieuXuatHangTableAdapter.Insert(billID, exportPlace, exportDate, 0);

            foreach(Control item in panelBillDetails.Controls)
            {
                ExportBillItem billItem = item as ExportBillItem;

                decimal amount = billItem.Amount;
                string productID = billItem.ProductID.Trim();
                long price = billItem.Price;

                if(amount == 0 || productID == "" || productID == null || price == 0)
                {
                    MessageBox.Show("Sản phẩm có trường thông tin rỗng. Bỏ qua sản phẩm", "Thông báo", MessageBoxButtons.OK);
                    continue;
                }

                chiTietPhieuXuatTableAdapter.Insert(billID, productID, (int)amount, price);
            }
        }

        private void ButtonSaveBill_Click(object sender, EventArgs e)
        {
            string billID = textBoxBillID.Text.Trim();
            if (billID == "" || billID == null)
                SaveBill();
            else
                UpdateBill();
            ExportBillForm_Load(sender, e);
            ChangeState(!editable);
            ClearCurrentData();
        }

        private void buttonDeleteBill_Click(object sender, EventArgs e)
        {
            string billID = textBoxBillID.Text.Trim();
            DialogResult result = MessageBox.Show(string.Format("Phiếu xuất hàng {0} sẽ bị xóa", textBoxBillID.Text), "Thông báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Cancel)
                return;

            foreach (Control item in panelBillDetails.Controls)
            {
                ExportBillItem billItem = item as ExportBillItem;
                string productID = billItem.ProductID;
                try
                {
                    database.DeleteRecordFromChiTietPhieuXuat(billID, productID);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 

            try
            {
                database.DeleteRecordFromPhieuXuatHang(billID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ChangeState(!editable);
            ExportBillForm_Load(sender, e);
            ClearCurrentData();
        }
    }
}