using DaiLyCaPhe.Forms;

namespace DaiLyCaPhe
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.tabPanelMain = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPageAdmin = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPageProcessPaper = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPageImportBill = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPageExportBill = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPageLogin = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.checkBoxHiddenPassword = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanelDivideSection = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new DevExpress.XtraEditors.LabelControl();
            this.labelUsername = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanelMain)).BeginInit();
            this.tabPanelMain.SuspendLayout();
            this.tabNavigationPageLogin.SuspendLayout();
            this.tableLayoutPanelDivideSection.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanelMain
            // 
            this.tabPanelMain.Controls.Add(this.tabNavigationPageAdmin);
            this.tabPanelMain.Controls.Add(this.tabNavigationPageProcessPaper);
            this.tabPanelMain.Controls.Add(this.tabNavigationPageImportBill);
            this.tabPanelMain.Controls.Add(this.tabNavigationPageExportBill);
            this.tabPanelMain.Controls.Add(this.tabNavigationPageLogin);
            this.tabPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelMain.Location = new System.Drawing.Point(0, 28);
            this.tabPanelMain.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPanelMain.Name = "tabPanelMain";
            this.tabPanelMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageLogin,
            this.tabNavigationPageImportBill,
            this.tabNavigationPageExportBill,
            this.tabNavigationPageProcessPaper,
            this.tabNavigationPageAdmin});
            this.tabPanelMain.RegularSize = new System.Drawing.Size(1313, 847);
            this.tabPanelMain.SelectedPage = this.tabNavigationPageLogin;
            this.tabPanelMain.Size = new System.Drawing.Size(1313, 847);
            this.tabPanelMain.TabIndex = 0;
            this.tabPanelMain.Text = "Quản lý hóa đơn nhập";
            // 
            // tabNavigationPageAdmin
            // 
            this.tabNavigationPageAdmin.Caption = "Quản trị viên";
            this.tabNavigationPageAdmin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabNavigationPageAdmin.Name = "tabNavigationPageAdmin";
            this.tabNavigationPageAdmin.Size = new System.Drawing.Size(1313, 806);
            // 
            // tabNavigationPageProcessPaper
            // 
            this.tabNavigationPageProcessPaper.Caption = "Quản lý chế biến";
            this.tabNavigationPageProcessPaper.Name = "tabNavigationPageProcessPaper";
            this.tabNavigationPageProcessPaper.Size = new System.Drawing.Size(1313, 806);
            // 
            // tabNavigationPageImportBill
            // 
            this.tabNavigationPageImportBill.Caption = "Quản lý hóa đơn nhập";
            this.tabNavigationPageImportBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabNavigationPageImportBill.Name = "tabNavigationPageImportBill";
            this.tabNavigationPageImportBill.Size = new System.Drawing.Size(1313, 834);
            // 
            // tabNavigationPageExportBill
            // 
            this.tabNavigationPageExportBill.Caption = "Quản lý hóa đơn xuất";
            this.tabNavigationPageExportBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabNavigationPageExportBill.Name = "tabNavigationPageExportBill";
            this.tabNavigationPageExportBill.Size = new System.Drawing.Size(1313, 875);
            // 
            // tabNavigationPageLogin
            // 
            this.tabNavigationPageLogin.Caption = "Đăng nhập";
            this.tabNavigationPageLogin.Controls.Add(this.checkBoxHiddenPassword);
            this.tabNavigationPageLogin.Controls.Add(this.buttonLogin);
            this.tabNavigationPageLogin.Controls.Add(this.tableLayoutPanelDivideSection);
            this.tabNavigationPageLogin.Name = "tabNavigationPageLogin";
            this.tabNavigationPageLogin.Size = new System.Drawing.Size(1313, 806);
            // 
            // checkBoxHiddenPassword
            // 
            this.checkBoxHiddenPassword.AutoSize = true;
            this.checkBoxHiddenPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHiddenPassword.Location = new System.Drawing.Point(601, 523);
            this.checkBoxHiddenPassword.Name = "checkBoxHiddenPassword";
            this.checkBoxHiddenPassword.Size = new System.Drawing.Size(163, 25);
            this.checkBoxHiddenPassword.TabIndex = 3;
            this.checkBoxHiddenPassword.Text = "Hiển thị mật khẩu";
            this.checkBoxHiddenPassword.UseVisualStyleBackColor = true;
            this.checkBoxHiddenPassword.CheckedChanged += new System.EventHandler(this.HidePassword);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(588, 568);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(138, 49);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // tableLayoutPanelDivideSection
            // 
            this.tableLayoutPanelDivideSection.ColumnCount = 2;
            this.tableLayoutPanelDivideSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.56436F));
            this.tableLayoutPanelDivideSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.43564F));
            this.tableLayoutPanelDivideSection.Controls.Add(this.textBoxPassword, 1, 2);
            this.tableLayoutPanelDivideSection.Controls.Add(this.labelLogin, 0, 0);
            this.tableLayoutPanelDivideSection.Controls.Add(this.labelUsername, 0, 1);
            this.tableLayoutPanelDivideSection.Controls.Add(this.labelControl1, 0, 2);
            this.tableLayoutPanelDivideSection.Controls.Add(this.textBoxUsername, 1, 1);
            this.tableLayoutPanelDivideSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelDivideSection.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDivideSection.Name = "tableLayoutPanelDivideSection";
            this.tableLayoutPanelDivideSection.RowCount = 3;
            this.tableLayoutPanelDivideSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.87428F));
            this.tableLayoutPanelDivideSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.07544F));
            this.tableLayoutPanelDivideSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.85687F));
            this.tableLayoutPanelDivideSection.Size = new System.Drawing.Size(1313, 517);
            this.tableLayoutPanelDivideSection.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(692, 442);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(500, 35);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Appearance.Options.UseFont = true;
            this.tableLayoutPanelDivideSection.SetColumnSpan(this.labelLogin, 2);
            this.labelLogin.Location = new System.Drawing.Point(554, 96);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(204, 40);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "ĐĂNG NHẬP";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Appearance.Options.UseFont = true;
            this.labelUsername.Appearance.Options.UseTextOptions = true;
            this.labelUsername.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelUsername.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelUsername.Location = new System.Drawing.Point(19, 303);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelUsername.Size = new System.Drawing.Size(533, 28);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Tên đăng nhập:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(19, 446);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelControl1.Size = new System.Drawing.Size(533, 28);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mật khẩu:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(692, 300);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(500, 35);
            this.textBoxUsername.TabIndex = 3;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainMenuStrip.Size = new System.Drawing.Size(1313, 28);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.logOutToolStripMenuItem.Text = "Đăng xuất";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOut_Click);
            // 
            // MainScreen
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 875);
            this.Controls.Add(this.tabPanelMain);
            this.Controls.Add(this.mainMenuStrip);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainScreen.IconOptions.Image")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đại lý Cà phê";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPanelMain)).EndInit();
            this.tabPanelMain.ResumeLayout(false);
            this.tabNavigationPageLogin.ResumeLayout(false);
            this.tabNavigationPageLogin.PerformLayout();
            this.tableLayoutPanelDivideSection.ResumeLayout(false);
            this.tableLayoutPanelDivideSection.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPanelMain;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageImportBill;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageExportBill;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageAdmin;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageProcessPaper;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDivideSection;
        private DevExpress.XtraEditors.LabelControl labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private DevExpress.XtraEditors.LabelControl labelUsername;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxHiddenPassword;
    }
}

