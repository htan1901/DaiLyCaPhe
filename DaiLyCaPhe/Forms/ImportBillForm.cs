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
using System.Data.SqlClient;

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
            return textBoxBeanNameFilter.Text;
        }

        private string GetOrigin()
        {
            return textBoxBeanOriginFilter.Text;
        }

        private string GetBillCode()
        {
            return dataGridViewImportBill.SelectedCells[0].Value.ToString();
        }

        private string generateID(string prefix, int length)
        {
            string nums = "0123456789";
            int numsLen = nums.Length;
            string id = prefix;
            Random random = new Random();
            for (int i = 0; i < length; i++)
                id += random.Next(numsLen - 1);
            return id;
        }

        private string generateBeanTypeID(string beanType, string origin)
        {
            Random random = new Random();
            string prefix = beanType.Substring(0, 3);
            int num = random.Next(999) + 1;
            if (num < 10)
                prefix += "00" + num;
            else if (num >= 10 && num < 100)
                prefix += "0" + num;
            else
                prefix += num.ToString();
            return prefix.ToUpper();
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
            textBoxBillID.Text = null;
            textBoxProductCompanyName.Text = null;
            dateEditImportDate.Text = "";
            panelBillItem.Controls.Clear();
        }

        private void ImportBillForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daiLyCaPheDataSet.LoHang' table. You can move, or remove it, as needed.
            this.loHangTableAdapter.Fill(this.daiLyCaPheDataSet.LoHang);
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
                textBoxBeanOriginFilter.Focus();
                return;
            }
            if (sender.Equals(labelBeanName))
            {
                textBoxBeanNameFilter.Focus();
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
            panelBillItem.Controls.Clear();
            if (!(e.RowIndex >= 0))
                return;
            int index = e.RowIndex;
            string billID = dataGridViewImportBill.Rows[index].Cells[0].Value.ToString();
            textBoxBillID.Text = billID;
            this.CTPN_LoaiHatTableAdapter.FillByOriginAndNameAndBillCode(this.daiLyCaPheDataSet.CTPN_LoaiHat, GetBeanName(), GetOrigin() ,billID);
            textBoxProductCompanyName.Text = dataGridViewImportBill.Rows[index].Cells[1].Value.ToString();
            dateEditImportDate.Text = dataGridViewImportBill.Rows[index].Cells[2].Value.ToString().Substring(0,10);
            DataTable dataTable = DatabaseConnection.GetBillDetails(billID);
            if (dataTable == null)
                return;
            foreach (DataRow row in dataTable.Rows)
            {
                long price = long.Parse(row["DonGia"].ToString());
                string productionDate = row["NgaySanXuat"].ToString().Substring(0,10);
                string origin = row["XuatXu"].ToString();
                decimal amount = decimal.Parse(row["SoLuong"].ToString());
                string beanName = row["TenLoaiHat"].ToString();

                ImportBillItem item = new ImportBillItem();

                item.BeanName = beanName;
                item.Origin = origin;
                item.ProductionDate = productionDate;
                item.Amount = amount;
                item.Price = price.ToString();
                item.Dock = DockStyle.Top;
                panelBillItem.Controls.Add(item);
            }

        }


        private void NameAndOriginFilter(object sender, EventArgs e)
        {
            string name = textBoxBeanNameFilter.Text;
            string origin = textBoxBeanOriginFilter.Text;
            this.CTPN_LoaiHatTableAdapter.FillByOriginAndNameAndBillCode(this.daiLyCaPheDataSet.CTPN_LoaiHat, name, origin, GetBillCode());

        }

        private void updateBill()
        {
            loHangTableAdapter.Update();   
        }

        private void saveBill()
        {
            string importDateText = dateEditImportDate.Text;
            DateTime importDate;
            if(importDateText == null || importDateText == "")
                importDate = DateTime.Now;
            else
                importDate = DateTime.ParseExact(importDateText, DEFAULT_DATE_FORMAT, null);

            string billID = generateID("PNH", 6);
            string categoryID = generateID("SL", 6);
            long total = 0;
            string productCompanyName = textBoxProductCompanyName.Text;

            if (productCompanyName == null || productCompanyName == "")
            {
                MessageBox.Show("Tên nhà sản xuất không được rỗng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            do
            {
                try
                {
                    phieuNhapHangTableAdapter.Insert(billID, productCompanyName, importDate, total);
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    billID = generateID("PNH", 6);
                }

            } while (true);

            foreach (Control item in panelBillItem.Controls)
            {
                ImportBillItem billItem = item as ImportBillItem;

                string beanTypeID = "";
                string productionDateText = billItem.ProductionDate;
                DateTime productionDate;
                DateTime expireDate;
                int price = 0;

                if (productionDateText == null || productionDateText == "")
                    productionDate = DateTime.Now;
                else
                    productionDate = DateTime.ParseExact(productionDateText, DEFAULT_DATE_FORMAT, null);
                expireDate = productionDate.AddMonths(3);

                try
                {
                    price = int.Parse(billItem.Price);
                }
                catch (Exception ex)
                {
                    price = 0;
                }
                int amount = int.Parse(billItem.Amount.ToString());

                string name = billItem.BeanName;
                string origin = billItem.Origin;

                if (price == 0 || amount == 0 || name == "" || name == null || origin == "" || origin == null)
                    continue;
                
                string beanID = DatabaseConnection.GetBeanTypeIdByNameAndOrigin(name, origin);
                if (beanID != "")
                    beanTypeID = beanID;
                else
                {
                    beanTypeID = generateBeanTypeID(name, origin);
                    try
                    {
                        loaiHatCaPheTableAdapter.Insert(beanTypeID, name, origin);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                do
                {
                    try
                    {
                       loHangTableAdapter.Insert(categoryID, beanTypeID, amount, productionDate, expireDate);
                       chiTietPhieuNhapTableAdapter.Insert(billID, categoryID, beanTypeID, amount, price);
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        categoryID = generateID("SL", 6);
                    }

                } while (true);
            }
        }

        private void buttonSaveBill_Click(object sender, EventArgs e)
        {
            string billID = DatabaseConnection.GetBillByID(textBoxBillID.Text);
            if (billID == "")
                saveBill();
            else
                updateBill();


            ImportBillForm_Load(sender, e);
        }
    }
}