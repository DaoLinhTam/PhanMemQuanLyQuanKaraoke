namespace GUI
{
    partial class FrmQLNhomND
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
            System.Windows.Forms.Label mANHOMLabel;
            System.Windows.Forms.Label tENNHOMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLNhomND));
            this.qLKaraoke = new GUI.QLKaraoke();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMNGUOIDUNGTableAdapter = new GUI.QLKaraokeTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager = new GUI.QLKaraokeTableAdapters.TableAdapterManager();
            this.nHOMNGUOIDUNGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvNhomND = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nHANVIENBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenNhomND = new System.Windows.Forms.TextBox();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.NguoiDungNhomNguoiDung = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOIDUNG_NHOMNGUOIDUNGTableAdapter = new GUI.QLKaraokeTableAdapters.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter();
            mANHOMLabel = new System.Windows.Forms.Label();
            tENNHOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLKaraoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingNavigator)).BeginInit();
            this.nHANVIENBindingNavigator.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NguoiDungNhomNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // mANHOMLabel
            // 
            mANHOMLabel.AutoSize = true;
            mANHOMLabel.Dock = System.Windows.Forms.DockStyle.Right;
            mANHOMLabel.Location = new System.Drawing.Point(170, 0);
            mANHOMLabel.Name = "mANHOMLabel";
            mANHOMLabel.Size = new System.Drawing.Size(61, 41);
            mANHOMLabel.TabIndex = 0;
            mANHOMLabel.Text = "Mã Nhóm : ";
            mANHOMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tENNHOMLabel
            // 
            tENNHOMLabel.AutoSize = true;
            tENNHOMLabel.Dock = System.Windows.Forms.DockStyle.Right;
            tENNHOMLabel.Location = new System.Drawing.Point(636, 0);
            tENNHOMLabel.Name = "tENNHOMLabel";
            tENNHOMLabel.Size = new System.Drawing.Size(65, 41);
            tENNHOMLabel.TabIndex = 2;
            tENNHOMLabel.Text = "Tên Nhóm : ";
            tENNHOMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // qLKaraoke
            // 
            this.qLKaraoke.DataSetName = "QLKaraoke";
            this.qLKaraoke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataMember = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGBindingSource.DataSource = this.qLKaraoke;
            // 
            // nHOMNGUOIDUNGTableAdapter
            // 
            this.nHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = this.nHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.UpdateOrder = GUI.QLKaraokeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHOMNGUOIDUNGGridControl
            // 
            this.nHOMNGUOIDUNGGridControl.DataSource = this.nHOMNGUOIDUNGBindingSource;
            this.nHOMNGUOIDUNGGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nHOMNGUOIDUNGGridControl.Location = new System.Drawing.Point(3, 50);
            this.nHOMNGUOIDUNGGridControl.MainView = this.gvNhomND;
            this.nHOMNGUOIDUNGGridControl.Name = "nHOMNGUOIDUNGGridControl";
            this.nHOMNGUOIDUNGGridControl.Size = new System.Drawing.Size(1178, 466);
            this.nHOMNGUOIDUNGGridControl.TabIndex = 1;
            this.nHOMNGUOIDUNGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomND});
            // 
            // gvNhomND
            // 
            this.gvNhomND.GridControl = this.nHOMNGUOIDUNGGridControl;
            this.gvNhomND.Name = "gvNhomND";
            this.gvNhomND.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvNhomND.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvNhomND.OptionsBehavior.Editable = false;
            this.gvNhomND.OptionsBehavior.ReadOnly = true;
            this.gvNhomND.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvNhomND.OptionsNavigation.AutoMoveRowFocus = false;
            // 
            // nHANVIENBindingNavigator
            // 
            this.nHANVIENBindingNavigator.AddNewItem = null;
            this.nHANVIENBindingNavigator.AutoSize = false;
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
            this.nHANVIENBindingNavigator.Size = new System.Drawing.Size(1184, 42);
            this.nHANVIENBindingNavigator.TabIndex = 2;
            this.nHANVIENBindingNavigator.Text = "bindingNavigator1";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.nHOMNGUOIDUNGGridControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.055877F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.94412F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 519);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.txtTenNhomND, 4, 0);
            this.tableLayoutPanel2.Controls.Add(tENNHOMLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMaNhom, 2, 0);
            this.tableLayoutPanel2.Controls.Add(mANHOMLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1178, 41);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txtTenNhomND
            // 
            this.txtTenNhomND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHOMNGUOIDUNGBindingSource, "TENNHOM", true));
            this.txtTenNhomND.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTenNhomND.Location = new System.Drawing.Point(707, 15);
            this.txtTenNhomND.Multiline = true;
            this.txtTenNhomND.Name = "txtTenNhomND";
            this.txtTenNhomND.Size = new System.Drawing.Size(347, 23);
            this.txtTenNhomND.TabIndex = 3;
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHOMNGUOIDUNGBindingSource, "MANHOM", true));
            this.txtMaNhom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMaNhom.Location = new System.Drawing.Point(237, 15);
            this.txtMaNhom.Multiline = true;
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.ReadOnly = true;
            this.txtMaNhom.Size = new System.Drawing.Size(347, 23);
            this.txtMaNhom.TabIndex = 1;
            // 
            // NguoiDungNhomNguoiDung
            // 
            this.NguoiDungNhomNguoiDung.DataMember = "NGUOIDUNG_NHOMNGUOIDUNG";
            this.NguoiDungNhomNguoiDung.DataSource = this.qLKaraoke;
            // 
            // nGUOIDUNG_NHOMNGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNG_NHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // FrmQLNhomND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.nHANVIENBindingNavigator);
            this.Name = "FrmQLNhomND";
            this.Text = "FrmQLNhomND";
            this.Load += new System.EventHandler(this.FrmQLNhomND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLKaraoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingNavigator)).EndInit();
            this.nHANVIENBindingNavigator.ResumeLayout(false);
            this.nHANVIENBindingNavigator.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NguoiDungNhomNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLKaraoke qLKaraoke;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private QLKaraokeTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private QLKaraokeTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nHOMNGUOIDUNGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomND;
        private System.Windows.Forms.BindingNavigator nHANVIENBindingNavigator;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtTenNhomND;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.BindingSource NguoiDungNhomNguoiDung;
        private QLKaraokeTableAdapters.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter nGUOIDUNG_NHOMNGUOIDUNGTableAdapter;
    }
}