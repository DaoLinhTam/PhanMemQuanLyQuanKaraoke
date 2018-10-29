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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLND));
            this.qLKaraoke = new GUI.QLKaraoke();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new GUI.QLKaraokeTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new GUI.QLKaraokeTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblThongTinNV = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.nHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvQLND = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUEQUAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.nHANVIENBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.NguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOIDUNGTableAdapter = new GUI.QLKaraokeTableAdapters.NGUOIDUNGTableAdapter();
            mANVLabel = new System.Windows.Forms.Label();
            tENNVLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            qUEQUANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLKaraoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tblThongTinNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingNavigator)).BeginInit();
            this.nHANVIENBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NguoiDungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            mANVLabel.Location = new System.Drawing.Point(3, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(106, 39);
            mANVLabel.TabIndex = 14;
            mANVLabel.Text = "Mã Nhân Viên";
            mANVLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tENNVLabel
            // 
            tENNVLabel.AutoSize = true;
            tENNVLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            tENNVLabel.Location = new System.Drawing.Point(3, 39);
            tENNVLabel.Name = "tENNVLabel";
            tENNVLabel.Size = new System.Drawing.Size(106, 40);
            tENNVLabel.TabIndex = 16;
            tENNVLabel.Text = "Tên Nhân Viên :";
            tENNVLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            sDTLabel.Location = new System.Drawing.Point(339, 0);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(106, 39);
            sDTLabel.TabIndex = 18;
            sDTLabel.Text = "Số Điện Thoại :";
            sDTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            nGAYSINHLabel.Location = new System.Drawing.Point(339, 39);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(106, 40);
            nGAYSINHLabel.TabIndex = 20;
            nGAYSINHLabel.Text = "Ngày Sinh :";
            nGAYSINHLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Dock = System.Windows.Forms.DockStyle.Fill;
            dIACHILabel.Location = new System.Drawing.Point(675, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(106, 39);
            dIACHILabel.TabIndex = 22;
            dIACHILabel.Text = "Địa Chỉ : ";
            dIACHILabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qUEQUANLabel
            // 
            qUEQUANLabel.AutoSize = true;
            qUEQUANLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            qUEQUANLabel.Location = new System.Drawing.Point(675, 39);
            qUEQUANLabel.Name = "qUEQUANLabel";
            qUEQUANLabel.Size = new System.Drawing.Size(106, 40);
            qUEQUANLabel.TabIndex = 24;
            qUEQUANLabel.Text = "Quê Quán :";
            qUEQUANLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qLKaraoke
            // 
            this.qLKaraoke.DataSetName = "QLKaraoke";
            this.qLKaraoke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLKaraoke;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.QLKaraokeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nHANVIENGridControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.38493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.61507F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1021, 491);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblThongTinNV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 99);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên ";
            // 
            // tblThongTinNV
            // 
            this.tblThongTinNV.ColumnCount = 6;
            this.tblThongTinNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblThongTinNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tblThongTinNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblThongTinNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tblThongTinNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblThongTinNV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tblThongTinNV.Controls.Add(qUEQUANLabel, 4, 1);
            this.tblThongTinNV.Controls.Add(dIACHILabel, 4, 0);
            this.tblThongTinNV.Controls.Add(nGAYSINHLabel, 2, 1);
            this.tblThongTinNV.Controls.Add(sDTLabel, 2, 0);
            this.tblThongTinNV.Controls.Add(tENNVLabel, 0, 1);
            this.tblThongTinNV.Controls.Add(mANVLabel, 0, 0);
            this.tblThongTinNV.Controls.Add(this.txtMaNV, 1, 0);
            this.tblThongTinNV.Controls.Add(this.txtTenNV, 1, 1);
            this.tblThongTinNV.Controls.Add(this.txtSDT, 3, 0);
            this.tblThongTinNV.Controls.Add(this.txtDiaChi, 5, 0);
            this.tblThongTinNV.Controls.Add(this.txtQueQuan, 5, 1);
            this.tblThongTinNV.Controls.Add(this.dtpNgaySinh, 3, 1);
            this.tblThongTinNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblThongTinNV.Location = new System.Drawing.Point(3, 17);
            this.tblThongTinNV.Name = "tblThongTinNV";
            this.tblThongTinNV.RowCount = 2;
            this.tblThongTinNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThongTinNV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblThongTinNV.Size = new System.Drawing.Size(1009, 79);
            this.tblThongTinNV.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "MANV", true));
            this.txtMaNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaNV.Location = new System.Drawing.Point(115, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(218, 21);
            this.txtMaNV.TabIndex = 15;
            // 
            // txtTenNV
            // 
            this.txtTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "TENNV", true));
            this.txtTenNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNV.Location = new System.Drawing.Point(115, 42);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(218, 21);
            this.txtTenNV.TabIndex = 17;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "SDT", true));
            this.txtSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT.Location = new System.Drawing.Point(451, 3);
            this.txtSDT.MaxLength = 11;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(218, 21);
            this.txtSDT.TabIndex = 19;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "DIACHI", true));
            this.txtDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiaChi.Location = new System.Drawing.Point(787, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(219, 21);
            this.txtDiaChi.TabIndex = 23;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.AutoCompleteCustomSource.AddRange(new string[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang\tHà Nam",
            "Hà Tĩnh",
            "Hải Dương",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái",
            "Phú Yên\tCần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM"});
            this.txtQueQuan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQueQuan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtQueQuan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "QUEQUAN", true));
            this.txtQueQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQueQuan.Location = new System.Drawing.Point(787, 42);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(219, 21);
            this.txtQueQuan.TabIndex = 25;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nHANVIENBindingSource, "NGAYSINH", true));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(451, 42);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 21);
            this.dtpNgaySinh.TabIndex = 26;
            // 
            // nHANVIENGridControl
            // 
            this.nHANVIENGridControl.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.nHANVIENGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.nHANVIENGridControl.Location = new System.Drawing.Point(3, 108);
            this.nHANVIENGridControl.MainView = this.gvQLND;
            this.nHANVIENGridControl.Name = "nHANVIENGridControl";
            this.nHANVIENGridControl.Size = new System.Drawing.Size(1015, 380);
            this.nHANVIENGridControl.TabIndex = 1;
            this.nHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQLND});
            // 
            // gvQLND
            // 
            this.gvQLND.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colTENNV,
            this.colSDT,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colQUEQUAN});
            this.gvQLND.GridControl = this.nHANVIENGridControl;
            this.gvQLND.Name = "gvQLND";
            this.gvQLND.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvQLND.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvQLND.OptionsBehavior.Editable = false;
            this.gvQLND.OptionsBehavior.ReadOnly = true;
            this.gvQLND.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvQLND.OptionsNavigation.AutoMoveRowFocus = false;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colTENNV
            // 
            this.colTENNV.Caption = "Tên Nhân Viên";
            this.colTENNV.FieldName = "TENNV";
            this.colTENNV.Name = "colTENNV";
            this.colTENNV.Visible = true;
            this.colTENNV.VisibleIndex = 1;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Số Điện Thoại";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 2;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày Sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colQUEQUAN
            // 
            this.colQUEQUAN.Caption = "Quê Quán";
            this.colQUEQUAN.FieldName = "QUEQUAN";
            this.colQUEQUAN.Name = "colQUEQUAN";
            this.colQUEQUAN.Visible = true;
            this.colQUEQUAN.VisibleIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.Name = "btnThem";
            this.btnThem.RightToLeftAutoMirrorImage = true;
            this.btnThem.Size = new System.Drawing.Size(74, 39);
            this.btnThem.Text = "Thêm";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeftAutoMirrorImage = true;
            this.btnXoa.Size = new System.Drawing.Size(63, 39);
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(62, 39);
            this.btnSua.Text = "Sữa";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(63, 39);
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(65, 39);
            this.btnHuy.Text = "Hủy";
            // 
            // nHANVIENBindingNavigator
            // 
            this.nHANVIENBindingNavigator.AddNewItem = null;
            this.nHANVIENBindingNavigator.AutoSize = false;
            this.nHANVIENBindingNavigator.BindingSource = this.nHANVIENBindingSource;
            this.nHANVIENBindingNavigator.CountItem = null;
            this.nHANVIENBindingNavigator.DeleteItem = null;
            this.nHANVIENBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.btnHuy});
            this.nHANVIENBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nHANVIENBindingNavigator.MoveFirstItem = null;
            this.nHANVIENBindingNavigator.MoveLastItem = null;
            this.nHANVIENBindingNavigator.MoveNextItem = null;
            this.nHANVIENBindingNavigator.MovePreviousItem = null;
            this.nHANVIENBindingNavigator.Name = "nHANVIENBindingNavigator";
            this.nHANVIENBindingNavigator.PositionItem = null;
            this.nHANVIENBindingNavigator.Size = new System.Drawing.Size(1021, 42);
            this.nHANVIENBindingNavigator.TabIndex = 0;
            this.nHANVIENBindingNavigator.Text = "bindingNavigator1";
            // 
            // NguoiDungBindingSource
            // 
            this.NguoiDungBindingSource.DataMember = "NGUOIDUNG";
            this.NguoiDungBindingSource.DataSource = this.qLKaraoke;
            // 
            // nGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // FrmQLND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 533);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.nHANVIENBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmQLND";
            this.Text = "FrmQLND";
            this.Load += new System.EventHandler(this.FrmQLND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLKaraoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tblThongTinNV.ResumeLayout(false);
            this.tblThongTinNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingNavigator)).EndInit();
            this.nHANVIENBindingNavigator.ResumeLayout(false);
            this.nHANVIENBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NguoiDungBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLKaraoke qLKaraoke;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLKaraokeTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private QLKaraokeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tblThongTinNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.BindingNavigator nHANVIENBindingNavigator;
        private DevExpress.XtraGrid.GridControl nHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvQLND;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNV;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colQUEQUAN;
        private System.Windows.Forms.BindingSource NguoiDungBindingSource;
        private QLKaraokeTableAdapters.NGUOIDUNGTableAdapter nGUOIDUNGTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;



    }
}