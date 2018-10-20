namespace GUI
{
    partial class FrmQLND
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label tENNVLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label qUEQUANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLND));
            System.Windows.Forms.Label tENDANGNHAPLabel;
            System.Windows.Forms.Label mATKHAULabel;
            System.Windows.Forms.Label tINHTRANGLabel;
            this.quanLyKaraokeDataSet = new GUI.QuanLyKaraokeDataSet();
            this.nGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOIDUNGTableAdapter = new GUI.QuanLyKaraokeDataSetTableAdapters.NGUOIDUNGTableAdapter();
            this.tableAdapterManager = new GUI.QuanLyKaraokeDataSetTableAdapters.TableAdapterManager();
            this.nHANVIENTableAdapter = new GUI.QuanLyKaraokeDataSetTableAdapters.NHANVIENTableAdapter();
            this.nGUOIDUNGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mANVTextBox = new System.Windows.Forms.TextBox();
            this.tENNVTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.nGAYSINHDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.qUEQUANTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorNhanVien = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tENDANGNHAPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tINHTRANGCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingNavigatorNguoiDung = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            mANVLabel = new System.Windows.Forms.Label();
            tENNVLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            qUEQUANLabel = new System.Windows.Forms.Label();
            tENDANGNHAPLabel = new System.Windows.Forms.Label();
            mATKHAULabel = new System.Windows.Forms.Label();
            tINHTRANGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKaraokeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorNhanVien)).BeginInit();
            this.bindingNavigatorNhanVien.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENDANGNHAPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorNguoiDung)).BeginInit();
            this.bindingNavigatorNguoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(13, 36);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(82, 13);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã Nhân Viên : ";
            // 
            // tENNVLabel
            // 
            tENNVLabel.AutoSize = true;
            tENNVLabel.Location = new System.Drawing.Point(9, 63);
            tENNVLabel.Name = "tENNVLabel";
            tENNVLabel.Size = new System.Drawing.Size(86, 13);
            tENNVLabel.TabIndex = 2;
            tENNVLabel.Text = "Tên Nhân Viên : ";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(61, 90);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(30, 13);
            sDTLabel.TabIndex = 4;
            sDTLabel.Text = "SDT:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(29, 120);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(62, 13);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "Ngày Sinh :";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(43, 144);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(48, 13);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa Chỉ :";
            // 
            // qUEQUANLabel
            // 
            qUEQUANLabel.AutoSize = true;
            qUEQUANLabel.Location = new System.Drawing.Point(29, 171);
            qUEQUANLabel.Name = "qUEQUANLabel";
            qUEQUANLabel.Size = new System.Drawing.Size(66, 13);
            qUEQUANLabel.TabIndex = 10;
            qUEQUANLabel.Text = "Quê Quán : ";
            // 
            // quanLyKaraokeDataSet
            // 
            this.quanLyKaraokeDataSet.DataSetName = "QuanLyKaraokeDataSet";
            this.quanLyKaraokeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGBindingSource.DataMember = "NGUOIDUNG";
            this.nGUOIDUNGBindingSource.DataSource = this.quanLyKaraokeDataSet;
            // 
            // nGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = this.nGUOIDUNGTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = GUI.QuanLyKaraokeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // nGUOIDUNGGridControl
            // 
            this.nGUOIDUNGGridControl.DataSource = this.nGUOIDUNGBindingSource;
            this.nGUOIDUNGGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nGUOIDUNGGridControl.Location = new System.Drawing.Point(321, 406);
            this.nGUOIDUNGGridControl.MainView = this.gridView1;
            this.nGUOIDUNGGridControl.Name = "nGUOIDUNGGridControl";
            this.nGUOIDUNGGridControl.Size = new System.Drawing.Size(860, 152);
            this.nGUOIDUNGGridControl.TabIndex = 1;
            this.nGUOIDUNGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.nGUOIDUNGGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.quanLyKaraokeDataSet;
            // 
            // nHANVIENGridControl
            // 
            this.nHANVIENGridControl.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nHANVIENGridControl.Location = new System.Drawing.Point(321, 3);
            this.nHANVIENGridControl.MainView = this.gridView2;
            this.nHANVIENGridControl.Name = "nHANVIENGridControl";
            this.nHANVIENGridControl.Size = new System.Drawing.Size(860, 397);
            this.nHANVIENGridControl.TabIndex = 2;
            this.nHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.nHANVIENGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.85811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.14189F));
            this.tableLayoutPanel1.Controls.Add(this.nHANVIENGridControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nGUOIDUNGGridControl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.01426F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.98574F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 561);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bindingNavigatorNhanVien, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(312, 397);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(mANVLabel);
            this.panel1.Controls.Add(this.mANVTextBox);
            this.panel1.Controls.Add(tENNVLabel);
            this.panel1.Controls.Add(this.tENNVTextBox);
            this.panel1.Controls.Add(sDTLabel);
            this.panel1.Controls.Add(this.sDTTextBox);
            this.panel1.Controls.Add(nGAYSINHLabel);
            this.panel1.Controls.Add(this.nGAYSINHDateTimePicker);
            this.panel1.Controls.Add(dIACHILabel);
            this.panel1.Controls.Add(this.dIACHITextBox);
            this.panel1.Controls.Add(qUEQUANLabel);
            this.panel1.Controls.Add(this.qUEQUANTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 351);
            this.panel1.TabIndex = 0;
            // 
            // mANVTextBox
            // 
            this.mANVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "MANV", true));
            this.mANVTextBox.Location = new System.Drawing.Point(97, 33);
            this.mANVTextBox.Name = "mANVTextBox";
            this.mANVTextBox.Size = new System.Drawing.Size(200, 21);
            this.mANVTextBox.TabIndex = 1;
            // 
            // tENNVTextBox
            // 
            this.tENNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "TENNV", true));
            this.tENNVTextBox.Location = new System.Drawing.Point(97, 60);
            this.tENNVTextBox.Name = "tENNVTextBox";
            this.tENNVTextBox.Size = new System.Drawing.Size(200, 21);
            this.tENNVTextBox.TabIndex = 3;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(97, 87);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(200, 21);
            this.sDTTextBox.TabIndex = 5;
            // 
            // nGAYSINHDateTimePicker
            // 
            this.nGAYSINHDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nHANVIENBindingSource, "NGAYSINH", true));
            this.nGAYSINHDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nGAYSINHDateTimePicker.Location = new System.Drawing.Point(97, 114);
            this.nGAYSINHDateTimePicker.Name = "nGAYSINHDateTimePicker";
            this.nGAYSINHDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.nGAYSINHDateTimePicker.TabIndex = 7;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(97, 141);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(200, 21);
            this.dIACHITextBox.TabIndex = 9;
            // 
            // qUEQUANTextBox
            // 
            this.qUEQUANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "QUEQUAN", true));
            this.qUEQUANTextBox.Location = new System.Drawing.Point(97, 168);
            this.qUEQUANTextBox.Name = "qUEQUANTextBox";
            this.qUEQUANTextBox.Size = new System.Drawing.Size(200, 21);
            this.qUEQUANTextBox.TabIndex = 11;
            // 
            // bindingNavigatorNhanVien
            // 
            this.bindingNavigatorNhanVien.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorNhanVien.BindingSource = this.nHANVIENBindingSource;
            this.bindingNavigatorNhanVien.CountItem = null;
            this.bindingNavigatorNhanVien.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigatorNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton7,
            this.toolStripButton8});
            this.bindingNavigatorNhanVien.Location = new System.Drawing.Point(0, 357);
            this.bindingNavigatorNhanVien.MoveFirstItem = null;
            this.bindingNavigatorNhanVien.MoveLastItem = null;
            this.bindingNavigatorNhanVien.MoveNextItem = null;
            this.bindingNavigatorNhanVien.MovePreviousItem = null;
            this.bindingNavigatorNhanVien.Name = "bindingNavigatorNhanVien";
            this.bindingNavigatorNhanVien.PositionItem = null;
            this.bindingNavigatorNhanVien.Size = new System.Drawing.Size(312, 40);
            this.bindingNavigatorNhanVien.TabIndex = 1;
            this.bindingNavigatorNhanVien.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(58, 37);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(47, 37);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(46, 37);
            this.toolStripButton7.Text = "Sữa";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(47, 37);
            this.toolStripButton8.Text = "Lưu";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.bindingNavigatorNguoiDung, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 406);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(312, 152);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(tENDANGNHAPLabel);
            this.panel2.Controls.Add(this.tENDANGNHAPTextEdit);
            this.panel2.Controls.Add(mATKHAULabel);
            this.panel2.Controls.Add(tINHTRANGLabel);
            this.panel2.Controls.Add(this.tINHTRANGCheckBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 115);
            this.panel2.TabIndex = 0;
            // 
            // tENDANGNHAPLabel
            // 
            tENDANGNHAPLabel.AutoSize = true;
            tENDANGNHAPLabel.Location = new System.Drawing.Point(28, 36);
            tENDANGNHAPLabel.Name = "tENDANGNHAPLabel";
            tENDANGNHAPLabel.Size = new System.Drawing.Size(89, 13);
            tENDANGNHAPLabel.TabIndex = 0;
            tENDANGNHAPLabel.Text = "Tên Đăng Nhập :";
            // 
            // tENDANGNHAPTextEdit
            // 
            this.tENDANGNHAPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nGUOIDUNGBindingSource, "TENDANGNHAP", true));
            this.tENDANGNHAPTextEdit.Location = new System.Drawing.Point(119, 33);
            this.tENDANGNHAPTextEdit.Name = "tENDANGNHAPTextEdit";
            this.tENDANGNHAPTextEdit.Size = new System.Drawing.Size(104, 20);
            this.tENDANGNHAPTextEdit.TabIndex = 1;
            // 
            // mATKHAULabel
            // 
            mATKHAULabel.AutoSize = true;
            mATKHAULabel.Location = new System.Drawing.Point(28, 48);
            mATKHAULabel.Name = "mATKHAULabel";
            mATKHAULabel.Size = new System.Drawing.Size(0, 13);
            mATKHAULabel.TabIndex = 4;
            // 
            // tINHTRANGLabel
            // 
            tINHTRANGLabel.AutoSize = true;
            tINHTRANGLabel.Location = new System.Drawing.Point(28, 64);
            tINHTRANGLabel.Name = "tINHTRANGLabel";
            tINHTRANGLabel.Size = new System.Drawing.Size(65, 13);
            tINHTRANGLabel.TabIndex = 6;
            tINHTRANGLabel.Text = "Tình Trạng :";
            // 
            // tINHTRANGCheckBox
            // 
            this.tINHTRANGCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckAlign", this.nGUOIDUNGBindingSource, "TINHTRANG", true));
            this.tINHTRANGCheckBox.Location = new System.Drawing.Point(119, 59);
            this.tINHTRANGCheckBox.Name = "tINHTRANGCheckBox";
            this.tINHTRANGCheckBox.Size = new System.Drawing.Size(104, 24);
            this.tINHTRANGCheckBox.TabIndex = 7;
            this.tINHTRANGCheckBox.Text = "Khóa";
            this.tINHTRANGCheckBox.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorNguoiDung
            // 
            this.bindingNavigatorNguoiDung.AddNewItem = this.toolStripButton1;
            this.bindingNavigatorNguoiDung.BindingSource = this.nGUOIDUNGBindingSource;
            this.bindingNavigatorNguoiDung.CountItem = null;
            this.bindingNavigatorNguoiDung.DeleteItem = this.toolStripButton2;
            this.bindingNavigatorNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigatorNguoiDung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.bindingNavigatorNguoiDung.Location = new System.Drawing.Point(0, 121);
            this.bindingNavigatorNguoiDung.MoveFirstItem = null;
            this.bindingNavigatorNguoiDung.MoveLastItem = null;
            this.bindingNavigatorNguoiDung.MoveNextItem = null;
            this.bindingNavigatorNguoiDung.MovePreviousItem = null;
            this.bindingNavigatorNguoiDung.Name = "bindingNavigatorNguoiDung";
            this.bindingNavigatorNguoiDung.PositionItem = null;
            this.bindingNavigatorNguoiDung.Size = new System.Drawing.Size(312, 31);
            this.bindingNavigatorNguoiDung.TabIndex = 2;
            this.bindingNavigatorNguoiDung.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(58, 28);
            this.toolStripButton1.Text = "Thêm";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(47, 28);
            this.toolStripButton2.Text = "Xóa";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(46, 28);
            this.toolStripButton3.Text = "Sữa";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(47, 28);
            this.toolStripButton4.Text = "Lưu";
            // 
            // FrmQLND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmQLND";
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.FrmQLND_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKaraokeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorNhanVien)).EndInit();
            this.bindingNavigatorNhanVien.ResumeLayout(false);
            this.bindingNavigatorNhanVien.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENDANGNHAPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorNguoiDung)).EndInit();
            this.bindingNavigatorNguoiDung.ResumeLayout(false);
            this.bindingNavigatorNguoiDung.PerformLayout();
            this.ResumeLayout(false);

        }

        private QuanLyKaraokeDataSet quanLyKaraokeDataSet;
        private System.Windows.Forms.BindingSource nGUOIDUNGBindingSource;
        private QuanLyKaraokeDataSetTableAdapters.NGUOIDUNGTableAdapter nGUOIDUNGTableAdapter;
        private QuanLyKaraokeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QuanLyKaraokeDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DevExpress.XtraGrid.GridControl nGUOIDUNGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DevExpress.XtraGrid.GridControl nHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox mANVTextBox;
        private System.Windows.Forms.TextBox tENNVTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.DateTimePicker nGAYSINHDateTimePicker;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.TextBox qUEQUANTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigatorNhanVien;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.BindingNavigator bindingNavigatorNguoiDung;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit tENDANGNHAPTextEdit;
        private System.Windows.Forms.CheckBox tINHTRANGCheckBox;

   




    }
   	#endregion 

}