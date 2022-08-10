using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomControls;
using DaiLyCaPhe.Forms;
using DaiLyCaPhe.DBConnection;

namespace DaiLyCaPhe
{
    public partial class MainScreen : DevExpress.XtraEditors.XtraForm
    {
        private DatabaseConnection database = new DatabaseConnection();
        private ImportBillForm importBillForm = new ImportBillForm
        {
            TopLevel = false,
            Dock = DockStyle.Fill,
        };
        private ExportBillForm exportBillForm = new ExportBillForm
        {
            TopLevel = false,
            Dock = DockStyle.Fill,
        };
        private ProcessPaperForm processPaperForm = new ProcessPaperForm
        {
            TopLevel = false,
            Dock = DockStyle.Fill,
        };
        private AdminForm adminForm = new AdminForm
        {
            TopLevel = false,
            Dock = DockStyle.Fill,
        };
        private ProductManagementForm productManagementForm = new ProductManagementForm
        {
            TopLevel = false,
            Dock = DockStyle.Fill,
        };

        public MainScreen()
        {
            InitializeComponent();
        }

        private void LogOut()
        {
            DisableFeatures();
            tabNavigationPageLogin.Enabled = true;
            tabNavigationPageLogin.PageVisible = true;
            textBoxUsername.Text = null;
            textBoxPassword.Text = null;
            tabPanelMain.SelectedPage = tabNavigationPageLogin;
        }

        private void DisableFeatures()
        {
            tabNavigationPageImportBill.Enabled = false;
            tabNavigationPageExportBill.Enabled = false;
            tabNavigationPageProcessPaper.Enabled = false;
            tabNavigationPageImportBill.PageVisible = false;
            tabNavigationPageExportBill.PageVisible = false;
            tabNavigationPageProcessPaper.PageVisible = false;
            tabNavigationPageAdmin.Enabled = false;
            tabNavigationPageAdmin.PageVisible = false;
            tabNavigationPageProductManagement.Enabled = false;
            tabNavigationPageProductManagement.PageVisible = false;
        }

        private void EnableFeatures(int role)
        {
            if (role == 1)
            {
                tabNavigationPageImportBill.Enabled = true;
                tabNavigationPageExportBill.Enabled = true;
                tabNavigationPageAdmin.Enabled = true;

                tabNavigationPageImportBill.PageVisible = true;
                tabNavigationPageExportBill.PageVisible = true;
                tabNavigationPageAdmin.PageVisible = true;

            }
            tabNavigationPageProcessPaper.Enabled = true;
            tabNavigationPageProcessPaper.PageVisible = true;

            tabNavigationPageProductManagement.Enabled = true;
            tabNavigationPageProductManagement.PageVisible = true;

            tabNavigationPageLogin.Enabled = false;
            tabNavigationPageLogin.PageVisible = false;

            tabPanelMain.SelectedPage = tabNavigationPageProductManagement;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            tabNavigationPageImportBill.Controls.Add(importBillForm);
            importBillForm.Show();

            tabNavigationPageExportBill.Controls.Add(exportBillForm);
            exportBillForm.Show();

            tabNavigationPageProcessPaper.Controls.Add(processPaperForm);
            processPaperForm.Show();

            tabNavigationPageAdmin.Controls.Add(adminForm);
            adminForm.Show();

            tabNavigationPageProductManagement.Controls.Add(productManagementForm);
            productManagementForm.Show();
            
            DisableFeatures();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            int state = -1;

            object role = database.ValidateLoginInfo(username, password);
            if (role == null)
                MessageBox.Show("Sai thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK);
            else
            {
                if (bool.Parse(role.ToString()) == false)
                    state = 0;
                if (bool.Parse(role.ToString()) == true)
                    state = 1;
                EnableFeatures(state);
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            if(tabPanelMain.SelectedPage == tabNavigationPageLogin)
                return;

            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;
            LogOut();
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void HidePassword(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxHiddenPassword.Checked;
        }

        private void OnActivePage(object sender, EventArgs e)
        {
            ((Control)sender).Refresh();
        }
    }
}
