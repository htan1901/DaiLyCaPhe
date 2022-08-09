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
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new DevExpress.XtraEditors.LabelControl();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelLogin = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelAgencyName = new DevExpress.XtraEditors.LabelControl();
            this.tabNavigationPageProductManagement = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanelMain)).BeginInit();
            this.tabPanelMain.SuspendLayout();
            this.tabNavigationPageLogin.SuspendLayout();
            this.tableLayoutPanelDivideSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.tabPanelMain.Controls.Add(this.tabNavigationPageProductManagement);
            this.tabPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelMain.Location = new System.Drawing.Point(0, 28);
            this.tabPanelMain.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPanelMain.Name = "tabPanelMain";
            this.tabPanelMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageLogin,
            this.tabNavigationPageImportBill,
            this.tabNavigationPageExportBill,
            this.tabNavigationPageProcessPaper,
            this.tabNavigationPageProductManagement,
            this.tabNavigationPageAdmin});
            this.tabPanelMain.RegularSize = new System.Drawing.Size(1313, 847);
            this.tabPanelMain.SelectedPage = this.tabNavigationPageLogin;
            this.tabPanelMain.Size = new System.Drawing.Size(1313, 847);
            this.tabPanelMain.TabIndex = 0;
            this.tabPanelMain.Text = "Quản lý hóa đơn nhập";
            this.tabPanelMain.TabIndexChanged += new System.EventHandler(this.TabIndexChanged);
            // 
            // tabNavigationPageAdmin
            // 
            this.tabNavigationPageAdmin.Caption = "Quản trị viên";
            this.tabNavigationPageAdmin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabNavigationPageAdmin.Name = "tabNavigationPageAdmin";
            this.tabNavigationPageAdmin.Size = new System.Drawing.Size(1313, 847);
            // 
            // tabNavigationPageProcessPaper
            // 
            this.tabNavigationPageProcessPaper.Caption = "Quản lý chế biến";
            this.tabNavigationPageProcessPaper.Name = "tabNavigationPageProcessPaper";
            this.tabNavigationPageProcessPaper.Size = new System.Drawing.Size(1313, 847);
            // 
            // tabNavigationPageImportBill
            // 
            this.tabNavigationPageImportBill.Caption = "Quản lý hóa đơn nhập";
            this.tabNavigationPageImportBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabNavigationPageImportBill.Name = "tabNavigationPageImportBill";
            this.tabNavigationPageImportBill.Size = new System.Drawing.Size(1313, 847);
            // 
            // tabNavigationPageExportBill
            // 
            this.tabNavigationPageExportBill.Caption = "Quản lý hóa đơn xuất";
            this.tabNavigationPageExportBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabNavigationPageExportBill.Name = "tabNavigationPageExportBill";
            this.tabNavigationPageExportBill.Size = new System.Drawing.Size(1313, 847);
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
            this.checkBoxHiddenPassword.Location = new System.Drawing.Point(598, 556);
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
            this.buttonLogin.Location = new System.Drawing.Point(585, 601);
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
            this.tableLayoutPanelDivideSection.Controls.Add(this.labelPassword, 0, 3);
            this.tableLayoutPanelDivideSection.Controls.Add(this.textBoxPassword, 1, 3);
            this.tableLayoutPanelDivideSection.Controls.Add(this.labelUsername, 0, 2);
            this.tableLayoutPanelDivideSection.Controls.Add(this.textBoxUsername, 1, 2);
            this.tableLayoutPanelDivideSection.Controls.Add(this.labelLogin, 0, 1);
            this.tableLayoutPanelDivideSection.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanelDivideSection.Controls.Add(this.labelAgencyName, 1, 0);
            this.tableLayoutPanelDivideSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelDivideSection.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDivideSection.Name = "tableLayoutPanelDivideSection";
            this.tableLayoutPanelDivideSection.RowCount = 4;
            this.tableLayoutPanelDivideSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.41304F));
            this.tableLayoutPanelDivideSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.91304F));
            this.tableLayoutPanelDivideSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.64493F));
            this.tableLayoutPanelDivideSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.84783F));
            this.tableLayoutPanelDivideSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDivideSection.Size = new System.Drawing.Size(1313, 505);
            this.tableLayoutPanelDivideSection.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Appearance.Options.UseFont = true;
            this.labelPassword.Appearance.Options.UseTextOptions = true;
            this.labelPassword.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelPassword.Location = new System.Drawing.Point(19, 447);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelPassword.Size = new System.Drawing.Size(533, 28);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Mật khẩu:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(692, 444);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(500, 35);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Appearance.Options.UseFont = true;
            this.labelUsername.Appearance.Options.UseTextOptions = true;
            this.labelUsername.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelUsername.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelUsername.Location = new System.Drawing.Point(19, 347);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelUsername.Size = new System.Drawing.Size(533, 28);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Tên đăng nhập:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(692, 343);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(500, 35);
            this.textBoxUsername.TabIndex = 3;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Appearance.Options.UseFont = true;
            this.tableLayoutPanelDivideSection.SetColumnSpan(this.labelLogin, 2);
            this.labelLogin.Location = new System.Drawing.Point(554, 224);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(204, 40);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(406, 20);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 3, 50, 40);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(116, 107);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // labelAgencyName
            // 
            this.labelAgencyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAgencyName.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgencyName.Appearance.Options.UseFont = true;
            this.labelAgencyName.Location = new System.Drawing.Point(575, 68);
            this.labelAgencyName.Name = "labelAgencyName";
            this.labelAgencyName.Size = new System.Drawing.Size(386, 48);
            this.labelAgencyName.TabIndex = 6;
            this.labelAgencyName.Text = "Đại lý Cà phê HêHê";
            // 
            // tabNavigationPageProductManagement
            // 
            this.tabNavigationPageProductManagement.Caption = "Danh sách sản phẩm";
            this.tabNavigationPageProductManagement.Name = "tabNavigationPageProductManagement";
            this.tabNavigationPageProductManagement.Size = new System.Drawing.Size(1313, 806);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.Text = "Đại lý Cà phê HêHê";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPanelMain)).EndInit();
            this.tabPanelMain.ResumeLayout(false);
            this.tabNavigationPageLogin.ResumeLayout(false);
            this.tabNavigationPageLogin.PerformLayout();
            this.tableLayoutPanelDivideSection.ResumeLayout(false);
            this.tableLayoutPanelDivideSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxHiddenPassword;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageProductManagement;
        private System.Windows.Forms.PictureBox pictureBox;
        private DevExpress.XtraEditors.LabelControl labelAgencyName;
    }
}

