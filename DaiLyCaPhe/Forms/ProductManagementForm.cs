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
    public partial class ProductManagementForm : DevExpress.XtraEditors.XtraForm
    {
        public ProductManagementForm()
        {
            InitializeComponent();
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daiLyCaPheDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.daiLyCaPheDataSet.SanPham);
            // TODO: This line of code loads data into the 'daiLyCaPheDataSet.LoHang_SanPham' table. You can move, or remove it, as needed.
            this.loHang_SanPhamTableAdapter.Fill(this.daiLyCaPheDataSet.LoHang_SanPham);

        }

        private void labelProductNameFilter_Click(object sender, EventArgs e)
        {
            textBoxProductNameFilter.Focus();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.sanPhamTableAdapter.FillBy(this.daiLyCaPheDataSet.SanPham, tenSanPhamToolStripTextBox.Text, ((double)(System.Convert.ChangeType(trongLuongToolStripTextBox.Text, typeof(double)))), loaiSanPhamToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ProductFillEvent(object sender, EventArgs e)
        {
            string productName = textBoxProductNameFilter.Text;

            string fromWeightStr = textBoxFromWeightFilter.Text;
            float fromWeight = 0;
            try
            {
                if (fromWeightStr == "" || fromWeightStr == null)
                    fromWeight = 0;
                else
                    fromWeight = float.Parse(fromWeightStr);
            } 
            catch(Exception ex)
            {
            }

            string toWeightStr = textBoxToWeightFilter.Text;
            float toWeight = 100;
            try
            {
                if (toWeightStr == "" || toWeightStr == null)
                    toWeight = 100;
                else
                    toWeight = float.Parse(toWeightStr);
            } 
            catch(Exception ex)
            {
            }

            string productType = textBoxProductTypeFilter.Text;

            this.sanPhamTableAdapter.FillByNameAndWeightAndType(daiLyCaPheDataSet.SanPham, productName, fromWeight, toWeight, productType);
        }

        private void CategoryFillEvent(object sender, EventArgs e)
        {
            string categoryID = textBoxCategoryIDFilter.Text;
            string beanName = textBoxBeanNameFilter.Text;
            string origin = textBoxOriginFilter.Text;

            this.loHang_SanPhamTableAdapter.FillByCategoryAndNameAndOrigin(daiLyCaPheDataSet.LoHang_SanPham, categoryID, beanName, origin);
        }

        private void dataGridViewCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int index = e.RowIndex;
            string categoryID = dataGridViewCategories.Rows[index].Cells[0].Value.ToString();

            textBoxCategoryIDFilter.Text = categoryID;
        }

        private void buttonClearProductFilter_Click(object sender, EventArgs e)
        {
            textBoxProductNameFilter.Text = null;
            textBoxFromWeightFilter.Text = null;
            textBoxToWeightFilter.Text = null;
            textBoxProductTypeFilter.Text = null;
            sanPhamTableAdapter.Fill(daiLyCaPheDataSet.SanPham);
        }

        private void buttonClearCategoryFilter_Click(object sender, EventArgs e)
        {
            textBoxCategoryIDFilter.Text = null;
            textBoxBeanNameFilter.Text = null;
            textBoxOriginFilter.Text = null;

            loHang_SanPhamTableAdapter.Fill(daiLyCaPheDataSet.LoHang_SanPham);
        }
    }
}