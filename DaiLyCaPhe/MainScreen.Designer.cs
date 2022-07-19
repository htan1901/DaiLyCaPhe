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
            this.mainTabPanel = new DevExpress.XtraBars.Navigation.TabPane();
            this.importBillTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.addImportBillGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.sidePanel_addBillGroup = new DevExpress.XtraEditors.PanelControl();
            this.cancelBillButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveBillButton = new DevExpress.XtraEditors.SimpleButton();
            this.clearAllItemButton = new DevExpress.XtraEditors.SimpleButton();
            this.addItemButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.productionNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.productionNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.exportBillTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.coffeeTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.employeeTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.importBillItemPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mainTabPanel)).BeginInit();
            this.mainTabPanel.SuspendLayout();
            this.importBillTabNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addImportBillGroupControl)).BeginInit();
            this.addImportBillGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel_addBillGroup)).BeginInit();
            this.sidePanel_addBillGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabPanel
            // 
            this.mainTabPanel.Controls.Add(this.importBillTabNavigationPage);
            this.mainTabPanel.Controls.Add(this.exportBillTabNavigationPage);
            this.mainTabPanel.Controls.Add(this.coffeeTabNavigationPage);
            this.mainTabPanel.Controls.Add(this.employeeTabNavigationPage);
            this.mainTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTabPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTabPanel.Name = "mainTabPanel";
            this.mainTabPanel.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.importBillTabNavigationPage,
            this.exportBillTabNavigationPage,
            this.coffeeTabNavigationPage,
            this.employeeTabNavigationPage});
            this.mainTabPanel.RegularSize = new System.Drawing.Size(1113, 618);
            this.mainTabPanel.SelectedPage = this.importBillTabNavigationPage;
            this.mainTabPanel.Size = new System.Drawing.Size(1113, 618);
            this.mainTabPanel.TabIndex = 0;
            this.mainTabPanel.Text = "Quản lý hóa đơn nhập";
            // 
            // importBillTabNavigationPage
            // 
            this.importBillTabNavigationPage.Caption = "Quản lý hóa đơn nhập";
            this.importBillTabNavigationPage.Controls.Add(this.addImportBillGroupControl);
            this.importBillTabNavigationPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importBillTabNavigationPage.Name = "importBillTabNavigationPage";
            this.importBillTabNavigationPage.Size = new System.Drawing.Size(1113, 585);
            // 
            // addImportBillGroupControl
            // 
            this.addImportBillGroupControl.Controls.Add(this.importBillItemPanel);
            this.addImportBillGroupControl.Controls.Add(this.sidePanel_addBillGroup);
            this.addImportBillGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.addImportBillGroupControl.Location = new System.Drawing.Point(0, 0);
            this.addImportBillGroupControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addImportBillGroupControl.Name = "addImportBillGroupControl";
            this.addImportBillGroupControl.Size = new System.Drawing.Size(1113, 244);
            this.addImportBillGroupControl.TabIndex = 0;
            this.addImportBillGroupControl.Text = "Thêm hóa đơn nhập hàng";
            // 
            // sidePanel_addBillGroup
            // 
            this.sidePanel_addBillGroup.Controls.Add(this.cancelBillButton);
            this.sidePanel_addBillGroup.Controls.Add(this.saveBillButton);
            this.sidePanel_addBillGroup.Controls.Add(this.clearAllItemButton);
            this.sidePanel_addBillGroup.Controls.Add(this.addItemButton);
            this.sidePanel_addBillGroup.Controls.Add(this.labelControl1);
            this.sidePanel_addBillGroup.Controls.Add(this.productionNameTextEdit);
            this.sidePanel_addBillGroup.Controls.Add(this.productionNameLabel);
            this.sidePanel_addBillGroup.Controls.Add(this.dateEdit1);
            this.sidePanel_addBillGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel_addBillGroup.Location = new System.Drawing.Point(2, 23);
            this.sidePanel_addBillGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel_addBillGroup.Name = "sidePanel_addBillGroup";
            this.sidePanel_addBillGroup.Size = new System.Drawing.Size(280, 219);
            this.sidePanel_addBillGroup.TabIndex = 0;
            // 
            // cancelBillButton
            // 
            this.cancelBillButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBillButton.Appearance.Options.UseFont = true;
            this.cancelBillButton.Location = new System.Drawing.Point(146, 179);
            this.cancelBillButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBillButton.Name = "cancelBillButton";
            this.cancelBillButton.Size = new System.Drawing.Size(99, 24);
            this.cancelBillButton.TabIndex = 7;
            this.cancelBillButton.Text = "Hủy hóa đơn";
            // 
            // saveBillButton
            // 
            this.saveBillButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBillButton.Appearance.Options.UseFont = true;
            this.saveBillButton.Location = new System.Drawing.Point(17, 179);
            this.saveBillButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBillButton.Name = "saveBillButton";
            this.saveBillButton.Size = new System.Drawing.Size(99, 24);
            this.saveBillButton.TabIndex = 6;
            this.saveBillButton.Text = "Lưu hóa đơn";
            // 
            // clearAllItemButton
            // 
            this.clearAllItemButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllItemButton.Appearance.Options.UseFont = true;
            this.clearAllItemButton.Location = new System.Drawing.Point(146, 138);
            this.clearAllItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearAllItemButton.Name = "clearAllItemButton";
            this.clearAllItemButton.Size = new System.Drawing.Size(99, 24);
            this.clearAllItemButton.TabIndex = 5;
            this.clearAllItemButton.Text = "Xóa toàn bộ";
            // 
            // addItemButton
            // 
            this.addItemButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Appearance.Options.UseFont = true;
            this.addItemButton.Location = new System.Drawing.Point(17, 138);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(99, 24);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.Text = "Thêm sản phẩm";
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 73);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ngày nhập";
            // 
            // productionNameTextEdit
            // 
            this.productionNameTextEdit.Location = new System.Drawing.Point(17, 37);
            this.productionNameTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productionNameTextEdit.Name = "productionNameTextEdit";
            this.productionNameTextEdit.Size = new System.Drawing.Size(194, 20);
            this.productionNameTextEdit.TabIndex = 1;
            // 
            // productionNameLabel
            // 
            this.productionNameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionNameLabel.Appearance.Options.UseFont = true;
            this.productionNameLabel.Location = new System.Drawing.Point(17, 16);
            this.productionNameLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productionNameLabel.Name = "productionNameLabel";
            this.productionNameLabel.Size = new System.Drawing.Size(96, 14);
            this.productionNameLabel.TabIndex = 0;
            this.productionNameLabel.Text = "Tên nhà sản xuất";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(17, 93);
            this.dateEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dateEdit1.Properties.MaskSettings.Set("mask", "");
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1.Size = new System.Drawing.Size(194, 20);
            this.dateEdit1.TabIndex = 3;
            // 
            // exportBillTabNavigationPage
            // 
            this.exportBillTabNavigationPage.Caption = "Quản lý hóa đơn xuất";
            this.exportBillTabNavigationPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportBillTabNavigationPage.Name = "exportBillTabNavigationPage";
            this.exportBillTabNavigationPage.Size = new System.Drawing.Size(1113, 584);
            // 
            // coffeeTabNavigationPage
            // 
            this.coffeeTabNavigationPage.Caption = "Quản lý Cà phê";
            this.coffeeTabNavigationPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coffeeTabNavigationPage.Name = "coffeeTabNavigationPage";
            this.coffeeTabNavigationPage.Size = new System.Drawing.Size(1113, 618);
            // 
            // employeeTabNavigationPage
            // 
            this.employeeTabNavigationPage.Caption = "Quản lý nhân viên";
            this.employeeTabNavigationPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeTabNavigationPage.Name = "employeeTabNavigationPage";
            this.employeeTabNavigationPage.Size = new System.Drawing.Size(1113, 618);
            // 
            // importBillItemPanel
            // 
            this.importBillItemPanel.AutoScroll = true;
            this.importBillItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importBillItemPanel.Location = new System.Drawing.Point(282, 23);
            this.importBillItemPanel.Name = "importBillItemPanel";
            this.importBillItemPanel.Size = new System.Drawing.Size(829, 219);
            this.importBillItemPanel.TabIndex = 1;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 618);
            this.Controls.Add(this.mainTabPanel);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đại lý Cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.mainTabPanel)).EndInit();
            this.mainTabPanel.ResumeLayout(false);
            this.importBillTabNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addImportBillGroupControl)).EndInit();
            this.addImportBillGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel_addBillGroup)).EndInit();
            this.sidePanel_addBillGroup.ResumeLayout(false);
            this.sidePanel_addBillGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane mainTabPanel;
        private DevExpress.XtraBars.Navigation.TabNavigationPage importBillTabNavigationPage;
        private DevExpress.XtraBars.Navigation.TabNavigationPage exportBillTabNavigationPage;
        private DevExpress.XtraEditors.GroupControl addImportBillGroupControl;
        private DevExpress.XtraEditors.PanelControl sidePanel_addBillGroup;
        private DevExpress.XtraEditors.LabelControl productionNameLabel;
        private DevExpress.XtraBars.Navigation.TabNavigationPage coffeeTabNavigationPage;
        private DevExpress.XtraBars.Navigation.TabNavigationPage employeeTabNavigationPage;
        private DevExpress.XtraEditors.TextEdit productionNameTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.SimpleButton clearAllItemButton;
        private DevExpress.XtraEditors.SimpleButton addItemButton;
        private DevExpress.XtraEditors.SimpleButton cancelBillButton;
        private DevExpress.XtraEditors.SimpleButton saveBillButton;
        private System.Windows.Forms.Panel importBillItemPanel;
    }
}

