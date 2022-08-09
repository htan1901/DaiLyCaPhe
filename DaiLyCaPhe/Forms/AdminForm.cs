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

        private void ClearCurrentData()
        {
            textBoxUsername.Text = null;
            textBoxPassword.Text = null;
            textBoxRepeatPassword.Text = null;
            checkBoxIsAdmin.Checked = false;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daiLyCaPheDataSet.LoHang_SanPham' table. You can move, or remove it, as needed.
            this.loHang_SanPhamTableAdapter.Fill(this.daiLyCaPheDataSet.LoHang_SanPham);
            // TODO: This line of code loads data into the 'daiLyCaPheDataSet.LoHang' table. You can move, or remove it, as needed.
            this.loHangTableAdapter.Fill(this.daiLyCaPheDataSet.LoHang);
            // TODO: This line of code loads data into the 'daiLyCaPheDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.daiLyCaPheDataSet.SanPham);
            // TODO: This line of code loads data into the 'daiLyCaPheDataSet.ThongTinDangNhap' table. You can move, or remove it, as needed.
            this.thongTinDangNhapTableAdapter.Fill(this.daiLyCaPheDataSet.ThongTinDangNhap);
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
            ClearCurrentData();
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
            ClearCurrentData();
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

            ClearCurrentData();
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
    }
}