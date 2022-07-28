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

namespace DaiLyCaPhe
{
    public partial class ImportBillForm : DevExpress.XtraEditors.XtraForm
    {
        private const string DEFAULT_DATE_FORMAT = "dd/MM/yyyy";
        private const string MIN_DATE_VALUE = "01/01/2000";
        public ImportBillForm()
        {
            InitializeComponent();
        }
        private string GetBeanName()
        {
            return textBoxBeanName.Text;
        }

        private string GetOrigin()
        {
            return textBoxBeanOrigin.Text;
        }

        private string GetBillCode()
        {
            return dataGridViewImportBill.SelectedCells[0].Value.ToString();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            ImportBillItem newItem = new ImportBillItem();
            newItem.Dock = DockStyle.Top;
            newItem.deleteEvent += new EventHandler(deleteBillItemEvent);
            panelBillItem.Controls.Add(newItem);
        }

        private void deleteBillItemEvent(object sender, EventArgs e)
        {
            panelBillItem.Controls.Remove((Control)sender);
        }

        private void clearAllItemButton_Click(object sender, EventArgs e)
        {
            panelBillItem.Controls.Clear();
        }

        private void ImportBillForm_Load(object sender, EventArgs e)
        {
            this.phieuNhapHangTableAdapter.Fill(this.daiLyCaPheDataSet.PhieuNhapHang);

        }

        private void labelClickToFocus(object sender, EventArgs e)
        {
            if (sender.Equals(labelCompanyNameFilter))
            {
                textBoxCompanyNameFilter.Focus();
                return;
            }
            if (sender.Equals(labelFromDateFilter))
            {
                dateEditFromDateFilter.Focus();
                return;
            }
            if (sender.Equals(labelToDateFilter))
            {
                dateEditToDateFilter.Focus();
                return;
            }
            if (sender.Equals(labelBeanOrigin))
            {
                textBoxBeanOrigin.Focus();
                return;
            }
            if (sender.Equals(labelBeanName))
            {
                textBoxBeanName.Focus();
                return;
            }

        }

        private void textBoxCompanyNameFilter_TextChanged(object sender, EventArgs e)
        {

            try
            {
                this.phieuNhapHangTableAdapter.FillByProductCompanyName(this.daiLyCaPheDataSet.PhieuNhapHang, textBoxCompanyNameFilter.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillEvent(object sender, EventArgs e)
        {
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

            try
            {
                this.phieuNhapHangTableAdapter.FillByNameAndDate(this.daiLyCaPheDataSet.PhieuNhapHang, textBoxCompanyNameFilter.Text, fromDate, toDate);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void dataGridViewImportBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                string billCode = dataGridViewImportBill.Rows[index].Cells[0].Value.ToString();
                this.CTPN_LoaiHatTableAdapter.FillByOriginAndNameAndBillCode(this.daiLyCaPheDataSet.CTPN_LoaiHat, GetBeanName(), GetOrigin() ,billCode);
            }
        }


        private void NameAndOriginFilter(object sender, EventArgs e)
        {
            string name = textBoxBeanName.Text;
            string origin = textBoxBeanOrigin.Text;
            this.CTPN_LoaiHatTableAdapter.FillByOriginAndNameAndBillCode(this.daiLyCaPheDataSet.CTPN_LoaiHat, name, origin, GetBillCode());

        }

        private void saveBill(object sender, EventArgs e)
        {
            List<ImportBillItem> billItems = new List<ImportBillItem>();
            string productCompanyName = textBoxProductCompanyName.Text;
            DateTime importDate;
            if(dateEditImportDate.Text == null || dateEditImportDate.Text == "")
                importDate = DateTime.Now;
            else
                importDate = DateTime.ParseExact(dateEditImportDate.Text, DEFAULT_DATE_FORMAT, null);
            string billCode = "PNH" + importDate.Month + importDate.Date + importDate.Year;
            string categoryNumber = textBoxCategoryNumber.Text;
            long total = 0;
            foreach (Control item in panelBillItem.Controls)
            {
                int price = 0;
                try
                {
                    price = int.Parse(((ImportBillItem)item).Price);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Amount wrong type");
                }
                string name = ((ImportBillItem)item).BeanName;
                string origin = ((ImportBillItem)item).Origin;
                decimal amount = ((ImportBillItem)item).Amount;
                total += long.Parse(amount.ToString()) * price;
            }
        }
    }
}