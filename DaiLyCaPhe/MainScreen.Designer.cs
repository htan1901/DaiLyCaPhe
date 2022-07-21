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
            this.tabPanelMain = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPageImportBill = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPageExportBill = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPageCoffee = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPageEmployee = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.formImportBill = new ImportBillForm();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanelMain)).BeginInit();
            this.tabPanelMain.SuspendLayout();
            this.SuspendLayout();
            //
            // formImportBill
            //
            this.formImportBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formImportBill.TopLevel = false;
            this.formImportBill.AutoScroll = true;
            this.formImportBill.Show();
            // 
            // tabPanelMain
            // 
            this.tabPanelMain.Controls.Add(this.tabNavigationPageImportBill);
            this.tabPanelMain.Controls.Add(this.tabNavigationPageExportBill);
            this.tabPanelMain.Controls.Add(this.tabNavigationPageCoffee);
            this.tabPanelMain.Controls.Add(this.tabNavigationPageEmployee);
            this.tabPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tabPanelMain.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPanelMain.Name = "tabPanelMain";
            this.tabPanelMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageImportBill,
            this.tabNavigationPageExportBill,
            this.tabNavigationPageCoffee,
            this.tabNavigationPageEmployee});
            this.tabPanelMain.RegularSize = new System.Drawing.Size(1298, 761);
            this.tabPanelMain.SelectedPage = this.tabNavigationPageImportBill;
            this.tabPanelMain.Size = new System.Drawing.Size(1298, 761);
            this.tabPanelMain.TabIndex = 0;
            this.tabPanelMain.Text = "Quản lý hóa đơn nhập";
            // 
            // tabNavigationPageImportBill
            // 
            this.tabNavigationPageImportBill.Caption = "Quản lý hóa đơn nhập";
            this.tabNavigationPageImportBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabNavigationPageImportBill.Name = "tabNavigationPageImportBill";
            this.tabNavigationPageImportBill.Size = new System.Drawing.Size(1298, 720);
            this.tabNavigationPageImportBill.Controls.Add(formImportBill);
            // 
            // tabNavigationPageExportBill
            // 
            this.tabNavigationPageExportBill.Caption = "Quản lý hóa đơn xuất";
            this.tabNavigationPageExportBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabNavigationPageExportBill.Name = "tabNavigationPageExportBill";
            this.tabNavigationPageExportBill.Size = new System.Drawing.Size(1298, 720);
            // 
            // tabNavigationPageCoffee
            // 
            this.tabNavigationPageCoffee.Caption = "Quản lý Cà phê";
            this.tabNavigationPageCoffee.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabNavigationPageCoffee.Name = "tabNavigationPageCoffee";
            this.tabNavigationPageCoffee.Size = new System.Drawing.Size(1298, 720);
            // 
            // tabNavigationPageEmployee
            // 
            this.tabNavigationPageEmployee.Caption = "Quản lý nhân viên";
            this.tabNavigationPageEmployee.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabNavigationPageEmployee.Name = "tabNavigationPageEmployee";
            this.tabNavigationPageEmployee.Size = new System.Drawing.Size(1298, 761);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 761);
            this.Controls.Add(this.tabPanelMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đại lý Cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.tabPanelMain)).EndInit();
            this.tabPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPanelMain;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageImportBill;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageExportBill;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageCoffee;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPageEmployee;
        private ImportBillForm formImportBill;
    }
}

