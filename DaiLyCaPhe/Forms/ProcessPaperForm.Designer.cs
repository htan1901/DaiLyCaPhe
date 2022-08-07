namespace DaiLyCaPhe.Forms
{
    partial class ProcessPaperForm
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
            this.groupAddProcessPaper = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxProcessMakerID = new System.Windows.Forms.ComboBox();
            this.comboBoxBeanOrigin = new System.Windows.Forms.ComboBox();
            this.comboBoxBeanName = new System.Windows.Forms.ComboBox();
            this.textBoxProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxCategoryID = new System.Windows.Forms.ComboBox();
            this.checkBoxIsGrind = new DevExpress.XtraEditors.CheckEdit();
            this.labelBeanID = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxPackingMethod = new System.Windows.Forms.ComboBox();
            this.comboBoxProcessMethod = new System.Windows.Forms.ComboBox();
            this.numericProcessAmount = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddPaper = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDeletePaper = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSavePaper = new DevExpress.XtraEditors.SimpleButton();
            this.buttonModifyPaper = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxProcessPaperID = new DevExpress.XtraEditors.TextEdit();
            this.dateEditBeanExpireDate = new DevExpress.XtraEditors.DateEdit();
            this.labelProcessMethod = new DevExpress.XtraEditors.LabelControl();
            this.dateEditProcessDate = new DevExpress.XtraEditors.DateEdit();
            this.labelBeanName = new DevExpress.XtraEditors.LabelControl();
            this.labelPaperID = new DevExpress.XtraEditors.LabelControl();
            this.labelPackagingMethod = new DevExpress.XtraEditors.LabelControl();
            this.labelOrigin = new DevExpress.XtraEditors.LabelControl();
            this.labelAmount = new DevExpress.XtraEditors.LabelControl();
            this.labelBeanExpireDate = new DevExpress.XtraEditors.LabelControl();
            this.labelEmployeeName = new DevExpress.XtraEditors.LabelControl();
            this.labelProcessDate = new DevExpress.XtraEditors.LabelControl();
            this.panelFilterFunction = new System.Windows.Forms.Panel();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.panelBillDetailsFilter = new System.Windows.Forms.Panel();
            this.textBoxBeanNameFilter = new DevExpress.XtraEditors.TextEdit();
            this.labelBeanNameFilter = new System.Windows.Forms.Label();
            this.textBoxProductNameFilter = new System.Windows.Forms.TextBox();
            this.labelProductNameFilter = new System.Windows.Forms.Label();
            this.panelBillFilter = new System.Windows.Forms.Panel();
            this.labelToDateFilter = new System.Windows.Forms.Label();
            this.labelFromDateFilter = new System.Windows.Forms.Label();
            this.textBoxProductMakerNameFilter = new System.Windows.Forms.TextBox();
            this.labelProductMaker = new System.Windows.Forms.Label();
            this.dateEditFromDateFilter = new DevExpress.XtraEditors.DateEdit();
            this.dateEditToDateFilter = new DevExpress.XtraEditors.DateEdit();
            this.panelDataSection = new System.Windows.Forms.Panel();
            this.panelDataImportBill = new System.Windows.Forms.Panel();
            this.dataGridViewProcessPaper = new System.Windows.Forms.DataGridView();
            this.labelExportBillTitle = new System.Windows.Forms.Label();
            this.phieuCheBienADVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daiLyCaPheDataSet = new DaiLyCaPhe.DaiLyCaPheDataSet();
            this.loHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cachDongGoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phuongPhapCheBienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuCheBienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuCheBienTableAdapter = new DaiLyCaPhe.DaiLyCaPheDataSetTableAdapters.PhieuCheBienTableAdapter();
            this.phieuCheBienADVTableAdapter = new DaiLyCaPhe.DaiLyCaPheDataSetTableAdapters.PhieuCheBienADVTableAdapter();
            this.loHangTableAdapter = new DaiLyCaPhe.DaiLyCaPheDataSetTableAdapters.LoHangTableAdapter();
            this.phuongPhapCheBienTableAdapter = new DaiLyCaPhe.DaiLyCaPheDataSetTableAdapters.PhuongPhapCheBienTableAdapter();
            this.cachDongGoiTableAdapter = new DaiLyCaPhe.DaiLyCaPheDataSetTableAdapters.CachDongGoiTableAdapter();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableAdapter = new DaiLyCaPhe.DaiLyCaPheDataSetTableAdapters.SanPhamTableAdapter();
            this.maPhieuCheBienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLoHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiHatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPPCheBienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCachDongGoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiHat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachCheBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongMoiGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDongGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xayDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ngayCheBienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongCheBienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupAddProcessPaper)).BeginInit();
            this.groupAddProcessPaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxIsGrind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProcessAmount)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProcessPaperID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBeanExpireDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBeanExpireDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditProcessDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditProcessDate.Properties)).BeginInit();
            this.panelFilterFunction.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.panelBillDetailsFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBeanNameFilter.Properties)).BeginInit();
            this.panelBillFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFromDateFilter.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFromDateFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditToDateFilter.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditToDateFilter.Properties)).BeginInit();
            this.panelDataSection.SuspendLayout();
            this.panelDataImportBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuCheBienADVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLyCaPheDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachDongGoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phuongPhapCheBienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuCheBienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAddProcessPaper
            // 
            this.groupAddProcessPaper.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAddProcessPaper.AppearanceCaption.Options.UseFont = true;
            this.groupAddProcessPaper.Controls.Add(this.comboBoxProcessMakerID);
            this.groupAddProcessPaper.Controls.Add(this.comboBoxBeanOrigin);
            this.groupAddProcessPaper.Controls.Add(this.comboBoxBeanName);
            this.groupAddProcessPaper.Controls.Add(this.textBoxProductName);
            this.groupAddProcessPaper.Controls.Add(this.labelControl1);
            this.groupAddProcessPaper.Controls.Add(this.comboBoxCategoryID);
            this.groupAddProcessPaper.Controls.Add(this.checkBoxIsGrind);
            this.groupAddProcessPaper.Controls.Add(this.labelBeanID);
            this.groupAddProcessPaper.Controls.Add(this.comboBoxPackingMethod);
            this.groupAddProcessPaper.Controls.Add(this.comboBoxProcessMethod);
            this.groupAddProcessPaper.Controls.Add(this.numericProcessAmount);
            this.groupAddProcessPaper.Controls.Add(this.tableLayoutPanel1);
            this.groupAddProcessPaper.Controls.Add(this.textBoxProcessPaperID);
            this.groupAddProcessPaper.Controls.Add(this.dateEditBeanExpireDate);
            this.groupAddProcessPaper.Controls.Add(this.labelProcessMethod);
            this.groupAddProcessPaper.Controls.Add(this.dateEditProcessDate);
            this.groupAddProcessPaper.Controls.Add(this.labelBeanName);
            this.groupAddProcessPaper.Controls.Add(this.labelPaperID);
            this.groupAddProcessPaper.Controls.Add(this.labelPackagingMethod);
            this.groupAddProcessPaper.Controls.Add(this.labelOrigin);
            this.groupAddProcessPaper.Controls.Add(this.labelAmount);
            this.groupAddProcessPaper.Controls.Add(this.labelBeanExpireDate);
            this.groupAddProcessPaper.Controls.Add(this.labelEmployeeName);
            this.groupAddProcessPaper.Controls.Add(this.labelProcessDate);
            this.groupAddProcessPaper.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupAddProcessPaper.Location = new System.Drawing.Point(0, 0);
            this.groupAddProcessPaper.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupAddProcessPaper.Name = "groupAddProcessPaper";
            this.groupAddProcessPaper.Size = new System.Drawing.Size(1313, 412);
            this.groupAddProcessPaper.TabIndex = 2;
            this.groupAddProcessPaper.Text = "Thêm phiếu chế biến";
            // 
            // comboBoxProcessMakerID
            // 
            this.comboBoxProcessMakerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcessMakerID.Enabled = false;
            this.comboBoxProcessMakerID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProcessMakerID.FormattingEnabled = true;
            this.comboBoxProcessMakerID.Location = new System.Drawing.Point(680, 75);
            this.comboBoxProcessMakerID.Name = "comboBoxProcessMakerID";
            this.comboBoxProcessMakerID.Size = new System.Drawing.Size(240, 29);
            this.comboBoxProcessMakerID.TabIndex = 27;
            // 
            // comboBoxBeanOrigin
            // 
            this.comboBoxBeanOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBeanOrigin.Enabled = false;
            this.comboBoxBeanOrigin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBeanOrigin.FormattingEnabled = true;
            this.comboBoxBeanOrigin.Location = new System.Drawing.Point(680, 140);
            this.comboBoxBeanOrigin.Name = "comboBoxBeanOrigin";
            this.comboBoxBeanOrigin.Size = new System.Drawing.Size(240, 29);
            this.comboBoxBeanOrigin.TabIndex = 26;
            this.comboBoxBeanOrigin.SelectedValueChanged += new System.EventHandler(this.comboBoxBeanOrigin_SelectedValueChanged);
            // 
            // comboBoxBeanName
            // 
            this.comboBoxBeanName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBeanName.Enabled = false;
            this.comboBoxBeanName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBeanName.FormattingEnabled = true;
            this.comboBoxBeanName.Location = new System.Drawing.Point(360, 138);
            this.comboBoxBeanName.Name = "comboBoxBeanName";
            this.comboBoxBeanName.Size = new System.Drawing.Size(240, 29);
            this.comboBoxBeanName.TabIndex = 25;
            this.comboBoxBeanName.SelectedValueChanged += new System.EventHandler(this.comboBoxBeanName_SelectedValueChanged);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Enabled = false;
            this.textBoxProductName.Location = new System.Drawing.Point(41, 210);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Properties.Appearance.Options.UseFont = true;
            this.textBoxProductName.Size = new System.Drawing.Size(240, 28);
            this.textBoxProductName.TabIndex = 24;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(40, 185);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 18);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Tên sản phẩm";
            // 
            // comboBoxCategoryID
            // 
            this.comboBoxCategoryID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.loHangBindingSource, "SoLoHang", true));
            this.comboBoxCategoryID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryID.Enabled = false;
            this.comboBoxCategoryID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoryID.FormattingEnabled = true;
            this.comboBoxCategoryID.Location = new System.Drawing.Point(40, 140);
            this.comboBoxCategoryID.Name = "comboBoxCategoryID";
            this.comboBoxCategoryID.Size = new System.Drawing.Size(240, 29);
            this.comboBoxCategoryID.TabIndex = 21;
            this.comboBoxCategoryID.SelectedValueChanged += new System.EventHandler(this.comboBoxCategoryID_SelectedValueChanged);
            // 
            // checkBoxIsGrind
            // 
            this.checkBoxIsGrind.Enabled = false;
            this.checkBoxIsGrind.Location = new System.Drawing.Point(1000, 208);
            this.checkBoxIsGrind.Name = "checkBoxIsGrind";
            this.checkBoxIsGrind.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsGrind.Properties.Appearance.Options.UseFont = true;
            this.checkBoxIsGrind.Properties.Caption = "Xay";
            this.checkBoxIsGrind.Size = new System.Drawing.Size(121, 25);
            this.checkBoxIsGrind.TabIndex = 20;
            // 
            // labelBeanID
            // 
            this.labelBeanID.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeanID.Appearance.Options.UseFont = true;
            this.labelBeanID.Location = new System.Drawing.Point(40, 115);
            this.labelBeanID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelBeanID.Name = "labelBeanID";
            this.labelBeanID.Size = new System.Drawing.Size(52, 18);
            this.labelBeanID.TabIndex = 18;
            this.labelBeanID.Text = "Lô hàng";
            // 
            // comboBoxPackingMethod
            // 
            this.comboBoxPackingMethod.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cachDongGoiBindingSource, "MaCachDongGoi", true));
            this.comboBoxPackingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPackingMethod.Enabled = false;
            this.comboBoxPackingMethod.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPackingMethod.FormattingEnabled = true;
            this.comboBoxPackingMethod.Location = new System.Drawing.Point(680, 210);
            this.comboBoxPackingMethod.Name = "comboBoxPackingMethod";
            this.comboBoxPackingMethod.Size = new System.Drawing.Size(240, 29);
            this.comboBoxPackingMethod.TabIndex = 17;
            // 
            // comboBoxProcessMethod
            // 
            this.comboBoxProcessMethod.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.phuongPhapCheBienBindingSource, "MaPPCheBien", true));
            this.comboBoxProcessMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcessMethod.Enabled = false;
            this.comboBoxProcessMethod.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProcessMethod.FormattingEnabled = true;
            this.comboBoxProcessMethod.Location = new System.Drawing.Point(360, 210);
            this.comboBoxProcessMethod.Name = "comboBoxProcessMethod";
            this.comboBoxProcessMethod.Size = new System.Drawing.Size(240, 29);
            this.comboBoxProcessMethod.TabIndex = 16;
            // 
            // numericProcessAmount
            // 
            this.numericProcessAmount.Enabled = false;
            this.numericProcessAmount.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericProcessAmount.Location = new System.Drawing.Point(1000, 75);
            this.numericProcessAmount.Name = "numericProcessAmount";
            this.numericProcessAmount.Size = new System.Drawing.Size(240, 28);
            this.numericProcessAmount.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAddPaper, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDeletePaper, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSavePaper, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonModifyPaper, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 337);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1309, 73);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // buttonAddPaper
            // 
            this.buttonAddPaper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddPaper.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPaper.Appearance.Options.UseFont = true;
            this.buttonAddPaper.Location = new System.Drawing.Point(53, 21);
            this.buttonAddPaper.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonAddPaper.Name = "buttonAddPaper";
            this.buttonAddPaper.Size = new System.Drawing.Size(155, 30);
            this.buttonAddPaper.TabIndex = 13;
            this.buttonAddPaper.Text = "Thêm phiếu chế biến";
            this.buttonAddPaper.Click += new System.EventHandler(this.ButtonAddPaper_Click);
            // 
            // buttonDeletePaper
            // 
            this.buttonDeletePaper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeletePaper.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePaper.Appearance.Options.UseFont = true;
            this.buttonDeletePaper.Enabled = false;
            this.buttonDeletePaper.Location = new System.Drawing.Point(575, 21);
            this.buttonDeletePaper.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonDeletePaper.Name = "buttonDeletePaper";
            this.buttonDeletePaper.Size = new System.Drawing.Size(155, 30);
            this.buttonDeletePaper.TabIndex = 7;
            this.buttonDeletePaper.Text = "Xóa phiếu chế biến";
            this.buttonDeletePaper.Click += new System.EventHandler(this.ButtonDeletePaper_Click);
            // 
            // buttonSavePaper
            // 
            this.buttonSavePaper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSavePaper.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePaper.Appearance.Options.UseFont = true;
            this.buttonSavePaper.Enabled = false;
            this.buttonSavePaper.Location = new System.Drawing.Point(856, 21);
            this.buttonSavePaper.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonSavePaper.Name = "buttonSavePaper";
            this.buttonSavePaper.Size = new System.Drawing.Size(115, 30);
            this.buttonSavePaper.TabIndex = 6;
            this.buttonSavePaper.Text = "Lưu ";
            this.buttonSavePaper.Click += new System.EventHandler(this.buttonSavePaper_Click);
            // 
            // buttonModifyPaper
            // 
            this.buttonModifyPaper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModifyPaper.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyPaper.Appearance.Options.UseFont = true;
            this.buttonModifyPaper.Location = new System.Drawing.Point(314, 21);
            this.buttonModifyPaper.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonModifyPaper.Name = "buttonModifyPaper";
            this.buttonModifyPaper.Size = new System.Drawing.Size(155, 30);
            this.buttonModifyPaper.TabIndex = 12;
            this.buttonModifyPaper.Text = "Sửa phiếu chế biến";
            this.buttonModifyPaper.Click += new System.EventHandler(this.ButtonModifyPaper_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Appearance.Options.UseFont = true;
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(1119, 21);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 30);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxProcessPaperID
            // 
            this.textBoxProcessPaperID.Enabled = false;
            this.textBoxProcessPaperID.Location = new System.Drawing.Point(40, 75);
            this.textBoxProcessPaperID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxProcessPaperID.Name = "textBoxProcessPaperID";
            this.textBoxProcessPaperID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProcessPaperID.Properties.Appearance.Options.UseFont = true;
            this.textBoxProcessPaperID.Size = new System.Drawing.Size(240, 28);
            this.textBoxProcessPaperID.TabIndex = 9;
            // 
            // dateEditBeanExpireDate
            // 
            this.dateEditBeanExpireDate.EditValue = null;
            this.dateEditBeanExpireDate.Enabled = false;
            this.dateEditBeanExpireDate.Location = new System.Drawing.Point(1000, 140);
            this.dateEditBeanExpireDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateEditBeanExpireDate.Name = "dateEditBeanExpireDate";
            this.dateEditBeanExpireDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditBeanExpireDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditBeanExpireDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBeanExpireDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBeanExpireDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditBeanExpireDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditBeanExpireDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditBeanExpireDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditBeanExpireDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dateEditBeanExpireDate.Size = new System.Drawing.Size(240, 28);
            this.dateEditBeanExpireDate.TabIndex = 2;
            // 
            // labelProcessMethod
            // 
            this.labelProcessMethod.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessMethod.Appearance.Options.UseFont = true;
            this.labelProcessMethod.Location = new System.Drawing.Point(360, 185);
            this.labelProcessMethod.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelProcessMethod.Name = "labelProcessMethod";
            this.labelProcessMethod.Size = new System.Drawing.Size(91, 18);
            this.labelProcessMethod.TabIndex = 8;
            this.labelProcessMethod.Text = "Cách chế biến";
            // 
            // dateEditProcessDate
            // 
            this.dateEditProcessDate.EditValue = null;
            this.dateEditProcessDate.Enabled = false;
            this.dateEditProcessDate.Location = new System.Drawing.Point(360, 75);
            this.dateEditProcessDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dateEditProcessDate.Name = "dateEditProcessDate";
            this.dateEditProcessDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditProcessDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditProcessDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditProcessDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditProcessDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditProcessDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditProcessDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditProcessDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditProcessDate.Properties.MaskSettings.Set("mask", "dd/MM/yyyy");
            this.dateEditProcessDate.Size = new System.Drawing.Size(240, 28);
            this.dateEditProcessDate.TabIndex = 2;
            // 
            // labelBeanName
            // 
            this.labelBeanName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeanName.Appearance.Options.UseFont = true;
            this.labelBeanName.Location = new System.Drawing.Point(360, 115);
            this.labelBeanName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelBeanName.Name = "labelBeanName";
            this.labelBeanName.Size = new System.Drawing.Size(100, 18);
            this.labelBeanName.TabIndex = 8;
            this.labelBeanName.Text = "Loại hạt cà phê";
            // 
            // labelPaperID
            // 
            this.labelPaperID.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaperID.Appearance.Options.UseFont = true;
            this.labelPaperID.Location = new System.Drawing.Point(40, 50);
            this.labelPaperID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelPaperID.Name = "labelPaperID";
            this.labelPaperID.Size = new System.Drawing.Size(59, 18);
            this.labelPaperID.TabIndex = 8;
            this.labelPaperID.Text = "Mã phiếu";
            // 
            // labelPackagingMethod
            // 
            this.labelPackagingMethod.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPackagingMethod.Appearance.Options.UseFont = true;
            this.labelPackagingMethod.Location = new System.Drawing.Point(680, 185);
            this.labelPackagingMethod.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelPackagingMethod.Name = "labelPackagingMethod";
            this.labelPackagingMethod.Size = new System.Drawing.Size(93, 18);
            this.labelPackagingMethod.TabIndex = 0;
            this.labelPackagingMethod.Text = "Cách đóng gói";
            // 
            // labelOrigin
            // 
            this.labelOrigin.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrigin.Appearance.Options.UseFont = true;
            this.labelOrigin.Location = new System.Drawing.Point(680, 115);
            this.labelOrigin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(52, 18);
            this.labelOrigin.TabIndex = 0;
            this.labelOrigin.Text = "Xuất xứ";
            // 
            // labelAmount
            // 
            this.labelAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Appearance.Options.UseFont = true;
            this.labelAmount.Location = new System.Drawing.Point(1000, 50);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(115, 18);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Số lượng chế biến";
            // 
            // labelBeanExpireDate
            // 
            this.labelBeanExpireDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeanExpireDate.Appearance.Options.UseFont = true;
            this.labelBeanExpireDate.Location = new System.Drawing.Point(1000, 115);
            this.labelBeanExpireDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelBeanExpireDate.Name = "labelBeanExpireDate";
            this.labelBeanExpireDate.Size = new System.Drawing.Size(164, 18);
            this.labelBeanExpireDate.TabIndex = 2;
            this.labelBeanExpireDate.Text = "Ngày hạt cà phê hết hạn";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.Appearance.Options.UseFont = true;
            this.labelEmployeeName.Location = new System.Drawing.Point(680, 50);
            this.labelEmployeeName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(124, 18);
            this.labelEmployeeName.TabIndex = 0;
            this.labelEmployeeName.Text = "Nhân viên chế biến";
            // 
            // labelProcessDate
            // 
            this.labelProcessDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessDate.Appearance.Options.UseFont = true;
            this.labelProcessDate.Location = new System.Drawing.Point(360, 50);
            this.labelProcessDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelProcessDate.Name = "labelProcessDate";
            this.labelProcessDate.Size = new System.Drawing.Size(93, 18);
            this.labelProcessDate.TabIndex = 2;
            this.labelProcessDate.Text = "Ngày chế biến";
            // 
            // panelFilterFunction
            // 
            this.panelFilterFunction.Controls.Add(this.groupBoxFilter);
            this.panelFilterFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterFunction.Location = new System.Drawing.Point(0, 412);
            this.panelFilterFunction.Name = "panelFilterFunction";
            this.panelFilterFunction.Size = new System.Drawing.Size(1313, 132);
            this.panelFilterFunction.TabIndex = 3;
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.panelBillDetailsFilter);
            this.groupBoxFilter.Controls.Add(this.panelBillFilter);
            this.groupBoxFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilter.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilter.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(1313, 132);
            this.groupBoxFilter.TabIndex = 1;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Bộ lọc";
            // 
            // panelBillDetailsFilter
            // 
            this.panelBillDetailsFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBillDetailsFilter.Controls.Add(this.textBoxBeanNameFilter);
            this.panelBillDetailsFilter.Controls.Add(this.labelBeanNameFilter);
            this.panelBillDetailsFilter.Controls.Add(this.textBoxProductNameFilter);
            this.panelBillDetailsFilter.Controls.Add(this.labelProductNameFilter);
            this.panelBillDetailsFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBillDetailsFilter.Location = new System.Drawing.Point(554, 24);
            this.panelBillDetailsFilter.Name = "panelBillDetailsFilter";
            this.panelBillDetailsFilter.Size = new System.Drawing.Size(756, 105);
            this.panelBillDetailsFilter.TabIndex = 7;
            // 
            // textBoxBeanNameFilter
            // 
            this.textBoxBeanNameFilter.Location = new System.Drawing.Point(548, 40);
            this.textBoxBeanNameFilter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxBeanNameFilter.Name = "textBoxBeanNameFilter";
            this.textBoxBeanNameFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBeanNameFilter.Properties.Appearance.Options.UseFont = true;
            this.textBoxBeanNameFilter.Size = new System.Drawing.Size(166, 28);
            this.textBoxBeanNameFilter.TabIndex = 10;
            this.textBoxBeanNameFilter.TextChanged += new System.EventHandler(this.FillEvent);
            // 
            // labelBeanNameFilter
            // 
            this.labelBeanNameFilter.AutoSize = true;
            this.labelBeanNameFilter.Location = new System.Drawing.Point(412, 43);
            this.labelBeanNameFilter.Name = "labelBeanNameFilter";
            this.labelBeanNameFilter.Size = new System.Drawing.Size(129, 21);
            this.labelBeanNameFilter.TabIndex = 4;
            this.labelBeanNameFilter.Text = "Loại hạt cà phê:";
            // 
            // textBoxProductNameFilter
            // 
            this.textBoxProductNameFilter.Location = new System.Drawing.Point(171, 40);
            this.textBoxProductNameFilter.Name = "textBoxProductNameFilter";
            this.textBoxProductNameFilter.Size = new System.Drawing.Size(166, 28);
            this.textBoxProductNameFilter.TabIndex = 3;
            this.textBoxProductNameFilter.TextChanged += new System.EventHandler(this.FillEvent);
            // 
            // labelProductNameFilter
            // 
            this.labelProductNameFilter.AutoSize = true;
            this.labelProductNameFilter.Location = new System.Drawing.Point(44, 43);
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
            this.panelBillFilter.Controls.Add(this.textBoxProductMakerNameFilter);
            this.panelBillFilter.Controls.Add(this.labelProductMaker);
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
            this.labelToDateFilter.Location = new System.Drawing.Point(257, 63);
            this.labelToDateFilter.Name = "labelToDateFilter";
            this.labelToDateFilter.Size = new System.Drawing.Size(79, 21);
            this.labelToDateFilter.TabIndex = 5;
            this.labelToDateFilter.Text = "Tới ngày:";
            // 
            // labelFromDateFilter
            // 
            this.labelFromDateFilter.AutoSize = true;
            this.labelFromDateFilter.Location = new System.Drawing.Point(33, 63);
            this.labelFromDateFilter.Name = "labelFromDateFilter";
            this.labelFromDateFilter.Size = new System.Drawing.Size(76, 21);
            this.labelFromDateFilter.TabIndex = 4;
            this.labelFromDateFilter.Text = "Từ ngày:";
            // 
            // textBoxProductMakerNameFilter
            // 
            this.textBoxProductMakerNameFilter.Location = new System.Drawing.Point(188, 12);
            this.textBoxProductMakerNameFilter.Name = "textBoxProductMakerNameFilter";
            this.textBoxProductMakerNameFilter.Size = new System.Drawing.Size(219, 28);
            this.textBoxProductMakerNameFilter.TabIndex = 1;
            this.textBoxProductMakerNameFilter.TextChanged += new System.EventHandler(this.FillEvent);
            // 
            // labelProductMaker
            // 
            this.labelProductMaker.AutoSize = true;
            this.labelProductMaker.Location = new System.Drawing.Point(33, 15);
            this.labelProductMaker.Name = "labelProductMaker";
            this.labelProductMaker.Size = new System.Drawing.Size(94, 21);
            this.labelProductMaker.TabIndex = 0;
            this.labelProductMaker.Text = "Nhân viên: ";
            // 
            // dateEditFromDateFilter
            // 
            this.dateEditFromDateFilter.EditValue = null;
            this.dateEditFromDateFilter.Location = new System.Drawing.Point(115, 60);
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
            this.dateEditFromDateFilter.TextChanged += new System.EventHandler(this.FillEvent);
            // 
            // dateEditToDateFilter
            // 
            this.dateEditToDateFilter.EditValue = null;
            this.dateEditToDateFilter.Location = new System.Drawing.Point(342, 60);
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
            this.dateEditToDateFilter.TextChanged += new System.EventHandler(this.FillEvent);
            // 
            // panelDataSection
            // 
            this.panelDataSection.Controls.Add(this.panelDataImportBill);
            this.panelDataSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataSection.Location = new System.Drawing.Point(0, 544);
            this.panelDataSection.Name = "panelDataSection";
            this.panelDataSection.Size = new System.Drawing.Size(1313, 241);
            this.panelDataSection.TabIndex = 4;
            // 
            // panelDataImportBill
            // 
            this.panelDataImportBill.AutoScroll = true;
            this.panelDataImportBill.Controls.Add(this.dataGridViewProcessPaper);
            this.panelDataImportBill.Controls.Add(this.labelExportBillTitle);
            this.panelDataImportBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataImportBill.Location = new System.Drawing.Point(0, 0);
            this.panelDataImportBill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelDataImportBill.Name = "panelDataImportBill";
            this.panelDataImportBill.Size = new System.Drawing.Size(1313, 241);
            this.panelDataImportBill.TabIndex = 1;
            // 
            // dataGridViewProcessPaper
            // 
            this.dataGridViewProcessPaper.AllowUserToAddRows = false;
            this.dataGridViewProcessPaper.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewProcessPaper.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProcessPaper.AutoGenerateColumns = false;
            this.dataGridViewProcessPaper.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProcessPaper.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProcessPaper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcessPaper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuCheBienDataGridViewTextBoxColumn,
            this.soLoHangDataGridViewTextBoxColumn,
            this.maLoaiHatDataGridViewTextBoxColumn,
            this.maSanPhamDataGridViewTextBoxColumn,
            this.maPPCheBienDataGridViewTextBoxColumn,
            this.maCachDongGoiDataGridViewTextBoxColumn,
            this.TenLoaiHat,
            this.XuatXu,
            this.TenSanPham,
            this.CachCheBien,
            this.SoLuongMoiGoi,
            this.CachDongGoi,
            this.MaNhanVien,
            this.xayDataGridViewCheckBoxColumn,
            this.ngayCheBienDataGridViewTextBoxColumn,
            this.soLuongCheBienDataGridViewTextBoxColumn});
            this.dataGridViewProcessPaper.DataSource = this.phieuCheBienADVBindingSource;
            this.dataGridViewProcessPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProcessPaper.Location = new System.Drawing.Point(0, 31);
            this.dataGridViewProcessPaper.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridViewProcessPaper.Name = "dataGridViewProcessPaper";
            this.dataGridViewProcessPaper.ReadOnly = true;
            this.dataGridViewProcessPaper.RowHeadersWidth = 51;
            this.dataGridViewProcessPaper.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewProcessPaper.RowTemplate.Height = 24;
            this.dataGridViewProcessPaper.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcessPaper.Size = new System.Drawing.Size(1313, 210);
            this.dataGridViewProcessPaper.TabIndex = 0;
            this.dataGridViewProcessPaper.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcessPaper_CellContentClick);
            this.dataGridViewProcessPaper.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcessPaper_CellContentClick);
            // 
            // labelExportBillTitle
            // 
            this.labelExportBillTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelExportBillTitle.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExportBillTitle.Location = new System.Drawing.Point(0, 0);
            this.labelExportBillTitle.Name = "labelExportBillTitle";
            this.labelExportBillTitle.Size = new System.Drawing.Size(1313, 31);
            this.labelExportBillTitle.TabIndex = 1;
            this.labelExportBillTitle.Text = "DANH SÁCH PHIẾU CHẾ BIẾN";
            this.labelExportBillTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phieuCheBienADVBindingSource
            // 
            this.phieuCheBienADVBindingSource.DataMember = "PhieuCheBienADV";
            this.phieuCheBienADVBindingSource.DataSource = this.daiLyCaPheDataSet;
            // 
            // daiLyCaPheDataSet
            // 
            this.daiLyCaPheDataSet.DataSetName = "DaiLyCaPheDataSet";
            this.daiLyCaPheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loHangBindingSource
            // 
            this.loHangBindingSource.DataMember = "LoHang";
            this.loHangBindingSource.DataSource = this.daiLyCaPheDataSet;
            // 
            // cachDongGoiBindingSource
            // 
            this.cachDongGoiBindingSource.DataMember = "CachDongGoi";
            this.cachDongGoiBindingSource.DataSource = this.daiLyCaPheDataSet;
            // 
            // phuongPhapCheBienBindingSource
            // 
            this.phuongPhapCheBienBindingSource.DataMember = "PhuongPhapCheBien";
            this.phuongPhapCheBienBindingSource.DataSource = this.daiLyCaPheDataSet;
            // 
            // phieuCheBienBindingSource
            // 
            this.phieuCheBienBindingSource.DataMember = "PhieuCheBien";
            this.phieuCheBienBindingSource.DataSource = this.daiLyCaPheDataSet;
            // 
            // phieuCheBienTableAdapter
            // 
            this.phieuCheBienTableAdapter.ClearBeforeFill = true;
            // 
            // phieuCheBienADVTableAdapter
            // 
            this.phieuCheBienADVTableAdapter.ClearBeforeFill = true;
            // 
            // loHangTableAdapter
            // 
            this.loHangTableAdapter.ClearBeforeFill = true;
            // 
            // phuongPhapCheBienTableAdapter
            // 
            this.phuongPhapCheBienTableAdapter.ClearBeforeFill = true;
            // 
            // cachDongGoiTableAdapter
            // 
            this.cachDongGoiTableAdapter.ClearBeforeFill = true;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.daiLyCaPheDataSet;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // maPhieuCheBienDataGridViewTextBoxColumn
            // 
            this.maPhieuCheBienDataGridViewTextBoxColumn.DataPropertyName = "MaPhieuCheBien";
            this.maPhieuCheBienDataGridViewTextBoxColumn.HeaderText = "Mã phiếu chế biến";
            this.maPhieuCheBienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhieuCheBienDataGridViewTextBoxColumn.Name = "maPhieuCheBienDataGridViewTextBoxColumn";
            this.maPhieuCheBienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLoHangDataGridViewTextBoxColumn
            // 
            this.soLoHangDataGridViewTextBoxColumn.DataPropertyName = "SoLoHang";
            this.soLoHangDataGridViewTextBoxColumn.HeaderText = "Số lô hàng";
            this.soLoHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLoHangDataGridViewTextBoxColumn.Name = "soLoHangDataGridViewTextBoxColumn";
            this.soLoHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLoaiHatDataGridViewTextBoxColumn
            // 
            this.maLoaiHatDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiHat";
            this.maLoaiHatDataGridViewTextBoxColumn.HeaderText = "Mã loại hạt";
            this.maLoaiHatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLoaiHatDataGridViewTextBoxColumn.Name = "maLoaiHatDataGridViewTextBoxColumn";
            this.maLoaiHatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            this.maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham";
            this.maSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.maSanPhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
            this.maSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maPPCheBienDataGridViewTextBoxColumn
            // 
            this.maPPCheBienDataGridViewTextBoxColumn.DataPropertyName = "MaPPCheBien";
            this.maPPCheBienDataGridViewTextBoxColumn.HeaderText = "Mã P.P chế biến";
            this.maPPCheBienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPPCheBienDataGridViewTextBoxColumn.Name = "maPPCheBienDataGridViewTextBoxColumn";
            this.maPPCheBienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maCachDongGoiDataGridViewTextBoxColumn
            // 
            this.maCachDongGoiDataGridViewTextBoxColumn.DataPropertyName = "MaCachDongGoi";
            this.maCachDongGoiDataGridViewTextBoxColumn.HeaderText = "Mã cách đóng  gói";
            this.maCachDongGoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCachDongGoiDataGridViewTextBoxColumn.Name = "maCachDongGoiDataGridViewTextBoxColumn";
            this.maCachDongGoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TenLoaiHat
            // 
            this.TenLoaiHat.DataPropertyName = "TenLoaiHat";
            this.TenLoaiHat.HeaderText = "Loại hạt cà phê";
            this.TenLoaiHat.MinimumWidth = 6;
            this.TenLoaiHat.Name = "TenLoaiHat";
            this.TenLoaiHat.ReadOnly = true;
            // 
            // XuatXu
            // 
            this.XuatXu.DataPropertyName = "XuatXu";
            this.XuatXu.HeaderText = "Xuất xứ";
            this.XuatXu.MinimumWidth = 6;
            this.XuatXu.Name = "XuatXu";
            this.XuatXu.ReadOnly = true;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // CachCheBien
            // 
            this.CachCheBien.DataPropertyName = "CachCheBien";
            this.CachCheBien.HeaderText = "Cách chế biến";
            this.CachCheBien.MinimumWidth = 6;
            this.CachCheBien.Name = "CachCheBien";
            this.CachCheBien.ReadOnly = true;
            this.CachCheBien.Visible = false;
            // 
            // SoLuongMoiGoi
            // 
            this.SoLuongMoiGoi.DataPropertyName = "SoLuongMoiGoi";
            this.SoLuongMoiGoi.HeaderText = "Số lượng mỗi gói";
            this.SoLuongMoiGoi.MinimumWidth = 6;
            this.SoLuongMoiGoi.Name = "SoLuongMoiGoi";
            this.SoLuongMoiGoi.ReadOnly = true;
            // 
            // CachDongGoi
            // 
            this.CachDongGoi.DataPropertyName = "CachDongGoi";
            this.CachDongGoi.HeaderText = "Cách đóng gói";
            this.CachDongGoi.MinimumWidth = 6;
            this.CachDongGoi.Name = "CachDongGoi";
            this.CachDongGoi.ReadOnly = true;
            this.CachDongGoi.Visible = false;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Nhân viên thực hiện";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // xayDataGridViewCheckBoxColumn
            // 
            this.xayDataGridViewCheckBoxColumn.DataPropertyName = "Xay";
            this.xayDataGridViewCheckBoxColumn.HeaderText = "Xay";
            this.xayDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.xayDataGridViewCheckBoxColumn.Name = "xayDataGridViewCheckBoxColumn";
            this.xayDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ngayCheBienDataGridViewTextBoxColumn
            // 
            this.ngayCheBienDataGridViewTextBoxColumn.DataPropertyName = "NgayCheBien";
            this.ngayCheBienDataGridViewTextBoxColumn.HeaderText = "Ngày chế biến";
            this.ngayCheBienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayCheBienDataGridViewTextBoxColumn.Name = "ngayCheBienDataGridViewTextBoxColumn";
            this.ngayCheBienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongCheBienDataGridViewTextBoxColumn
            // 
            this.soLuongCheBienDataGridViewTextBoxColumn.DataPropertyName = "SoLuongCheBien";
            this.soLuongCheBienDataGridViewTextBoxColumn.HeaderText = "Số lượng chế biến";
            this.soLuongCheBienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongCheBienDataGridViewTextBoxColumn.Name = "soLuongCheBienDataGridViewTextBoxColumn";
            this.soLuongCheBienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProcessPaperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 785);
            this.Controls.Add(this.panelDataSection);
            this.Controls.Add(this.panelFilterFunction);
            this.Controls.Add(this.groupAddProcessPaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessPaperForm";
            this.Text = "ProcessPaperForm";
            this.Load += new System.EventHandler(this.ProcessBillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupAddProcessPaper)).EndInit();
            this.groupAddProcessPaper.ResumeLayout(false);
            this.groupAddProcessPaper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxIsGrind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProcessAmount)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProcessPaperID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBeanExpireDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBeanExpireDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditProcessDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditProcessDate.Properties)).EndInit();
            this.panelFilterFunction.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
            this.panelBillDetailsFilter.ResumeLayout(false);
            this.panelBillDetailsFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBeanNameFilter.Properties)).EndInit();
            this.panelBillFilter.ResumeLayout(false);
            this.panelBillFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFromDateFilter.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFromDateFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditToDateFilter.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditToDateFilter.Properties)).EndInit();
            this.panelDataSection.ResumeLayout(false);
            this.panelDataImportBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuCheBienADVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLyCaPheDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cachDongGoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phuongPhapCheBienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuCheBienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupAddProcessPaper;
        private DevExpress.XtraEditors.SimpleButton buttonAddPaper;
        private DevExpress.XtraEditors.SimpleButton buttonModifyPaper;
        private DevExpress.XtraEditors.TextEdit textBoxProcessPaperID;
        private DevExpress.XtraEditors.LabelControl labelPaperID;
        private DevExpress.XtraEditors.DateEdit dateEditProcessDate;
        private DevExpress.XtraEditors.SimpleButton buttonDeletePaper;
        private DevExpress.XtraEditors.SimpleButton buttonSavePaper;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.LabelControl labelProcessDate;
        private DevExpress.XtraEditors.LabelControl labelEmployeeName;
        private System.Windows.Forms.Panel panelFilterFunction;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.Panel panelBillDetailsFilter;
        private System.Windows.Forms.Label labelBeanNameFilter;
        private System.Windows.Forms.TextBox textBoxProductNameFilter;
        private System.Windows.Forms.Label labelProductNameFilter;
        private System.Windows.Forms.Panel panelBillFilter;
        private System.Windows.Forms.Label labelToDateFilter;
        private System.Windows.Forms.Label labelFromDateFilter;
        private System.Windows.Forms.TextBox textBoxProductMakerNameFilter;
        private System.Windows.Forms.Label labelProductMaker;
        private DevExpress.XtraEditors.DateEdit dateEditFromDateFilter;
        private DevExpress.XtraEditors.DateEdit dateEditToDateFilter;
        private System.Windows.Forms.Panel panelDataSection;
        private System.Windows.Forms.Panel panelDataImportBill;
        private System.Windows.Forms.DataGridView dataGridViewProcessPaper;
        private System.Windows.Forms.Label labelExportBillTitle;
        private DaiLyCaPheDataSet daiLyCaPheDataSet;
        private System.Windows.Forms.BindingSource phieuCheBienBindingSource;
        private DaiLyCaPheDataSetTableAdapters.PhieuCheBienTableAdapter phieuCheBienTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource phieuCheBienADVBindingSource;
        private DaiLyCaPheDataSetTableAdapters.PhieuCheBienADVTableAdapter phieuCheBienADVTableAdapter;
        private System.Windows.Forms.NumericUpDown numericProcessAmount;
        private DevExpress.XtraEditors.DateEdit dateEditBeanExpireDate;
        private DevExpress.XtraEditors.LabelControl labelProcessMethod;
        private DevExpress.XtraEditors.LabelControl labelBeanName;
        private DevExpress.XtraEditors.LabelControl labelPackagingMethod;
        private DevExpress.XtraEditors.LabelControl labelOrigin;
        private DevExpress.XtraEditors.LabelControl labelAmount;
        private DevExpress.XtraEditors.LabelControl labelBeanExpireDate;
        private DevExpress.XtraEditors.CheckEdit checkBoxIsGrind;
        private DevExpress.XtraEditors.LabelControl labelBeanID;
        private System.Windows.Forms.ComboBox comboBoxPackingMethod;
        private System.Windows.Forms.ComboBox comboBoxProcessMethod;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox comboBoxCategoryID;
        private DevExpress.XtraEditors.TextEdit textBoxProductName;
        private DevExpress.XtraEditors.TextEdit textBoxBeanNameFilter;
        private System.Windows.Forms.BindingSource loHangBindingSource;
        private DaiLyCaPheDataSetTableAdapters.LoHangTableAdapter loHangTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxBeanName;
        private System.Windows.Forms.ComboBox comboBoxBeanOrigin;
        private System.Windows.Forms.BindingSource phuongPhapCheBienBindingSource;
        private DaiLyCaPheDataSetTableAdapters.PhuongPhapCheBienTableAdapter phuongPhapCheBienTableAdapter;
        private System.Windows.Forms.BindingSource cachDongGoiBindingSource;
        private DaiLyCaPheDataSetTableAdapters.CachDongGoiTableAdapter cachDongGoiTableAdapter;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private DaiLyCaPheDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxProcessMakerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuCheBienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLoHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiHatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPPCheBienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCachDongGoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiHat;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachCheBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMoiGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CachDongGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn xayDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCheBienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongCheBienDataGridViewTextBoxColumn;
    }
}