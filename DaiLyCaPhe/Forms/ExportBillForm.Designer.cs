using DaiLyCaPhe.DBConnection;

namespace DaiLyCaPhe.Forms
{
    partial class ExportBillForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAddBillGroup = new DevExpress.XtraEditors.PanelControl();
            this.buttonAddBill = new DevExpress.XtraEditors.SimpleButton();
            this.buttonModifyBill = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxBillID = new DevExpress.XtraEditors.TextEdit();
            this.labelBillID = new DevExpress.XtraEditors.LabelControl();
            this.dateEditExportDate = new DevExpress.XtraEditors.DateEdit();
            this.buttonDeleteBill = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSaveBill = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.labelImportDate = new DevExpress.XtraEditors.LabelControl();
            this.textBoxExportPlace = new DevExpress.XtraEditors.TextEdit();
            this.labelCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.panelBillDetails = new System.Windows.Forms.Panel();
            this.groupAddExportBill = new DevExpress.XtraEditors.GroupControl();
            this.panelFilterFunction = new System.Windows.Forms.Panel();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.panelBillDetailsFilter = new System.Windows.Forms.Panel();
            this.comboBoxProductTypeFilter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelProductTypeFilter = new System.Windows.Forms.Label();
            this.textBoxProductNameFilter = new System.Windows.Forms.TextBox();
            this.labelProductNameFilter = new System.Windows.Forms.Label();
            this.panelBillFilter = new System.Windows.Forms.Panel();
            this.labelToDateFilter = new System.Windows.Forms.Label();
            this.labelFromDateFilter = new System.Windows.Forms.Label();
            this.textBoxExportPlaceFilter = new System.Windows.Forms.TextBox();
            this.labelExportPlaceFilter = new System.Windows.Forms.Label();
            this.dateEditFromDateFilter = new DevExpress.XtraEditors.DateEdit();
            this.dateEditToDateFilter = new DevExpress.XtraEditors.DateEdit();
            this.panelDataSection = new System.Windows.Forms.Panel();
            this.panelDataImportBillDetails = new System.Windows.Forms.Panel();
            this.dataGridViewImportBIllDetail = new System.Windows.Forms.DataGridView();
            this.maPhieuXuatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTPXSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daiLyCaPheDataSet = new DaiLyCaPhe.DBConnection.DaiLyCaPheDataSet();
            this.labelExportBillDetailsTitle = new System.Windows.Forms.Label();
            this.panelDataImportBill = new System.Windows.Forms.Panel();
            this.dataGridViewImportBill = new System.Windows.Forms.DataGridView();
            this.maPhieuXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuXuatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelExportBillTitle = new System.Windows.Forms.Label();
            this.chiTietPhieuXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatHangTableAdapter = new DaiLyCaPhe.DBConnection.DaiLyCaPheDataSetTableAdapters.PhieuXuatHangTableAdapter();
            this.chiTietPhieuXuatTableAdapter = new DaiLyCaPhe.DBConnection.DaiLyCaPheDataSetTableAdapters.ChiTietPhieuXuatTableAdapter();
            this.CTPX_SanPhamTableAdapter = new DaiLyCaPhe.DBConnection.DaiLyCaPheDataSetTableAdapters.CTPX_SanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelAddBillGroup)).BeginInit();
            this.panelAddBillGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBillID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExportDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExportDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExportPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAddExportBill)).BeginInit();
            this.groupAddExportBill.SuspendLayout();
            this.panelFilterFunction.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.panelBillDetailsFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxProductTypeFilter.Properties)).BeginInit();
            this.panelBillFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFromDateFilter.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFromDateFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditToDateFilter.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditToDateFilter.Properties)).BeginInit();
            this.panelDataSection.SuspendLayout();
            this.panelDataImportBillDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportBIllDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLyCaPheDataSet)).BeginInit();
            this.panelDataImportBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuXuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddBillGroup
            // 
            this.panelAddBillGroup.Controls.Add(this.buttonAddBill);
            this.panelAddBillGroup.Controls.Add(this.buttonModifyBill);
            this.panelAddBillGroup.Controls.Add(this.textBoxBillID);
            this.panelAddBillGroup.Controls.Add(this.labelBillID);
            this.panelAddBillGroup.Controls.Add(this.dateEditExportDate);
            this.panelAddBillGroup.Controls.Add(this.buttonDeleteBill);
            this.panelAddBillGroup.Controls.Add(this.buttonSaveBill);
            this.panelAddBillGroup.Controls.Add(this.buttonCancel);
            this.panelAddBillGroup.Controls.Add(this.buttonAddItem);
            this.panelAddBillGroup.Controls.Add(this.labelImportDate);
            this.panelAddBillGroup.Controls.Add(this.textBoxExportPlace);
            this.panelAddBillGroup.Controls.Add(this.labelCompanyName);
            this.panelAddBillGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAddBillGroup.Location = new System.Drawing.Point(2, 28);
            this.panelAddBillGroup.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelAddBillGroup.Name = "panelAddBillGroup";
            this.panelAddBillGroup.Size = new System.Drawing.Size(327, 382);
            this.panelAddBillGroup.TabIndex = 0;
            // 
            // buttonAddBill
            // 
            this.buttonAddBill.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBill.Appearance.Options.UseFont = true;
            this.buttonAddBill.Location = new System.Drawing.Point(15, 288);
            this.buttonAddBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonAddBill.Name = "buttonAddBill";
            this.buttonAddBill.Size = new System.Drawing.Size(115, 30);
            this.buttonAddBill.TabIndex = 5;
            this.buttonAddBill.Text = "Thêm hóa đơn";
            this.buttonAddBill.Click += new System.EventHandler(this.ButtonAddBill_Click);
            // 
            // buttonModifyBill
            // 
            this.buttonModifyBill.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyBill.Appearance.Options.UseFont = true;
            this.buttonModifyBill.Location = new System.Drawing.Point(174, 288);
            this.buttonModifyBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonModifyBill.Name = "buttonModifyBill";
            this.buttonModifyBill.Size = new System.Drawing.Size(115, 30);
            this.buttonModifyBill.TabIndex = 6;
            this.buttonModifyBill.Text = "Sửa hóa đơn";
            this.buttonModifyBill.Click += new System.EventHandler(this.ButtonModifyBill_Click);
            // 
            // textBoxBillID
            // 
            this.textBoxBillID.Enabled = false;
            this.textBoxBillID.Location = new System.Drawing.Point(15, 41);
            this.textBoxBillID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxBillID.Name = "textBoxBillID";
            this.textBoxBillID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBillID.Properties.Appearance.Options.UseFont = true;
            this.textBoxBillID.Size = new System.Drawing.Size(299, 28);
            this.textBoxBillID.TabIndex = 9;
            // 
            // labelBillID
            // 
            this.labelBillID.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBillID.Appearance.Options.UseFont = true;
            this.labelBillID.Location = new System.Drawing.Point(15, 15);
            this.labelBillID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelBillID.Name = "labelBillID";
            this.labelBillID.Size = new System.Drawing.Size(79, 18);
            this.labelBillID.TabIndex = 8;
            this.labelBillID.Text = "Mã hóa đơn";
            // 
            // dateEditExportDate
            // 
            this.dateEditExportDate.EditValue = null;
            this.dateEditExportDate.Enabled = false;
            this.dateEditExportDate.Location = new System.Drawing.Point(15, 183);
            this.dateEditExportDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateEditExportDate.Name = "dateEditExportDate";
            this.dateEditExportDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditExportDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditExportDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditExportDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditExportDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditExportDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditExportDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditExportDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditExportDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dateEditExportDate.Size = new System.Drawing.Size(299, 28);
            this.dateEditExportDate.TabIndex = 2;
            // 
            // buttonDeleteBill
            // 
            this.buttonDeleteBill.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteBill.Appearance.Options.UseFont = true;
            this.buttonDeleteBill.Enabled = false;
            this.buttonDeleteBill.Location = new System.Drawing.Point(174, 239);
            this.buttonDeleteBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonDeleteBill.Name = "buttonDeleteBill";
            this.buttonDeleteBill.Size = new System.Drawing.Size(115, 30);
            this.buttonDeleteBill.TabIndex = 4;
            this.buttonDeleteBill.Text = "Xóa hóa đơn";
            this.buttonDeleteBill.Click += new System.EventHandler(this.buttonDeleteBill_Click);
            // 
            // buttonSaveBill
            // 
            this.buttonSaveBill.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveBill.Appearance.Options.UseFont = true;
            this.buttonSaveBill.Enabled = false;
            this.buttonSaveBill.Location = new System.Drawing.Point(15, 335);
            this.buttonSaveBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonSaveBill.Name = "buttonSaveBill";
            this.buttonSaveBill.Size = new System.Drawing.Size(115, 30);
            this.buttonSaveBill.TabIndex = 7;
            this.buttonSaveBill.Text = "Lưu ";
            this.buttonSaveBill.Click += new System.EventHandler(this.ButtonSaveBill_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Appearance.Options.UseFont = true;
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(174, 335);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 30);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.Appearance.Options.UseFont = true;
            this.buttonAddItem.Enabled = false;
            this.buttonAddItem.Location = new System.Drawing.Point(15, 239);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(115, 30);
            this.buttonAddItem.TabIndex = 3;
            this.buttonAddItem.Text = "Thêm sản phẩm";
            this.buttonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // labelImportDate
            // 
            this.labelImportDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImportDate.Appearance.Options.UseFont = true;
            this.labelImportDate.Location = new System.Drawing.Point(15, 161);
            this.labelImportDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelImportDate.Name = "labelImportDate";
            this.labelImportDate.Size = new System.Drawing.Size(68, 18);
            this.labelImportDate.TabIndex = 2;
            this.labelImportDate.Text = "Ngày xuất";
            // 
            // textBoxExportPlace
            // 
            this.textBoxExportPlace.Enabled = false;
            this.textBoxExportPlace.Location = new System.Drawing.Point(15, 109);
            this.textBoxExportPlace.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxExportPlace.Name = "textBoxExportPlace";
            this.textBoxExportPlace.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExportPlace.Properties.Appearance.Options.UseFont = true;
            this.textBoxExportPlace.Size = new System.Drawing.Size(299, 28);
            this.textBoxExportPlace.TabIndex = 1;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.Appearance.Options.UseFont = true;
            this.labelCompanyName.Location = new System.Drawing.Point(15, 83);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(54, 18);
            this.labelCompanyName.TabIndex = 0;
            this.labelCompanyName.Text = "Nơi xuất";
            // 
            // panelBillDetails
            // 
            this.panelBillDetails.AutoScroll = true;
            this.panelBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBillDetails.Location = new System.Drawing.Point(329, 28);
            this.panelBillDetails.Margin = new System.Windows.Forms.Padding(4);
            this.panelBillDetails.Name = "panelBillDetails";
            this.panelBillDetails.Size = new System.Drawing.Size(984, 382);
            this.panelBillDetails.TabIndex = 1;
            // 
            // groupAddExportBill
            // 
            this.groupAddExportBill.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAddExportBill.AppearanceCaption.Options.UseFont = true;
            this.groupAddExportBill.Controls.Add(this.panelBillDetails);
            this.groupAddExportBill.Controls.Add(this.panelAddBillGroup);
            this.groupAddExportBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupAddExportBill.Location = new System.Drawing.Point(0, 0);
            this.groupAddExportBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupAddExportBill.Name = "groupAddExportBill";
            this.groupAddExportBill.Size = new System.Drawing.Size(1315, 412);
            this.groupAddExportBill.TabIndex = 1;
            this.groupAddExportBill.Text = "Thêm hóa đơn xuất hàng";
            // 
            // panelFilterFunction
            // 
            this.panelFilterFunction.Controls.Add(this.groupBoxFilter);
            this.panelFilterFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterFunction.Location = new System.Drawing.Point(0, 412);
            this.panelFilterFunction.Name = "panelFilterFunction";
            this.panelFilterFunction.Size = new System.Drawing.Size(1315, 132);
            this.panelFilterFunction.TabIndex = 2;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.panelBillDetailsFilter);
            this.groupBoxFilter.Controls.Add(this.panelBillFilter);
            this.groupBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilter.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilter.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(1315, 132);
            this.groupBoxFilter.TabIndex = 1;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Bộ lọc";
            // 
            // panelBillDetailsFilter
            // 
            this.panelBillDetailsFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBillDetailsFilter.Controls.Add(this.comboBoxProductTypeFilter);
            this.panelBillDetailsFilter.Controls.Add(this.labelProductTypeFilter);
            this.panelBillDetailsFilter.Controls.Add(this.textBoxProductNameFilter);
            this.panelBillDetailsFilter.Controls.Add(this.labelProductNameFilter);
            this.panelBillDetailsFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBillDetailsFilter.Location = new System.Drawing.Point(554, 24);
            this.panelBillDetailsFilter.Name = "panelBillDetailsFilter";
            this.panelBillDetailsFilter.Size = new System.Drawing.Size(758, 105);
            this.panelBillDetailsFilter.TabIndex = 7;
            // 
            // comboBoxProductTypeFilter
            // 
            this.comboBoxProductTypeFilter.Location = new System.Drawing.Point(541, 39);
            this.comboBoxProductTypeFilter.Name = "comboBoxProductTypeFilter";
            this.comboBoxProductTypeFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductTypeFilter.Properties.Appearance.Options.UseFont = true;
            this.comboBoxProductTypeFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxProductTypeFilter.Properties.Items.AddRange(new object[] {
            "Hạt",
            "Bột"});
            this.comboBoxProductTypeFilter.Size = new System.Drawing.Size(166, 28);
            this.comboBoxProductTypeFilter.TabIndex = 6;
            this.comboBoxProductTypeFilter.TextChanged += new System.EventHandler(this.NameAndTypeFillEvent);
            // 
            // labelProductTypeFilter
            // 
            this.labelProductTypeFilter.AutoSize = true;
            this.labelProductTypeFilter.Location = new System.Drawing.Point(412, 42);
            this.labelProductTypeFilter.Name = "labelProductTypeFilter";
            this.labelProductTypeFilter.Size = new System.Drawing.Size(123, 21);
            this.labelProductTypeFilter.TabIndex = 4;
            this.labelProductTypeFilter.Text = "Loại sản phẩm:";
            // 
            // textBoxProductNameFilter
            // 
            this.textBoxProductNameFilter.Location = new System.Drawing.Point(171, 39);
            this.textBoxProductNameFilter.Name = "textBoxProductNameFilter";
            this.textBoxProductNameFilter.Size = new System.Drawing.Size(166, 28);
            this.textBoxProductNameFilter.TabIndex = 3;
            this.textBoxProductNameFilter.TextChanged += new System.EventHandler(this.NameAndTypeFillEvent);
            // 
            // labelProductNameFilter
            // 
            this.labelProductNameFilter.AutoSize = true;
            this.labelProductNameFilter.Location = new System.Drawing.Point(44, 42);
            this.labelProductNameFilter.Name = "labelProductNameFilter";
            this.labelProductNameFilter.Size = new System.Drawing.Size(121, 21);
            this.labelProductNameFilter.TabIndex = 2;
            this.labelProductNameFilter.Text = "Tên sản phẩm:";
            // 
            // panelBillFilter
            // 
            this.panelBillFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBillFilter.Controls.Add(this.labelToDateFilter);
            this.panelBillFilter.Controls.Add(this.labelFromDateFilter);
            this.panelBillFilter.Controls.Add(this.textBoxExportPlaceFilter);
            this.panelBillFilter.Controls.Add(this.labelExportPlaceFilter);
            this.panelBillFilter.Controls.Add(this.dateEditFromDateFilter);
            this.panelBillFilter.Controls.Add(this.dateEditToDateFilter);
            this.panelBillFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBillFilter.Location = new System.Drawing.Point(3, 24);
            this.panelBillFilter.Name = "panelBillFilter";
            this.panelBillFilter.Size = new System.Drawing.Size(551, 105);
            this.panelBillFilter.TabIndex = 6;
            // 
            // labelToDateFilter
            // 
            this.labelToDateFilter.AutoSize = true;
            this.labelToDateFilter.Location = new System.Drawing.Point(257, 64);
            this.labelToDateFilter.Name = "labelToDateFilter";
            this.labelToDateFilter.Size = new System.Drawing.Size(79, 21);
            this.labelToDateFilter.TabIndex = 5;
            this.labelToDateFilter.Text = "Tới ngày:";
            // 
            // labelFromDateFilter
            // 
            this.labelFromDateFilter.AutoSize = true;
            this.labelFromDateFilter.Location = new System.Drawing.Point(33, 64);
            this.labelFromDateFilter.Name = "labelFromDateFilter";
            this.labelFromDateFilter.Size = new System.Drawing.Size(76, 21);
            this.labelFromDateFilter.TabIndex = 4;
            this.labelFromDateFilter.Text = "Từ ngày:";
            // 
            // textBoxExportPlaceFilter
            // 
            this.textBoxExportPlaceFilter.Location = new System.Drawing.Point(188, 12);
            this.textBoxExportPlaceFilter.Name = "textBoxExportPlaceFilter";
            this.textBoxExportPlaceFilter.Size = new System.Drawing.Size(219, 28);
            this.textBoxExportPlaceFilter.TabIndex = 1;
            this.textBoxExportPlaceFilter.TextChanged += new System.EventHandler(this.PlaceAndDateFillEvent);
            // 
            // labelExportPlaceFilter
            // 
            this.labelExportPlaceFilter.AutoSize = true;
            this.labelExportPlaceFilter.Location = new System.Drawing.Point(33, 15);
            this.labelExportPlaceFilter.Name = "labelExportPlaceFilter";
            this.labelExportPlaceFilter.Size = new System.Drawing.Size(82, 21);
            this.labelExportPlaceFilter.TabIndex = 0;
            this.labelExportPlaceFilter.Text = "Nơi xuất: ";
            // 
            // dateEditFromDateFilter
            // 
            this.dateEditFromDateFilter.EditValue = null;
            this.dateEditFromDateFilter.Location = new System.Drawing.Point(115, 61);
            this.dateEditFromDateFilter.Name = "dateEditFromDateFilter";
            this.dateEditFromDateFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditFromDateFilter.Properties.Appearance.Options.UseFont = true;
            this.dateEditFromDateFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFromDateFilter.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFromDateFilter.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dateEditFromDateFilter.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditFromDateFilter.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditFromDateFilter.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditFromDateFilter.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditFromDateFilter.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dateEditFromDateFilter.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditFromDateFilter.Size = new System.Drawing.Size(125, 28);
            this.dateEditFromDateFilter.TabIndex = 2;
            this.dateEditFromDateFilter.TextChanged += new System.EventHandler(this.PlaceAndDateFillEvent);
            // 
            // dateEditToDateFilter
            // 
            this.dateEditToDateFilter.EditValue = null;
            this.dateEditToDateFilter.Location = new System.Drawing.Point(342, 61);
            this.dateEditToDateFilter.Name = "dateEditToDateFilter";
            this.dateEditToDateFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditToDateFilter.Properties.Appearance.Options.UseFont = true;
            this.dateEditToDateFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditToDateFilter.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditToDateFilter.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dateEditToDateFilter.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditToDateFilter.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditToDateFilter.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditToDateFilter.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditToDateFilter.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dateEditToDateFilter.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditToDateFilter.Size = new System.Drawing.Size(125, 28);
            this.dateEditToDateFilter.TabIndex = 3;
            this.dateEditToDateFilter.TextChanged += new System.EventHandler(this.PlaceAndDateFillEvent);
            // 
            // panelDataSection
            // 
            this.panelDataSection.Controls.Add(this.panelDataImportBillDetails);
            this.panelDataSection.Controls.Add(this.panelDataImportBill);
            this.panelDataSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataSection.Location = new System.Drawing.Point(0, 544);
            this.panelDataSection.Name = "panelDataSection";
            this.panelDataSection.Size = new System.Drawing.Size(1315, 281);
            this.panelDataSection.TabIndex = 3;
            // 
            // panelDataImportBillDetails
            // 
            this.panelDataImportBillDetails.AutoScroll = true;
            this.panelDataImportBillDetails.Controls.Add(this.dataGridViewImportBIllDetail);
            this.panelDataImportBillDetails.Controls.Add(this.labelExportBillDetailsTitle);
            this.panelDataImportBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataImportBillDetails.Location = new System.Drawing.Point(547, 0);
            this.panelDataImportBillDetails.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelDataImportBillDetails.Name = "panelDataImportBillDetails";
            this.panelDataImportBillDetails.Size = new System.Drawing.Size(768, 281);
            this.panelDataImportBillDetails.TabIndex = 2;
            // 
            // dataGridViewImportBIllDetail
            // 
            this.dataGridViewImportBIllDetail.AllowUserToAddRows = false;
            this.dataGridViewImportBIllDetail.AllowUserToDeleteRows = false;
            this.dataGridViewImportBIllDetail.AutoGenerateColumns = false;
            this.dataGridViewImportBIllDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewImportBIllDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewImportBIllDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImportBIllDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuXuatDataGridViewTextBoxColumn1,
            this.maSanPhamDataGridViewTextBoxColumn,
            this.TenSanPham,
            this.LoaiSanPham,
            this.TrongLuong,
            this.HanSuDung,
            this.SoLuong,
            this.donGiaDataGridViewTextBoxColumn});
            this.dataGridViewImportBIllDetail.DataSource = this.cTPXSanPhamBindingSource;
            this.dataGridViewImportBIllDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImportBIllDetail.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewImportBIllDetail.Name = "dataGridViewImportBIllDetail";
            this.dataGridViewImportBIllDetail.ReadOnly = true;
            this.dataGridViewImportBIllDetail.RowHeadersWidth = 51;
            this.dataGridViewImportBIllDetail.RowTemplate.Height = 24;
            this.dataGridViewImportBIllDetail.Size = new System.Drawing.Size(768, 252);
            this.dataGridViewImportBIllDetail.TabIndex = 3;
            // 
            // maPhieuXuatDataGridViewTextBoxColumn1
            // 
            this.maPhieuXuatDataGridViewTextBoxColumn1.DataPropertyName = "MaPhieuXuat";
            this.maPhieuXuatDataGridViewTextBoxColumn1.HeaderText = "MaPhieuXuat";
            this.maPhieuXuatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maPhieuXuatDataGridViewTextBoxColumn1.Name = "maPhieuXuatDataGridViewTextBoxColumn1";
            this.maPhieuXuatDataGridViewTextBoxColumn1.ReadOnly = true;
            this.maPhieuXuatDataGridViewTextBoxColumn1.Visible = false;
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            this.maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham";
            this.maSanPhamDataGridViewTextBoxColumn.HeaderText = "MaSanPham";
            this.maSanPhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
            this.maSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSanPhamDataGridViewTextBoxColumn.Visible = false;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // LoaiSanPham
            // 
            this.LoaiSanPham.DataPropertyName = "LoaiSanPham";
            this.LoaiSanPham.HeaderText = "Loại sản phẩm";
            this.LoaiSanPham.MinimumWidth = 6;
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.ReadOnly = true;
            // 
            // TrongLuong
            // 
            this.TrongLuong.DataPropertyName = "TrongLuong";
            this.TrongLuong.HeaderText = "Trọng lượng";
            this.TrongLuong.MinimumWidth = 6;
            this.TrongLuong.Name = "TrongLuong";
            this.TrongLuong.ReadOnly = true;
            // 
            // HanSuDung
            // 
            this.HanSuDung.DataPropertyName = "HanSuDung";
            this.HanSuDung.HeaderText = "Hạn sử dụng";
            this.HanSuDung.MinimumWidth = 6;
            this.HanSuDung.Name = "HanSuDung";
            this.HanSuDung.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cTPXSanPhamBindingSource
            // 
            this.cTPXSanPhamBindingSource.DataMember = "CTPX_SanPham";
            this.cTPXSanPhamBindingSource.DataSource = this.daiLyCaPheDataSet;
            // 
            // daiLyCaPheDataSet
            // 
            this.daiLyCaPheDataSet.DataSetName = "DaiLyCaPheDataSet";
            this.daiLyCaPheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelExportBillDetailsTitle
            // 
            this.labelExportBillDetailsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelExportBillDetailsTitle.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExportBillDetailsTitle.Location = new System.Drawing.Point(0, 0);
            this.labelExportBillDetailsTitle.Name = "labelExportBillDetailsTitle";
            this.labelExportBillDetailsTitle.Size = new System.Drawing.Size(768, 29);
            this.labelExportBillDetailsTitle.TabIndex = 2;
            this.labelExportBillDetailsTitle.Text = "CHI TIẾT HÓA ĐƠN XUẤT HÀNG";
            this.labelExportBillDetailsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDataImportBill
            // 
            this.panelDataImportBill.AutoScroll = true;
            this.panelDataImportBill.Controls.Add(this.dataGridViewImportBill);
            this.panelDataImportBill.Controls.Add(this.labelExportBillTitle);
            this.panelDataImportBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDataImportBill.Location = new System.Drawing.Point(0, 0);
            this.panelDataImportBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelDataImportBill.Name = "panelDataImportBill";
            this.panelDataImportBill.Size = new System.Drawing.Size(547, 281);
            this.panelDataImportBill.TabIndex = 1;
            // 
            // dataGridViewImportBill
            // 
            this.dataGridViewImportBill.AllowUserToAddRows = false;
            this.dataGridViewImportBill.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewImportBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImportBill.AutoGenerateColumns = false;
            this.dataGridViewImportBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewImportBill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewImportBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImportBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuXuatDataGridViewTextBoxColumn,
            this.noiXuatDataGridViewTextBoxColumn,
            this.ngayXuatDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn});
            this.dataGridViewImportBill.DataSource = this.phieuXuatHangBindingSource;
            this.dataGridViewImportBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImportBill.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewImportBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridViewImportBill.Name = "dataGridViewImportBill";
            this.dataGridViewImportBill.ReadOnly = true;
            this.dataGridViewImportBill.RowHeadersWidth = 51;
            this.dataGridViewImportBill.RowTemplate.Height = 24;
            this.dataGridViewImportBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewImportBill.Size = new System.Drawing.Size(547, 252);
            this.dataGridViewImportBill.TabIndex = 0;
            this.dataGridViewImportBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExportBill_CellContentClick);
            this.dataGridViewImportBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExportBill_CellContentClick);
            // 
            // maPhieuXuatDataGridViewTextBoxColumn
            // 
            this.maPhieuXuatDataGridViewTextBoxColumn.DataPropertyName = "MaPhieuXuat";
            this.maPhieuXuatDataGridViewTextBoxColumn.HeaderText = "MaPhieuXuat";
            this.maPhieuXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhieuXuatDataGridViewTextBoxColumn.Name = "maPhieuXuatDataGridViewTextBoxColumn";
            this.maPhieuXuatDataGridViewTextBoxColumn.ReadOnly = true;
            this.maPhieuXuatDataGridViewTextBoxColumn.Visible = false;
            // 
            // noiXuatDataGridViewTextBoxColumn
            // 
            this.noiXuatDataGridViewTextBoxColumn.DataPropertyName = "NoiXuat";
            this.noiXuatDataGridViewTextBoxColumn.HeaderText = "Nơi xuất";
            this.noiXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noiXuatDataGridViewTextBoxColumn.Name = "noiXuatDataGridViewTextBoxColumn";
            this.noiXuatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayXuatDataGridViewTextBoxColumn
            // 
            this.ngayXuatDataGridViewTextBoxColumn.DataPropertyName = "NgayXuat";
            this.ngayXuatDataGridViewTextBoxColumn.HeaderText = "Ngày xuất";
            this.ngayXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayXuatDataGridViewTextBoxColumn.Name = "ngayXuatDataGridViewTextBoxColumn";
            this.ngayXuatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tongTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phieuXuatHangBindingSource
            // 
            this.phieuXuatHangBindingSource.DataMember = "PhieuXuatHang";
            this.phieuXuatHangBindingSource.DataSource = this.daiLyCaPheDataSet;
            // 
            // labelExportBillTitle
            // 
            this.labelExportBillTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelExportBillTitle.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExportBillTitle.Location = new System.Drawing.Point(0, 0);
            this.labelExportBillTitle.Name = "labelExportBillTitle";
            this.labelExportBillTitle.Size = new System.Drawing.Size(547, 29);
            this.labelExportBillTitle.TabIndex = 1;
            this.labelExportBillTitle.Text = "DANH SÁCH HÓA ĐƠN XUẤT HÀNG\r\n";
            this.labelExportBillTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // chiTietPhieuXuatBindingSource
            // 
            this.chiTietPhieuXuatBindingSource.DataMember = "ChiTietPhieuXuat";
            this.chiTietPhieuXuatBindingSource.DataSource = this.daiLyCaPheDataSet;
            // 
            // phieuXuatHangTableAdapter
            // 
            this.phieuXuatHangTableAdapter.ClearBeforeFill = true;
            // 
            // chiTietPhieuXuatTableAdapter
            // 
            this.chiTietPhieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // CTPX_SanPhamTableAdapter
            // 
            this.CTPX_SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // ExportBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 825);
            this.Controls.Add(this.panelDataSection);
            this.Controls.Add(this.panelFilterFunction);
            this.Controls.Add(this.groupAddExportBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportBillForm";
            this.Text = "ImportBillForm";
            this.Load += new System.EventHandler(this.ExportBillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelAddBillGroup)).EndInit();
            this.panelAddBillGroup.ResumeLayout(false);
            this.panelAddBillGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBillID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExportDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditExportDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExportPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAddExportBill)).EndInit();
            this.groupAddExportBill.ResumeLayout(false);
            this.panelFilterFunction.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.panelBillDetailsFilter.ResumeLayout(false);
            this.panelBillDetailsFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxProductTypeFilter.Properties)).EndInit();
            this.panelBillFilter.ResumeLayout(false);
            this.panelBillFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFromDateFilter.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFromDateFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditToDateFilter.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditToDateFilter.Properties)).EndInit();
            this.panelDataSection.ResumeLayout(false);
            this.panelDataImportBillDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportBIllDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLyCaPheDataSet)).EndInit();
            this.panelDataImportBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuXuatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelAddBillGroup;
        private DevExpress.XtraEditors.SimpleButton buttonAddBill;
        private DevExpress.XtraEditors.SimpleButton buttonModifyBill;
        private DevExpress.XtraEditors.TextEdit textBoxBillID;
        private DevExpress.XtraEditors.LabelControl labelBillID;
        private DevExpress.XtraEditors.DateEdit dateEditExportDate;
        private DevExpress.XtraEditors.SimpleButton buttonDeleteBill;
        private DevExpress.XtraEditors.SimpleButton buttonSaveBill;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton buttonAddItem;
        private DevExpress.XtraEditors.LabelControl labelImportDate;
        private DevExpress.XtraEditors.TextEdit textBoxExportPlace;
        private DevExpress.XtraEditors.LabelControl labelCompanyName;
        private System.Windows.Forms.Panel panelBillDetails;
        private DevExpress.XtraEditors.GroupControl groupAddExportBill;
        private System.Windows.Forms.Panel panelFilterFunction;
        private System.Windows.Forms.Panel panelDataSection;
        private DaiLyCaPheDataSet daiLyCaPheDataSet;
        private System.Windows.Forms.BindingSource phieuXuatHangBindingSource;
        private DBConnection.DaiLyCaPheDataSetTableAdapters.PhieuXuatHangTableAdapter phieuXuatHangTableAdapter;
        private System.Windows.Forms.Panel panelDataImportBill;
        private System.Windows.Forms.DataGridView dataGridViewImportBill;
        private System.Windows.Forms.Panel panelDataImportBillDetails;
        private System.Windows.Forms.Label labelExportBillDetailsTitle;
        private System.Windows.Forms.BindingSource chiTietPhieuXuatBindingSource;
        private DBConnection.DaiLyCaPheDataSetTableAdapters.ChiTietPhieuXuatTableAdapter chiTietPhieuXuatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cTPXSanPhamBindingSource;
        private DBConnection.DaiLyCaPheDataSetTableAdapters.CTPX_SanPhamTableAdapter CTPX_SanPhamTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewImportBIllDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuXuatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Panel panelBillDetailsFilter;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxProductTypeFilter;
        private System.Windows.Forms.Label labelProductTypeFilter;
        private System.Windows.Forms.TextBox textBoxProductNameFilter;
        private System.Windows.Forms.Label labelProductNameFilter;
        private System.Windows.Forms.Panel panelBillFilter;
        private System.Windows.Forms.Label labelToDateFilter;
        private System.Windows.Forms.Label labelFromDateFilter;
        private System.Windows.Forms.TextBox textBoxExportPlaceFilter;
        private System.Windows.Forms.Label labelExportPlaceFilter;
        private DevExpress.XtraEditors.DateEdit dateEditFromDateFilter;
        private DevExpress.XtraEditors.DateEdit dateEditToDateFilter;
        private System.Windows.Forms.Label labelExportBillTitle;
    }
}