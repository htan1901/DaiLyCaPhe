﻿using DevExpress.XtraEditors;
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
        private List<ImportBillItem> deletedItems = new List<ImportBillItem> ();
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

        private void ChangeState(bool state)
        {
            dateEditImportDate.Enabled = state;
            textBoxProductCompanyName.Enabled = state;
            buttonSave.Enabled = state;
            buttonCancel.Enabled = state;
            buttonAddItem.Enabled = state;
            buttonDeleteBill.Enabled = !state;
            buttonModifyBill.Enabled = !state;
            buttonAddBill.Enabled = !state;
        }       
        
        private void ClearCurrentData()
        {
            textBoxBillID.Text = null;
            textBoxCategoryID.Text = null;
            textBoxProductCompanyName.Text = null;
            dateEditImportDate.Text = null;
            panelBillItem.Controls.Clear();
        }

        private string GenerateID(string prefix, int length)
        {
            string nums = "0123456789";
            int numsLen = nums.Length;
            string id = prefix;
            Random random = new Random();
            for (int i = 0; i < length; i++)
                id += random.Next(numsLen - 1);
            return id;
        }

        private string GenerateBeanTypeID(string beanType)
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

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            ImportBillItem newItem = new ImportBillItem
            {
                Dock = DockStyle.Top
            };
            newItem.deleteEvent += new EventHandler(DeleteBillItemEvent);
            newItem.AddBeanNameItem(DatabaseConnection.GetAllBeanName());
            newItem.AddBeanOriginItem(DatabaseConnection.GetAllOrigin());
            panelBillItem.Controls.Add(newItem);
        }

        private void DeleteBillItemEvent(object sender, EventArgs e)
        {
            panelBillItem.Controls.Remove((Control)sender);
        }

        private void DeleteItemFromDBEvent(object sender, EventArgs e)
        {
            deletedItems.Add((ImportBillItem)sender);
            panelBillItem.Controls.Remove((Control)sender);
        }

        private void ClearAllItemButton_Click(object sender, EventArgs e)
        {
            ClearCurrentData();
            ChangeState(false);
        }
        private void ButtonSaveBill_Click(object sender, EventArgs e)
        {
            string billID = DatabaseConnection.GetBillByID(textBoxBillID.Text);
            if (billID == "")
                SaveBill();
            else
                UpdateBill();
            ImportBillForm_Load(sender, e);
            ChangeState(false);
            ClearCurrentData();
        }

        private void ButtonDeleteBill_Click(object sender, EventArgs e)
        {
            string billID = textBoxBillID.Text;
            string categoryID = textBoxCategoryID.Text;

            DialogResult dialogResult = MessageBox.Show(string.Format("Hóa đơn {0} sẽ bị xóa", billID), "Thông báo", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel");
                return;
            }

            DatabaseConnection.DeleteRecordFromChiTietPhieuNhap(billID);
            DatabaseConnection.DeleteRecordFromPhieuNhapHang(billID);

            ImportBillForm_Load(sender, e);
        }

        private void ButtonModifyBill_Click(object sender, EventArgs e)
        {
            ChangeState(true);
            foreach(Control item in panelBillItem.Controls)
            {
                item.Enabled = true;
            }
            textBoxProductCompanyName.Focus();
        }

        private void ButtonAddBill_Click(object sender, EventArgs e)
        {
            ClearCurrentData();
            ChangeState(true);
            textBoxProductCompanyName.Focus();
        }

        private void ImportBillForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daiLyCaPheDataSet.LoHang' table. You can move, or remove it, as needed.
            this.loHangTableAdapter.Fill(this.daiLyCaPheDataSet.LoHang);
            this.phieuNhapHangTableAdapter.Fill(this.daiLyCaPheDataSet.PhieuNhapHang);

        }

        private void LabelClickToFocus(object sender, EventArgs e)
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

        private void TextBoxCompanyNameFilter_TextChanged(object sender, EventArgs e)
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

        private void FillEvent(object sender, EventArgs e)
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


        private void DataGridViewImportBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeState(false);
            panelBillItem.Controls.Clear();
            if (!(e.RowIndex >= 0))
                return;
            int index = e.RowIndex;
            string billID = dataGridViewImportBill.Rows[index].Cells[0].Value.ToString();
            string categoryId = DatabaseConnection.GetCategoryIDByBillID(billID);

            textBoxBillID.Text = billID;
            textBoxCategoryID.Text = categoryId;
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

                ImportBillItem item = new ImportBillItem
                {
                    BeanName = beanName,
                    Origin = origin,
                    ProductionDate = productionDate,
                    Amount = amount,
                    Price = price,
                    Dock = DockStyle.Top,
                    ComboBoxBeanNameEnabled = false,
                    ComboBoxBeanOriginEnabled = false,
                    Enabled = false,
                };
                item.deleteEvent += new EventHandler(DeleteItemFromDBEvent);
                panelBillItem.Controls.Add(item);
            }

        }


        private void NameAndOriginFilter(object sender, EventArgs e)
        {
            string name = textBoxBeanNameFilter.Text;
            string origin = textBoxBeanOriginFilter.Text;
            this.CTPN_LoaiHatTableAdapter.FillByOriginAndNameAndBillCode(this.daiLyCaPheDataSet.CTPN_LoaiHat, name, origin, GetBillCode());

        }

        private void UpdateBill()
        {
            string billID = textBoxBillID.Text;
            string categoryID = textBoxCategoryID.Text;
            string productCompanyName = textBoxProductCompanyName.Text;
            string importDate = dateEditImportDate.Text;

            foreach(Control item in panelBillItem.Controls)
            {
                ImportBillItem importBill = item as ImportBillItem;
                string beanName = importBill.BeanName;
                string origin = importBill.Origin;
                string date = importBill.ProductionDate;

                DateTime productionDate = DateTime.ParseExact(date, DEFAULT_DATE_FORMAT, null);
                DateTime expireDate = productionDate.AddMonths(3);
    
                decimal amount = importBill.Amount;
                long price = importBill.Price;

                string beanTypeId = DatabaseConnection.GetBeanTypeIdByNameAndOrigin(beanName, origin);

                int loHangRowsAffected = DatabaseConnection.UpdateTableLoHang(categoryID, beanTypeId, productionDate, expireDate);
                int chiTietPhieuNhapRowsAffected = DatabaseConnection.UpdateTableChiTietPhieuNhap(billID, categoryID, beanTypeId, amount, price);

                if (loHangRowsAffected == 0 && chiTietPhieuNhapRowsAffected == 0)
                {
                    loHangTableAdapter.Insert(categoryID, beanTypeId, int.Parse(amount.ToString()), productionDate, expireDate);
                    chiTietPhieuNhapTableAdapter.Insert(billID, categoryID, beanTypeId, int.Parse(amount.ToString()), price);
                }
            }

            foreach(ImportBillItem item in deletedItems)
            {
                string beanName = item.BeanName;
                string origin = item.Origin;

                string beanTypeID = DatabaseConnection.GetBeanTypeIdByNameAndOrigin(beanName, origin);

                DatabaseConnection.DeleteRecordFromChiTietPhieuNhap(billID, categoryID, beanTypeID);
            }
        }

        private void SaveBill()
        {
            string importDateText = dateEditImportDate.Text;
            DateTime importDate;
            if(importDateText == null || importDateText == "")
                importDate = DateTime.Now;
            else
                importDate = DateTime.ParseExact(importDateText, DEFAULT_DATE_FORMAT, null);

            string billID = GenerateID("PNH", 6);
            string categoryID = GenerateID("SL", 6);
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
                    billID = GenerateID("PNH", 6);
                }

            } while (true);

            foreach (Control item in panelBillItem.Controls)
            {
                ImportBillItem billItem = item as ImportBillItem;

                string beanTypeID = "";
                string productionDateText = billItem.ProductionDate;
                DateTime productionDate;
                DateTime expireDate;
                long price = 0;

                if (productionDateText == null || productionDateText == "")
                    productionDate = DateTime.Now;
                else
                    productionDate = DateTime.ParseExact(productionDateText, DEFAULT_DATE_FORMAT, null);
                expireDate = productionDate.AddMonths(3);

                price = billItem.Price;
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
                    beanTypeID = GenerateBeanTypeID(name);
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
                        categoryID = GenerateID("SL", 6);
                    }

                } while (true);
            }
        }

    }
}