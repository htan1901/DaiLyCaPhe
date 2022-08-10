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
    public partial class AdminForm : DevExpress.XtraEditors.XtraForm
    {
        private const bool editable = true;
        private DatabaseConnection database = new DatabaseConnection();

        public AdminForm()
        {
            InitializeComponent();
        }
        
        private void ChangeState(bool state)
        {
            buttonAddAccount.Enabled = !state;
            buttonModifyAccount.Enabled = !state;
            buttonDeleteAccount.Enabled = !state;

            buttonSave.Enabled = state;
            buttonCancel.Enabled = state;
        }

        private void ToggleEditing(bool state)
        {
            textBoxUsername.Enabled = state;
            textBoxPassword.Enabled = state;
            textBoxRepeatPassword.Enabled = state;
            checkBoxIsAdmin.Enabled = state;
        }

        private void ClearCurrentAccountData()
        {
            textBoxUsername.Text = null;
            textBoxPassword.Text = null;
            textBoxRepeatPassword.Text = null;
            checkBoxIsAdmin.Checked = false;
        }
        private void ClearCurrentPricedata()
        {
            comboBoxBeanID.Text = null;
            textBoxBeanName.Text = null;
            textBoxNewPrice.Text = null;
            textBoxNewPrice.Text = null;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daiLyCaPheDataSet.LoaiHat_GiaBan' table. You can move, or remove it, as needed.
            this.loaiHat_GiaBanTableAdapter.Fill(this.daiLyCaPheDataSet.LoaiHat_GiaBan);
            // TODO: This line of code loads data into the 'daiLyCaPheDataSet.DonGia' table. You can move, or remove it, as needed.
            this.donGiaTableAdapter.Fill(this.daiLyCaPheDataSet.DonGia);
            this.loHang_SanPhamTableAdapter.Fill(this.daiLyCaPheDataSet.LoHang_SanPham);
            this.thongTinDangNhapTableAdapter.Fill(this.daiLyCaPheDataSet.ThongTinDangNhap);

            comboBoxBeanID.Items.Clear();
            List<string> ids = database.GetAllBeanIDs();
            foreach(string item in ids)
                comboBoxBeanID.Items.Add(item);

        }

        private void DataGridViewAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
                return;

            int index = e.RowIndex;
            string username = dataGridViewAccounts.Rows[index].Cells[1].Value.ToString();
            string password = dataGridViewAccounts.Rows[index].Cells[2].Value.ToString();
            bool isAdmin = (bool)dataGridViewAccounts.Rows[index].Cells[3].Value;

            textBoxUsername.Text = username;
            textBoxPassword.Text = password;
            checkBoxIsAdmin.Checked = isAdmin;
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            ClearCurrentAccountData();
            ChangeState(editable);
            ToggleEditing(editable);
            textBoxUsername.Focus();
        }

        private void buttonModifyAccount_Click(object sender, EventArgs e)
        {
            ChangeState(editable);
            ToggleEditing(editable);
            textBoxUsername.Enabled = false;
            textBoxPassword.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ChangeState(!editable);
            ToggleEditing(!editable);
            ClearCurrentAccountData();
        }
        
        private void SaveAccount(string username, string password, bool isAdmin)
        {
            thongTinDangNhapTableAdapter.Insert(username, password, isAdmin);
        }
        
        private void UpdateAccount(int accountID, string username, string password, bool isAdmin)
        {
            thongTinDangNhapTableAdapter.UpdateRecord(password, isAdmin, accountID, username);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string repeatPassword = textBoxRepeatPassword.Text.Trim();
            bool isAdmin = checkBoxIsAdmin.Checked;

            if(username == null || password == null || username == "" || password == "")
            {
                MessageBox.Show("Thông tin đăng nhập không được rỗng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(!password.Equals(repeatPassword))
            {
                MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải nhiều hơn 6 kí tự", "Thông báo", MessageBoxButtons.OK);
                return;
            }
                
            int isExist = database.IsAccountExist(textBoxUsername.Text);

            if (isExist == -1)
                SaveAccount(username, password, isAdmin);
            else
                UpdateAccount(isExist, username, password, isAdmin);

            AdminForm_Load(sender, e);

            ClearCurrentAccountData();
            ToggleEditing(!editable);
            ChangeState(!editable);
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            
            if(username == "admin")
            {
                MessageBox.Show("Không thể xóa tài khoản admin gốc");
                return;
            }

            DialogResult result = MessageBox.Show(string.Format("Tài khoản {0} sẽ bị xóa", username), "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            thongTinDangNhapTableAdapter.DeleteByUsername(textBoxUsername.Text);
            AdminForm_Load(sender, e);
        }

        private void dataGridViewPrices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int index = e.RowIndex;
            string beanID = dataGridViewPrices.Rows[index].Cells[0].Value.ToString();
            string beanName = dataGridViewPrices.Rows[index].Cells[1].Value.ToString();
            string beanOrigin = dataGridViewPrices.Rows[index].Cells[2].Value.ToString();
            string oldPrice = dataGridViewPrices.Rows[index].Cells[3].Value.ToString();

            comboBoxBeanID.Text = beanID;
            textBoxBeanName.Text = beanName;
            textBoxBeanOrigin.Text = beanOrigin;

            buttonSavePrice.Enabled = true;
            buttonCancelPrice.Enabled = true;

        }

        private void NumberOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string beanID = comboBoxBeanID.Text.Trim();
            string beanName = textBoxBeanName.Text;
            string beanOrigin = textBoxBeanOrigin.Text;
            string newPriceStr = textBoxNewPrice.Text.Trim();

            if(beanID == "" || beanID == null)
            {
                MessageBox.Show("Mã loại hạt không được rỗng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(newPriceStr == null || newPriceStr == "")
            {
                MessageBox.Show("Giá bán không được rỗng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            long newPrice = 0;
                
            if (!(newPriceStr == "" || newPriceStr == null))
                newPrice = long.Parse(newPriceStr);

            DateTime date = DateTime.Now;

            int rowAffected = database.UpdatePrice(beanID, date, newPrice);
            MessageBox.Show(rowAffected.ToString());

            ClearCurrentPricedata();

            comboBoxBeanID.Enabled = false;
            textBoxNewPrice.Enabled = false;

            buttonAddPrice.Enabled = true;
            buttonSavePrice.Enabled = false;
            buttonCancelPrice.Enabled = false;

            AdminForm_Load(sender, e);
        }

        private void buttonAddPrice_Click(object sender, EventArgs e)
        {
            comboBoxBeanID.Enabled = true;
            textBoxNewPrice.Enabled = true;
            buttonSavePrice.Enabled = true;
            buttonCancelPrice.Enabled = true;
            buttonAddPrice.Enabled = false;
        }

        private void AutoFillData(object sender, EventArgs e)
        {
            string beanID = comboBoxBeanID.Text;
            string beanName = database.GetBeanName(beanID);
            string origin = database.GetBeanOrigin(beanID);

            textBoxBeanName.Text = beanName;
            textBoxBeanOrigin.Text = origin;
        }

        private void buttonCancelPrice_Click(object sender, EventArgs e)
        {
            ClearCurrentPricedata();

            buttonAddPrice.Enabled = true;
            buttonSavePrice.Enabled = false;
            buttonCancelPrice.Enabled = false;
        }

        private void PreventSpace(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
    }
}