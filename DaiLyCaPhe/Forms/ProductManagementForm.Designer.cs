namespace DaiLyCaPhe.Forms
{
    partial class ProductManagementForm
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
            this.panelFilter = new System.Windows.Forms.Panel();
            this.panelCategoryFilter = new System.Windows.Forms.Panel();
            this.groupBoxCategoryFilter = new System.Windows.Forms.GroupBox();
            this.textBoxOriginFilter = new DevExpress.XtraEditors.TextEdit();
            this.labelBeanOrigin = new DevExpress.XtraEditors.LabelControl();
            this.textBoxBeanNameFilter = new DevExpress.XtraEditors.TextEdit();
            this.labelBeanName = new DevExpress.XtraEditors.LabelControl();
            this.textBoxCategoryIDFilter = new DevExpress.XtraEditors.TextEdit();
            this.labelCategoryID = new DevExpress.XtraEditors.LabelControl();
            this.panelProductFilter = new System.Windows.Forms.Panel();
            this.groupBoxProductFilter = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxToWeightFilter = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxProductTypeFilter = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxFromWeightFilter = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxProductNameFilter = new DevExpress.XtraEditors.TextEdit();
            this.labelProductNameFilter = new DevExpress.XtraEditors.LabelControl();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelDataLoHang = new System.Windows.Forms.Panel();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.soLoHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiHatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xuatXuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanSuDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loHangSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daiLyCaPheDataSet = new DaiLyCaPhe.DBConnection.DaiLyCaPheDataSet();
            this.labelCategory = new DevExpress.XtraEditors.LabelControl();
            this.panelDataSanPham = new System.Windows.Forms.Panel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.maSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trongLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanSuDungDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongTonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelProduct = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.loHang_SanPhamTableAdapter = new DaiLyCaPhe.DBConnection.DaiLyCaPheDataSetTableAdapters.LoHang_SanPhamTableAdapter();
            this.sanPhamTableAdapter = new DaiLyCaPhe.DBConnection.DaiLyCaPheDataSetTableAdapters.SanPhamTableAdapter();
            this.buttonClearProductFilter = new DevExpress.XtraEditors.SimpleButton();
            this.buttonClearCategoryFilter = new DevExpress.XtraEditors.SimpleButton();
            this.panelFilter.SuspendLayout();
            this.panelCategoryFilter.SuspendLayout();
            this.groupBoxCategoryFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxOriginFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBeanNameFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCategoryIDFilter.Properties)).BeginInit();
            this.panelProductFilter.SuspendLayout();
            this.groupBoxProductFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxToWeightFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductTypeFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFromWeightFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductNameFilter.Properties)).BeginInit();
            this.panelProducts.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelDataLoHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loHangSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLyCaPheDataSet)).BeginInit();
            this.panelDataSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.panelCategoryFilter);
            this.panelFilter.Controls.Add(this.panelProductFilter);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1313, 240);
            this.panelFilter.TabIndex = 0;
            // 
            // panelCategoryFilter
            // 
            this.panelCategoryFilter.Controls.Add(this.groupBoxCategoryFilter);
            this.panelCategoryFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategoryFilter.Location = new System.Drawing.Point(650, 0);
            this.panelCategoryFilter.Name = "panelCategoryFilter";
            this.panelCategoryFilter.Size = new System.Drawing.Size(663, 240);
            this.panelCategoryFilter.TabIndex = 1;
            // 
            // groupBoxCategoryFilter
            // 
            this.groupBoxCategoryFilter.Controls.Add(this.buttonClearCategoryFilter);
            this.groupBoxCategoryFilter.Controls.Add(this.textBoxOriginFilter);
            this.groupBoxCategoryFilter.Controls.Add(this.labelBeanOrigin);
            this.groupBoxCategoryFilter.Controls.Add(this.textBoxBeanNameFilter);
            this.groupBoxCategoryFilter.Controls.Add(this.labelBeanName);
            this.groupBoxCategoryFilter.Controls.Add(this.textBoxCategoryIDFilter);
            this.groupBoxCategoryFilter.Controls.Add(this.labelCategoryID);
            this.groupBoxCategoryFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCategoryFilter.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCategoryFilter.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCategoryFilter.Name = "groupBoxCategoryFilter";
            this.groupBoxCategoryFilter.Size = new System.Drawing.Size(663, 240);
            this.groupBoxCategoryFilter.TabIndex = 3;
            this.groupBoxCategoryFilter.TabStop = false;
            this.groupBoxCategoryFilter.Text = "Bộ lọc lô hàng";
            // 
            // textBoxOriginFilter
            // 
            this.textBoxOriginFilter.Location = new System.Drawing.Point(193, 173);
            this.textBoxOriginFilter.Name = "textBoxOriginFilter";
            this.textBoxOriginFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOriginFilter.Properties.Appearance.Options.UseFont = true;
            this.textBoxOriginFilter.Size = new System.Drawing.Size(310, 28);
            this.textBoxOriginFilter.TabIndex = 5;
            this.textBoxOriginFilter.TextChanged += new System.EventHandler(this.CategoryFillEvent);
            // 
            // labelBeanOrigin
            // 
            this.labelBeanOrigin.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeanOrigin.Appearance.Options.UseFont = true;
            this.labelBeanOrigin.Location = new System.Drawing.Point(49, 176);
            this.labelBeanOrigin.Name = "labelBeanOrigin";
            this.labelBeanOrigin.Size = new System.Drawing.Size(57, 21);
            this.labelBeanOrigin.TabIndex = 4;
            this.labelBeanOrigin.Text = "Xuất xứ";
            // 
            // textBoxBeanNameFilter
            // 
            this.textBoxBeanNameFilter.Location = new System.Drawing.Point(193, 113);
            this.textBoxBeanNameFilter.Name = "textBoxBeanNameFilter";
            this.textBoxBeanNameFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBeanNameFilter.Properties.Appearance.Options.UseFont = true;
            this.textBoxBeanNameFilter.Size = new System.Drawing.Size(310, 28);
            this.textBoxBeanNameFilter.TabIndex = 3;
            this.textBoxBeanNameFilter.TextChanged += new System.EventHandler(this.CategoryFillEvent);
            // 
            // labelBeanName
            // 
            this.labelBeanName.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeanName.Appearance.Options.UseFont = true;
            this.labelBeanName.Location = new System.Drawing.Point(49, 116);
            this.labelBeanName.Name = "labelBeanName";
            this.labelBeanName.Size = new System.Drawing.Size(88, 21);
            this.labelBeanName.TabIndex = 2;
            this.labelBeanName.Text = "Tên loại hạt";
            // 
            // textBoxCategoryIDFilter
            // 
            this.textBoxCategoryIDFilter.Location = new System.Drawing.Point(193, 53);
            this.textBoxCategoryIDFilter.Name = "textBoxCategoryIDFilter";
            this.textBoxCategoryIDFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategoryIDFilter.Properties.Appearance.Options.UseFont = true;
            this.textBoxCategoryIDFilter.Size = new System.Drawing.Size(310, 28);
            this.textBoxCategoryIDFilter.TabIndex = 1;
            this.textBoxCategoryIDFilter.TextChanged += new System.EventHandler(this.CategoryFillEvent);
            // 
            // labelCategoryID
            // 
            this.labelCategoryID.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryID.Appearance.Options.UseFont = true;
            this.labelCategoryID.Location = new System.Drawing.Point(49, 56);
            this.labelCategoryID.Name = "labelCategoryID";
            this.labelCategoryID.Size = new System.Drawing.Size(77, 21);
            this.labelCategoryID.TabIndex = 0;
            this.labelCategoryID.Text = "Số lô hàng";
            // 
            // panelProductFilter
            // 
            this.panelProductFilter.Controls.Add(this.groupBoxProductFilter);
            this.panelProductFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProductFilter.Location = new System.Drawing.Point(0, 0);
            this.panelProductFilter.Name = "panelProductFilter";
            this.panelProductFilter.Size = new System.Drawing.Size(650, 240);
            this.panelProductFilter.TabIndex = 0;
            // 
            // groupBoxProductFilter
            // 
            this.groupBoxProductFilter.Controls.Add(this.buttonClearProductFilter);
            this.groupBoxProductFilter.Controls.Add(this.labelControl5);
            this.groupBoxProductFilter.Controls.Add(this.labelControl4);
            this.groupBoxProductFilter.Controls.Add(this.textBoxToWeightFilter);
            this.groupBoxProductFilter.Controls.Add(this.labelControl3);
            this.groupBoxProductFilter.Controls.Add(this.textBoxProductTypeFilter);
            this.groupBoxProductFilter.Controls.Add(this.labelControl2);
            this.groupBoxProductFilter.Controls.Add(this.textBoxFromWeightFilter);
            this.groupBoxProductFilter.Controls.Add(this.labelControl1);
            this.groupBoxProductFilter.Controls.Add(this.textBoxProductNameFilter);
            this.groupBoxProductFilter.Controls.Add(this.labelProductNameFilter);
            this.groupBoxProductFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxProductFilter.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProductFilter.Location = new System.Drawing.Point(0, 0);
            this.groupBoxProductFilter.Name = "groupBoxProductFilter";
            this.groupBoxProductFilter.Size = new System.Drawing.Size(650, 240);
            this.groupBoxProductFilter.TabIndex = 2;
            this.groupBoxProductFilter.TabStop = false;
            this.groupBoxProductFilter.Text = "Bộ lọc sản phẩm";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(472, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 21);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "(kg)";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(335, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 21);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "đến:";
            // 
            // textBoxToWeightFilter
            // 
            this.textBoxToWeightFilter.Location = new System.Drawing.Point(375, 113);
            this.textBoxToWeightFilter.Name = "textBoxToWeightFilter";
            this.textBoxToWeightFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxToWeightFilter.Properties.Appearance.Options.UseFont = true;
            this.textBoxToWeightFilter.Size = new System.Drawing.Size(91, 28);
            this.textBoxToWeightFilter.TabIndex = 7;
            this.textBoxToWeightFilter.TextChanged += new System.EventHandler(this.ProductFillEvent);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(193, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 21);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "từ:";
            // 
            // textBoxProductTypeFilter
            // 
            this.textBoxProductTypeFilter.Location = new System.Drawing.Point(193, 173);
            this.textBoxProductTypeFilter.Name = "textBoxProductTypeFilter";
            this.textBoxProductTypeFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductTypeFilter.Properties.Appearance.Options.UseFont = true;
            this.textBoxProductTypeFilter.Size = new System.Drawing.Size(310, 28);
            this.textBoxProductTypeFilter.TabIndex = 5;
            this.textBoxProductTypeFilter.TextChanged += new System.EventHandler(this.ProductFillEvent);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(49, 176);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 21);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Loại sản phẩm:";
            // 
            // textBoxFromWeightFilter
            // 
            this.textBoxFromWeightFilter.Location = new System.Drawing.Point(221, 113);
            this.textBoxFromWeightFilter.Name = "textBoxFromWeightFilter";
            this.textBoxFromWeightFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFromWeightFilter.Properties.Appearance.Options.UseFont = true;
            this.textBoxFromWeightFilter.Size = new System.Drawing.Size(91, 28);
            this.textBoxFromWeightFilter.TabIndex = 3;
            this.textBoxFromWeightFilter.TextChanged += new System.EventHandler(this.ProductFillEvent);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(49, 116);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 21);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Trọng lượng:";
            // 
            // textBoxProductNameFilter
            // 
            this.textBoxProductNameFilter.Location = new System.Drawing.Point(193, 53);
            this.textBoxProductNameFilter.Name = "textBoxProductNameFilter";
            this.textBoxProductNameFilter.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductNameFilter.Properties.Appearance.Options.UseFont = true;
            this.textBoxProductNameFilter.Size = new System.Drawing.Size(310, 28);
            this.textBoxProductNameFilter.TabIndex = 1;
            this.textBoxProductNameFilter.TextChanged += new System.EventHandler(this.ProductFillEvent);
            // 
            // labelProductNameFilter
            // 
            this.labelProductNameFilter.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductNameFilter.Appearance.Options.UseFont = true;
            this.labelProductNameFilter.Location = new System.Drawing.Point(49, 56);
            this.labelProductNameFilter.Name = "labelProductNameFilter";
            this.labelProductNameFilter.Size = new System.Drawing.Size(111, 21);
            this.labelProductNameFilter.TabIndex = 0;
            this.labelProductNameFilter.Text = "Tên sản phẩm:";
            this.labelProductNameFilter.Click += new System.EventHandler(this.labelProductNameFilter_Click);
            // 
            // panelProducts
            // 
            this.panelProducts.Controls.Add(this.panelData);
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Location = new System.Drawing.Point(0, 240);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(1313, 545);
            this.panelProducts.TabIndex = 1;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.panelDataLoHang);
            this.panelData.Controls.Add(this.panelDataSanPham);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1313, 545);
            this.panelData.TabIndex = 6;
            // 
            // panelDataLoHang
            // 
            this.panelDataLoHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDataLoHang.Controls.Add(this.dataGridViewCategories);
            this.panelDataLoHang.Controls.Add(this.labelCategory);
            this.panelDataLoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataLoHang.Location = new System.Drawing.Point(650, 0);
            this.panelDataLoHang.Name = "panelDataLoHang";
            this.panelDataLoHang.Size = new System.Drawing.Size(663, 545);
            this.panelDataLoHang.TabIndex = 1;
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AllowUserToDeleteRows = false;
            this.dataGridViewCategories.AutoGenerateColumns = false;
            this.dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategories.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soLoHangDataGridViewTextBoxColumn,
            this.tenLoaiHatDataGridViewTextBoxColumn,
            this.xuatXuDataGridViewTextBoxColumn,
            this.soLuongTonDataGridViewTextBoxColumn,
            this.ngaySanXuatDataGridViewTextBoxColumn,
            this.hanSuDungDataGridViewTextBoxColumn});
            this.dataGridViewCategories.DataSource = this.loHangSanPhamBindingSource;
            this.dataGridViewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCategories.Location = new System.Drawing.Point(0, 38);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.RowHeadersWidth = 51;
            this.dataGridViewCategories.RowTemplate.Height = 24;
            this.dataGridViewCategories.Size = new System.Drawing.Size(661, 505);
            this.dataGridViewCategories.TabIndex = 2;
            this.dataGridViewCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategories_CellContentClick);
            // 
            // soLoHangDataGridViewTextBoxColumn
            // 
            this.soLoHangDataGridViewTextBoxColumn.DataPropertyName = "SoLoHang";
            this.soLoHangDataGridViewTextBoxColumn.HeaderText = "Số lô hàng";
            this.soLoHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLoHangDataGridViewTextBoxColumn.Name = "soLoHangDataGridViewTextBoxColumn";
            this.soLoHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiHatDataGridViewTextBoxColumn
            // 
            this.tenLoaiHatDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiHat";
            this.tenLoaiHatDataGridViewTextBoxColumn.HeaderText = "Tên loại hạt";
            this.tenLoaiHatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLoaiHatDataGridViewTextBoxColumn.Name = "tenLoaiHatDataGridViewTextBoxColumn";
            this.tenLoaiHatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xuatXuDataGridViewTextBoxColumn
            // 
            this.xuatXuDataGridViewTextBoxColumn.DataPropertyName = "XuatXu";
            this.xuatXuDataGridViewTextBoxColumn.HeaderText = "Xuất xứ";
            this.xuatXuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xuatXuDataGridViewTextBoxColumn.Name = "xuatXuDataGridViewTextBoxColumn";
            this.xuatXuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongTonDataGridViewTextBoxColumn
            // 
            this.soLuongTonDataGridViewTextBoxColumn.DataPropertyName = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn.HeaderText = "Số lượng tồn";
            this.soLuongTonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongTonDataGridViewTextBoxColumn.Name = "soLuongTonDataGridViewTextBoxColumn";
            this.soLuongTonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySanXuatDataGridViewTextBoxColumn
            // 
            this.ngaySanXuatDataGridViewTextBoxColumn.DataPropertyName = "NgaySanXuat";
            this.ngaySanXuatDataGridViewTextBoxColumn.HeaderText = "Ngày sản xuất";
            this.ngaySanXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySanXuatDataGridViewTextBoxColumn.Name = "ngaySanXuatDataGridViewTextBoxColumn";
            this.ngaySanXuatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hanSuDungDataGridViewTextBoxColumn
            // 
            this.hanSuDungDataGridViewTextBoxColumn.DataPropertyName = "HanSuDung";
            this.hanSuDungDataGridViewTextBoxColumn.HeaderText = "Hạn sử dụng";
            this.hanSuDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hanSuDungDataGridViewTextBoxColumn.Name = "hanSuDungDataGridViewTextBoxColumn";
            this.hanSuDungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loHangSanPhamBindingSource
            // 
            this.loHangSanPhamBindingSource.DataMember = "LoHang_SanPham";
            this.loHangSanPhamBindingSource.DataSource = this.daiLyCaPheDataSet;
            // 
            // daiLyCaPheDataSet
            // 
            this.daiLyCaPheDataSet.DataSetName = "DaiLyCaPheDataSet";
            this.daiLyCaPheDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelCategory
            // 
            this.labelCategory.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Appearance.Options.UseFont = true;
            this.labelCategory.Appearance.Options.UseTextOptions = true;
            this.labelCategory.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelCategory.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCategory.Location = new System.Drawing.Point(0, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(661, 38);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "DANH SÁCH LÔ HÀNG";
            // 
            // panelDataSanPham
            // 
            this.panelDataSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDataSanPham.Controls.Add(this.dataGridViewProducts);
            this.panelDataSanPham.Controls.Add(this.labelProduct);
            this.panelDataSanPham.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDataSanPham.Location = new System.Drawing.Point(0, 0);
            this.panelDataSanPham.Name = "panelDataSanPham";
            this.panelDataSanPham.Size = new System.Drawing.Size(650, 545);
            this.panelDataSanPham.TabIndex = 0;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AutoGenerateColumns = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSanPhamDataGridViewTextBoxColumn,
            this.tenSanPhamDataGridViewTextBoxColumn,
            this.loaiSanPhamDataGridViewTextBoxColumn,
            this.trongLuongDataGridViewTextBoxColumn,
            this.hanSuDungDataGridViewTextBoxColumn1,
            this.soLuongTonDataGridViewTextBoxColumn1});
            this.dataGridViewProducts.DataSource = this.sanPhamBindingSource;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 38);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(648, 505);
            this.dataGridViewProducts.TabIndex = 1;
            // 
            // maSanPhamDataGridViewTextBoxColumn
            // 
            this.maSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham";
            this.maSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.maSanPhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSanPhamDataGridViewTextBoxColumn.Name = "maSanPhamDataGridViewTextBoxColumn";
            this.maSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSanPhamDataGridViewTextBoxColumn
            // 
            this.tenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenSanPham";
            this.tenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tenSanPhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSanPhamDataGridViewTextBoxColumn.Name = "tenSanPhamDataGridViewTextBoxColumn";
            this.tenSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loaiSanPhamDataGridViewTextBoxColumn
            // 
            this.loaiSanPhamDataGridViewTextBoxColumn.DataPropertyName = "LoaiSanPham";
            this.loaiSanPhamDataGridViewTextBoxColumn.HeaderText = "Loại sản phẩm";
            this.loaiSanPhamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiSanPhamDataGridViewTextBoxColumn.Name = "loaiSanPhamDataGridViewTextBoxColumn";
            this.loaiSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trongLuongDataGridViewTextBoxColumn
            // 
            this.trongLuongDataGridViewTextBoxColumn.DataPropertyName = "TrongLuong";
            this.trongLuongDataGridViewTextBoxColumn.HeaderText = "Trọng lượng";
            this.trongLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trongLuongDataGridViewTextBoxColumn.Name = "trongLuongDataGridViewTextBoxColumn";
            this.trongLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hanSuDungDataGridViewTextBoxColumn1
            // 
            this.hanSuDungDataGridViewTextBoxColumn1.DataPropertyName = "HanSuDung";
            this.hanSuDungDataGridViewTextBoxColumn1.HeaderText = "Hạn sử dụng";
            this.hanSuDungDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.hanSuDungDataGridViewTextBoxColumn1.Name = "hanSuDungDataGridViewTextBoxColumn1";
            this.hanSuDungDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // soLuongTonDataGridViewTextBoxColumn1
            // 
            this.soLuongTonDataGridViewTextBoxColumn1.DataPropertyName = "SoLuongTon";
            this.soLuongTonDataGridViewTextBoxColumn1.HeaderText = "Số lượng tồn";
            this.soLuongTonDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.soLuongTonDataGridViewTextBoxColumn1.Name = "soLuongTonDataGridViewTextBoxColumn1";
            this.soLuongTonDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.daiLyCaPheDataSet;
            // 
            // labelProduct
            // 
            this.labelProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Appearance.Options.UseFont = true;
            this.labelProduct.Appearance.Options.UseTextOptions = true;
            this.labelProduct.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelProduct.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelProduct.Location = new System.Drawing.Point(0, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(648, 38);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // loHang_SanPhamTableAdapter
            // 
            this.loHang_SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // buttonClearProductFilter
            // 
            this.buttonClearProductFilter.Location = new System.Drawing.Point(540, 194);
            this.buttonClearProductFilter.Name = "buttonClearProductFilter";
            this.buttonClearProductFilter.Size = new System.Drawing.Size(94, 29);
            this.buttonClearProductFilter.TabIndex = 10;
            this.buttonClearProductFilter.Text = "Xóa bộ lọc";
            this.buttonClearProductFilter.Click += new System.EventHandler(this.buttonClearProductFilter_Click);
            // 
            // buttonClearCategoryFilter
            // 
            this.buttonClearCategoryFilter.Location = new System.Drawing.Point(557, 194);
            this.buttonClearCategoryFilter.Name = "buttonClearCategoryFilter";
            this.buttonClearCategoryFilter.Size = new System.Drawing.Size(94, 29);
            this.buttonClearCategoryFilter.TabIndex = 11;
            this.buttonClearCategoryFilter.Text = "Xóa bộ lọc";
            this.buttonClearCategoryFilter.Click += new System.EventHandler(this.buttonClearCategoryFilter_Click);
            // 
            // ProductManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 785);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManagementForm";
            this.Text = "ProductManagementForm";
            this.Load += new System.EventHandler(this.ProductManagementForm_Load);
            this.panelFilter.ResumeLayout(false);
            this.panelCategoryFilter.ResumeLayout(false);
            this.groupBoxCategoryFilter.ResumeLayout(false);
            this.groupBoxCategoryFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxOriginFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBeanNameFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxCategoryIDFilter.Properties)).EndInit();
            this.panelProductFilter.ResumeLayout(false);
            this.groupBoxProductFilter.ResumeLayout(false);
            this.groupBoxProductFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxToWeightFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductTypeFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxFromWeightFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxProductNameFilter.Properties)).EndInit();
            this.panelProducts.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelDataLoHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loHangSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daiLyCaPheDataSet)).EndInit();
            this.panelDataSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelDataLoHang;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private DevExpress.XtraEditors.LabelControl labelCategory;
        private System.Windows.Forms.Panel panelDataSanPham;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private DevExpress.XtraEditors.LabelControl labelProduct;
        private DBConnection.DaiLyCaPheDataSet daiLyCaPheDataSet;
        private System.Windows.Forms.BindingSource loHangSanPhamBindingSource;
        private DBConnection.DaiLyCaPheDataSetTableAdapters.LoHang_SanPhamTableAdapter loHang_SanPhamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLoHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiHatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuatXuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanSuDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private DBConnection.DaiLyCaPheDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.Panel panelCategoryFilter;
        private System.Windows.Forms.Panel panelProductFilter;
        private DevExpress.XtraEditors.TextEdit textBoxProductNameFilter;
        private DevExpress.XtraEditors.LabelControl labelProductNameFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trongLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanSuDungDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongTonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBoxCategoryFilter;
        private DevExpress.XtraEditors.TextEdit textBoxOriginFilter;
        private DevExpress.XtraEditors.LabelControl labelBeanOrigin;
        private DevExpress.XtraEditors.TextEdit textBoxBeanNameFilter;
        private DevExpress.XtraEditors.LabelControl labelBeanName;
        private DevExpress.XtraEditors.TextEdit textBoxCategoryIDFilter;
        private DevExpress.XtraEditors.LabelControl labelCategoryID;
        private System.Windows.Forms.GroupBox groupBoxProductFilter;
        private DevExpress.XtraEditors.TextEdit textBoxProductTypeFilter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textBoxFromWeightFilter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textBoxToWeightFilter;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton buttonClearCategoryFilter;
        private DevExpress.XtraEditors.SimpleButton buttonClearProductFilter;
    }
}