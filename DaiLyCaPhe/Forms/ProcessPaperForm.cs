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

namespace DaiLyCaPhe.Forms
{
    public partial class ProcessPaperForm : DevExpress.XtraEditors.XtraForm
    {
        public ProcessPaperForm()
        {
            InitializeComponent();
        }

        private void ProcessBillForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daiLyCaPheDataSet.PhieuCheBienADV' table. You can move, or remove it, as needed.
            this.phieuCheBienADVTableAdapter.Fill(this.daiLyCaPheDataSet.PhieuCheBienADV);
            // TODO: This line of code loads data into the 'daiLyCaPheDataSet.PhieuCheBien' table. You can move, or remove it, as needed.
            this.phieuCheBienTableAdapter.Fill(this.daiLyCaPheDataSet.PhieuCheBien);

        }

        private void dataGridViewProcessPaper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
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
            string processDate = dataGridViewProcessPaper.Rows[index].Cells[14].Value.ToString();
            string processAmount = dataGridViewProcessPaper.Rows[index].Cells[15].Value.ToString();

            textBoxProcessPaperID.Text = processParperID;
            comboBoxCategoryID.Text = categoryID;
            dateEditProcessDate.Text = processDate;
            textBoxProcessMakerName.Text = productMakerName;
            textBoxBeanName.Text = beanName;
            textBoxBeanOrigin.Text = beanOrigin;
            textBoxProductName.Text = productName;
            comboBoxProcessMethod.Text = processMethodName;
            comboBoxPackagingMethod.Text = packingMethodName;
            numericProcessAmount.Value = int.Parse(processAmount);
            checkBoxIsGrind.Checked = isGrind;
        }
    }
}