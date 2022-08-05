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
        private bool editable = true;
        private DatabaseConnection database = new DatabaseConnection();

        public ExportBillForm()
        {
            InitializeComponent();
        }

        #region Utility Methods
        private void ChangeState(bool state)
        {
            textBoxExportPlace.Enabled = state;
            dateEditExportDate.Enabled = state;
            buttonSaveBill.Enabled = state;
            buttonCancel.Enabled = state;
            buttonAddItem.Enabled = state;
            buttonDeleteBill.Enabled = !state;
            buttonModifyBill.Enabled = !state;
            buttonAddBill.Enabled = !state;
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

        private string GenerateProductID()
        {
            return "";
        }

        #endregion

        #region Buttons Event
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ClearCurrentData();
            ChangeState(!editable);
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            ExportBillItem newItem = new ExportBillItem
            {
                Dock = DockStyle.Top
            };
            newItem.deleteEvent += new EventHandler(DeleteBillItemEvent);
            panelBillDetails.Controls.Add(newItem);
        }

        private void DeleteBillItemEvent(object sender, EventArgs e)
        {
            panelBillDetails.Controls.Remove((ExportBillItem)sender);
        }

        private void ButtonModifyBill_Click(object sender, EventArgs e)
        {
            ChangeState(editable);
            foreach(Control item in panelBillDetails.Controls)
            {
                item.Enabled = true;
            }
            textBoxExportPlace.Focus();
        }

        private void ButtonAddBill_Click(object sender, EventArgs e)
        {
            ClearCurrentData();
            ChangeState(editable);
            textBoxExportPlace.Focus();
        }

        #endregion

        #region Fill Events
        private void PlaceAndDateFillEvent(object sender, EventArgs e)
        {
            string exportPlace = textBoxExportPlaceFilter.Text;
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

            string name = textBoxProductNameFilter.Text;
            string type = comboBoxProductTypeFilter.Text;
            string billID = dataGridViewImportBill.SelectedCells[0].Value.ToString();

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

                MessageBox.Show(productID);

                ExportBillItem item = new ExportBillItem
                {
                    Dock = DockStyle.Top,
                    Enabled = false,
                    ProductID = productID,
                    ProductName = productName,
                    ProductType = productType,
                    ExpireDate = expireDate,
                    Weight = weight,
                    Amount = amount,
                    Price = price
                };
                item.deleteEvent += new EventHandler(DeleteBillItemEvent);
                panelBillDetails.Controls.Add(item);
            }
        }

        #endregion

        private void UpdateBill()
        {

        }

        private void SaveBill()
        {
            string billID = textBoxBillID.Text;
            string exportPlace = textBoxExportPlace.Text;

            DateTime exportDate;
            string exportDateStr = dateEditExportDate.Text;
            if (exportDateStr == null || exportDateStr == "")
                exportDate = DateTime.ParseExact(MIN_DATE_VALUE, DEFAULT_DATE_FORMAT, null);
            else
                exportDate = DateTime.ParseExact(exportDateStr, DEFAULT_DATE_FORMAT, null);

            foreach(Control item in panelBillDetails.Controls)
            {
                ExportBillItem billItem = item as ExportBillItem;

                string productID = billItem.ProductID;
                string productName = billItem.ProductName;
                string productType = billItem.ProductType;
                string expireDate = billItem.ExpireDate;
                string weight = billItem.Weight;
                
                 

            }
        }

        private void ButtonSaveBill_Click(object sender, EventArgs e)
        {
            string billID = database.SearchForExportBillID(textBoxBillID.Text);
            if (billID == "")
                SaveBill();
            else
                UpdateBill();
            ExportBillForm_Load(sender, e);
            ChangeState(!editable);
            ClearCurrentData();
        }
    }
}