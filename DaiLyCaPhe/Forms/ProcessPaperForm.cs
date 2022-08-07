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
using DaiLyCaPhe.DBConnection;

namespace DaiLyCaPhe.Forms
{
    public partial class ProcessPaperForm : DevExpress.XtraEditors.XtraForm
    {
        private const string DEFAULT_DATE_FORMAT = "dd/MM/yyyy";
        private const string MIN_DATE_VALUE = "01/01/2000";
        private bool editable = true;
        private DatabaseConnection database = new DatabaseConnection();

        public ProcessPaperForm()
        {
            InitializeComponent();
        }

        #region Utility Methods
        
        public void ChangeState(bool state)
        {
            buttonAddPaper.Enabled = !state;
            buttonModifyPaper.Enabled = !state;
            buttonDeletePaper.Enabled = !state;

            buttonSavePaper.Enabled = state;
            buttonCancel.Enabled = state;
        }

        public void ClearCurrentData()
        {
            textBoxProcessPaperID.Text = null;
            comboBoxCategoryID.Text = null;
            dateEditProcessDate.Text = null;
            comboBoxProcessMakerID.Text = null;
            comboBoxBeanName.Text = null;
            comboBoxBeanOrigin.Text = null;
            textBoxProductName.Text = null;
            comboBoxProcessMethod.Text = null;
            comboBoxPackingMethod.Text = null;
            numericProcessAmount.Value = 0;
            checkBoxIsGrind.Checked = false;
            dateEditBeanExpireDate.Text = null;
        }

        public void ClearFilterData()
        {
            textBoxBeanNameFilter.Text = null;
            dateEditFromDateFilter.Text = null;
            dateEditToDateFilter.Text = null;
            textBoxProductMakerNameFilter.Text = null;
            textBoxProductNameFilter.Text = null;
        }

        public void ToggleEditing(bool isAllow)
        {
            comboBoxCategoryID.Enabled = isAllow;
            dateEditProcessDate.Enabled = isAllow;
            comboBoxProcessMakerID.Enabled = isAllow;
            comboBoxBeanName.Enabled = isAllow;
            comboBoxBeanOrigin.Enabled = isAllow;
            textBoxProductName.Enabled = isAllow;
            comboBoxProcessMethod.Enabled = isAllow;
            comboBoxPackingMethod.Enabled = isAllow;
            numericProcessAmount.Enabled = isAllow;
            checkBoxIsGrind.Enabled = isAllow;
            dateEditBeanExpireDate.Enabled = isAllow;

        }

        public string GeneratePaperID()
        {
            Random random = new Random();
            string prefix = "PCB";
            for(int i = 0; i < 3; i++)
            {
                int randNum = random.Next(100);
                prefix += (randNum < 10) ? ("0" + randNum) : randNum.ToString();
            }
            return prefix;
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

        public void UpdateBill()
        {
            try
            {
                string paperID = textBoxProcessPaperID.Text;
                string processDateStr = dateEditProcessDate.Text;
                string makerID = comboBoxProcessMakerID.Text;
                decimal amount = numericProcessAmount.Value;
                string categoryID = comboBoxCategoryID.Text;
                string beanName = comboBoxBeanName.Text;
                string beanOrigin = comboBoxBeanOrigin.Text;
                string expireDateStr = dateEditBeanExpireDate.Text.Substring(0, 10);
                string productName = textBoxProductName.Text;

                string processMethodID = database.GetProcessMethodID(comboBoxProcessMethod.Text);
                string packingMethodID = database.GetPackingMethodID(comboBoxPackingMethod.Text);
                bool isGrind = checkBoxIsGrind.Checked;
                string beanID = database.GetBeanTypeIdByNameAndOrigin(beanName, beanOrigin);
                string productID = database.GetProductID(paperID, categoryID, beanID);

                string productType = isGrind ? "Bột" : "Hạt";
                float weight = database.GetPackingWeight(packingMethodID);

                DateTime expireDate;
                if (expireDateStr == null || expireDateStr == "")
                    expireDate = DateTime.Now;
                else
                    expireDate = DateTime.ParseExact(expireDateStr, DEFAULT_DATE_FORMAT, null);

                DateTime processDate;
                if (processDateStr == "" || processDateStr == null)
                    processDate = DateTime.Now;
                else
                    processDate = DateTime.ParseExact(processDateStr, DEFAULT_DATE_FORMAT, null);

                int maximumAmount = database.GetLeftOverAmount(categoryID, beanID);
                if (amount < 1 || amount > maximumAmount)
                {
                    MessageBox.Show("Số lượng chế biến không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                database.UpdateTableSanPham(productID, productName, productType, weight, expireDate, (int)amount);
                database.UpdateTablePhieuCheBien(paperID, categoryID, beanID, processMethodID, packingMethodID, makerID, productID, isGrind, processDate, (int)amount);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void SaveBill()
        {
            try
            {
                string paperID = GeneratePaperID();
                string processDateStr = dateEditProcessDate.Text;
                string makerID = comboBoxProcessMakerID.Text;
                decimal amount = numericProcessAmount.Value;
                string categoryID = comboBoxCategoryID.Text;
                string beanName = comboBoxBeanName.Text;
                string beanOrigin = comboBoxBeanOrigin.Text;
                string expireDateStr = dateEditBeanExpireDate.Text.Substring(0, 10);
                string productName = textBoxProductName.Text;

                string processMethodID = database.GetProcessMethodID(comboBoxProcessMethod.Text);
                string packingMethodID = database.GetPackingMethodID(comboBoxPackingMethod.Text);
                bool isGrind = checkBoxIsGrind.Checked;
                string beanID = database.GetBeanTypeIdByNameAndOrigin(beanName, beanOrigin);
                string productID = GenerateProductID(beanID.Substring(0,3), processMethodID);

                string productType = isGrind ? "Bột" : "Hạt";
                float weight = database.GetPackingWeight(packingMethodID);
                DateTime expireDate;
                if (expireDateStr == null || expireDateStr == "")
                    expireDate = DateTime.Now;
                else
                    expireDate = DateTime.ParseExact(expireDateStr, DEFAULT_DATE_FORMAT, null);

                DateTime processDate;
                if (processDateStr == "" || processDateStr == null)
                    processDate = DateTime.Now;
                else
                    processDate = DateTime.ParseExact(processDateStr, DEFAULT_DATE_FORMAT, null);

                int maximumAmount = database.GetLeftOverAmount(categoryID, beanID);
                if (amount < 1 || amount > maximumAmount)
                {
                    MessageBox.Show("Số lượng chế biến không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                sanPhamTableAdapter.Insert(productID, productName, productType, weight, expireDate, (int)amount);
                phieuCheBienTableAdapter.Insert(paperID, categoryID, beanID, processMethodID, packingMethodID, makerID, productID, isGrind, processDate, (int)amount);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region Button Events
        
        private void ButtonAddPaper_Click(object sender, EventArgs e)
        {
            ClearCurrentData();
            ClearFilterData();
            ChangeState(editable);
            ToggleEditing(editable);
            dateEditProcessDate.Focus();
        }

        private void ButtonModifyPaper_Click(object sender, EventArgs e)
        {
            ClearFilterData();
            ToggleEditing(editable);
            ChangeState(editable);
            comboBoxBeanName.Enabled = false;
            comboBoxBeanOrigin.Enabled = false;
            comboBoxCategoryID.Enabled = false;
            dateEditBeanExpireDate.Enabled = false;
            dateEditProcessDate.Focus();
        }

        private void ButtonDeletePaper_Click(object sender, EventArgs e)
        {
            string paperID = textBoxProcessPaperID.Text;
            if (paperID == null || paperID == "")
                return;
            DialogResult result = MessageBox.Show(string.Format("Bạn muốn xóa phiếu chế biến {0}", paperID), "Thông báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
                database.DeleteRecordFromPhieuCheBien(paperID);
            ProcessBillForm_Load(sender, e);
        }

        private void buttonSavePaper_Click(object sender, EventArgs e)
        {
            string paperID = textBoxProcessPaperID.Text;
            if (paperID == "" || paperID == null)
                SaveBill();
            else
                UpdateBill();

            ClearCurrentData();
            ClearFilterData();
            ToggleEditing(!editable);
            ChangeState(!editable);
            ProcessBillForm_Load(sender, e);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearCurrentData();
            ClearFilterData();
            ToggleEditing(!editable);
            ChangeState(!editable);
        }

        #endregion



        private void ProcessBillForm_Load(object sender, EventArgs e)
        {
            this.phieuCheBienADVTableAdapter.Fill(this.daiLyCaPheDataSet.PhieuCheBienADV);

            List<string> listCategoryID = database.GetAllCategoryID();
            foreach(string item in listCategoryID)
                comboBoxCategoryID.Items.Add(item);

            List<string> processMethods = database.GetAllProcessMethod();
            foreach (string item in processMethods)
                comboBoxProcessMethod.Items.Add(item);

            List<string> packingMethods = database.GetAllPackingMethod();
            foreach (string item in packingMethods)
                comboBoxPackingMethod.Items.Add(item);

            List<string> makerNames = database.GetAllEmployeeIDs();
            foreach (string item in makerNames)
                comboBoxProcessMakerID.Items.Add(item);
        }

        private void dataGridViewProcessPaper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeState(!editable);
            ToggleEditing(!editable);
            if (e.RowIndex < 0)
                return;
            int index = e.RowIndex;

            string processParperID = dataGridViewProcessPaper.Rows[index].Cells[0].Value.ToString();
            string categoryID = dataGridViewProcessPaper.Rows[index].Cells[1].Value.ToString();
            string beanID = dataGridViewProcessPaper.Rows[index].Cells[2].Value.ToString();
            string productID = dataGridViewProcessPaper.Rows[index].Cells[3].Value.ToString();
            string processMethodID = dataGridViewProcessPaper.Rows[index].Cells[4].Value.ToString();
            string packagingMethodID = dataGridViewProcessPaper.Rows[index].Cells[5].Value.ToString();
            string beanName = dataGridViewProcessPaper.Rows[index].Cells[6].Value.ToString();
            string beanOrigin = dataGridViewProcessPaper.Rows[index].Cells[7].Value.ToString();
            string productName = dataGridViewProcessPaper.Rows[index].Cells[8].Value.ToString();
            string processMethodName = dataGridViewProcessPaper.Rows[index].Cells[9].Value.ToString();
            string amountPerPack = dataGridViewProcessPaper.Rows[index].Cells[10].Value.ToString();
            string packingMethodName = dataGridViewProcessPaper.Rows[index].Cells[11].Value.ToString();
            string productMakerName = dataGridViewProcessPaper.Rows[index].Cells[12].Value.ToString();
            bool isGrind = (bool)dataGridViewProcessPaper.Rows[index].Cells[13].Value;
            string processDate = dataGridViewProcessPaper.Rows[index].Cells[14].Value.ToString().Substring(0,10);
            string processAmount = dataGridViewProcessPaper.Rows[index].Cells[15].Value.ToString();
            string expireDate = database.GetExpireDate(categoryID, beanID).Substring(0,10);

            textBoxProcessPaperID.Text = processParperID;
            comboBoxCategoryID.Text = categoryID;
            dateEditProcessDate.Text = processDate;
            comboBoxProcessMakerID.Text = productMakerName;
            comboBoxBeanName.Text = beanName;
            comboBoxBeanOrigin.Text = beanOrigin;
            textBoxProductName.Text = productName;
            comboBoxProcessMethod.Text = processMethodName;
            comboBoxPackingMethod.Text = packingMethodName;
            numericProcessAmount.Value = int.Parse(processAmount);
            checkBoxIsGrind.Checked = isGrind;
            dateEditBeanExpireDate.Text = expireDate;
        }

        private void FillEvent(object sender, EventArgs e)
        {
            string makerName = textBoxProductMakerNameFilter.Text;
            DateTime fromDate;
            DateTime toDate;
            string fromDateStr = dateEditFromDateFilter.Text;
            string toDateStr = dateEditToDateFilter.Text;

            if (fromDateStr == null || fromDateStr == "")
                fromDate = DateTime.ParseExact(MIN_DATE_VALUE, DEFAULT_DATE_FORMAT, null);
            else
                fromDate = DateTime.ParseExact(fromDateStr, DEFAULT_DATE_FORMAT, null);

            if (toDateStr == null || toDateStr == "")
                toDate = DateTime.MaxValue;
            else
                toDate = DateTime.ParseExact(toDateStr, DEFAULT_DATE_FORMAT, null);

            string productName = textBoxProductNameFilter.Text;
            string beanName = textBoxBeanNameFilter.Text;


            this.phieuCheBienADVTableAdapter.FillByMaker_Date_Product_Bean(this.daiLyCaPheDataSet.PhieuCheBienADV, makerName, fromDate, toDate, productName, beanName);
        }

        private void comboBoxCategoryID_SelectedValueChanged(object sender, EventArgs e)
        {
            string categoryID = comboBoxCategoryID.Text;
            if (categoryID == "" || categoryID == null)
                return;
            comboBoxBeanName.Items.Clear();
            comboBoxBeanOrigin.Items.Clear();
            List<string> beanNames = new List<string>();
            beanNames = database.GetAllBeanName(categoryID);
            foreach(string item in beanNames)
                comboBoxBeanName.Items.Add(item);
        }

        private void comboBoxBeanName_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxBeanOrigin.Items.Clear();
            List<string> origins = new List<string>();
            string categoryID = comboBoxCategoryID.Text;
            string beanName = comboBoxBeanName.Text;
            origins = database.GetAllOrigin(categoryID, beanName);
            foreach (string item in origins)
                comboBoxBeanOrigin.Items.Add(item);
        }

        private void comboBoxBeanOrigin_SelectedValueChanged(object sender, EventArgs e)
        {
            string categoryID = comboBoxCategoryID.Text;
            string beanName = comboBoxBeanName.Text;
            string origin = comboBoxBeanOrigin.Text;
            dateEditBeanExpireDate.Text = database.GetExpireDate(categoryID, beanName, origin).Substring(0,10);
        }
    }
}