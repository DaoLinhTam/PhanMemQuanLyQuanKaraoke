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
            this.quanLyKaraoke = new GUI.QuanLyKaraoke();
            this.nGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOIDUNGTableAdapter = new GUI.QuanLyKaraokeTableAdapters.NGUOIDUNGTableAdapter();
            this.tableAdapterManager = new GUI.QuanLyKaraokeTableAdapters.TableAdapterManager();
            this.nHANVIENTableAdapter = new GUI.QuanLyKaraokeTableAdapters.NHANVIENTableAdapter();
            this.nGUOIDUNGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mANVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENNVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nGAYSINHDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.qUEQUANTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bindingNavigatorNhanVien = new System.Windows.Forms.BindingNavigator(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKaraoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mANVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENNVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUEQUANTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorNhanVien)).BeginInit();
            this.bindingNavigatorNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(38, 44);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(99, 17);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã Nhân Viên :";
            // 
            // tENNVLabel
            // 
            tENNVLabel.AutoSize = true;
            tENNVLabel.Location = new System.Drawing.Point(32, 72);
            tENNVLabel.Name = "tENNVLabel";
            tENNVLabel.Size = new System.Drawing.Size(105, 17);
            tENNVLabel.TabIndex = 2;
            tENNVLabel.Text = "Tên Nhân Viên :";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(98, 100);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(39, 17);
            sDTLabel.TabIndex = 4;
            sDTLabel.Text = "SDT:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(58, 128);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(79, 17);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "Ngày Sinh :";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(78, 156);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(59, 17);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa Chỉ :";
            // 
            // qUEQUANLabel
            // 
            qUEQUANLabel.AutoSize = true;
            qUEQUANLabel.Location = new System.Drawing.Point(58, 184);
            qUEQUANLabel.Name = "qUEQUANLabel";
            qUEQUANLabel.Size = new System.Drawing.Size(79, 17);
            qUEQUANLabel.TabIndex = 10;
            qUEQUANLabel.Text = "Quê Quán :";
            // 
            // quanLyKaraoke
            // 
            this.quanLyKaraoke.DataSetName = "QuanLyKaraoke";
            this.quanLyKaraoke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGBindingSource.DataMember = "NGUOIDUNG";
            this.nGUOIDUNGBindingSource.DataSource = this.quanLyKaraoke;
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
            this.tableAdapterManager.UpdateOrder = GUI.QuanLyKaraokeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // nGUOIDUNGGridControl
            // 
            this.nGUOIDUNGGridControl.DataSource = this.nGUOIDUNGBindingSource;
            this.nGUOIDUNGGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nGUOIDUNGGridControl.Location = new System.Drawing.Point(374, 3);
            this.nGUOIDUNGGridControl.MainView = this.gridView1;
            this.nGUOIDUNGGridControl.Name = "nGUOIDUNGGridControl";
            this.nGUOIDUNGGridControl.Size = new System.Drawing.Size(799, 307);
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
            this.nHANVIENBindingSource.DataSource = this.quanLyKaraoke;
            // 
            // nHANVIENGridControl
            // 
            this.nHANVIENGridControl.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nHANVIENGridControl.Location = new System.Drawing.Point(3, 322);
            this.nHANVIENGridControl.MainView = this.gridView2;
            this.nHANVIENGridControl.Name = "nHANVIENGridControl";
            this.nHANVIENGridControl.Size = new System.Drawing.Size(1176, 331);
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
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.nHANVIENGridControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21951F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 656);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.63265F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.36735F));
            this.tableLayoutPanel2.Controls.Add(this.nGUOIDUNGGridControl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1176, 313);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bindingNavigatorNhanVien, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.86414F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.13586F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(365, 307);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(mANVLabel);
            this.panel1.Controls.Add(this.mANVTextEdit);
            this.panel1.Controls.Add(tENNVLabel);
            this.panel1.Controls.Add(this.tENNVTextEdit);
            this.panel1.Controls.Add(sDTLabel);
            this.panel1.Controls.Add(this.sDTTextEdit);
            this.panel1.Controls.Add(nGAYSINHLabel);
            this.panel1.Controls.Add(this.nGAYSINHDateEdit);
            this.panel1.Controls.Add(dIACHILabel);
            this.panel1.Controls.Add(this.dIACHITextEdit);
            this.panel1.Controls.Add(qUEQUANLabel);
            this.panel1.Controls.Add(this.qUEQUANTextEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 266);
            this.panel1.TabIndex = 1;
            // 
            // mANVTextEdit
            // 
            this.mANVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "MANV", true));
            this.mANVTextEdit.Location = new System.Drawing.Point(149, 41);
            this.mANVTextEdit.Name = "mANVTextEdit";
            this.mANVTextEdit.Size = new System.Drawing.Size(176, 22);
            this.mANVTextEdit.TabIndex = 1;
            // 
            // tENNVTextEdit
            // 
            this.tENNVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "TENNV", true));
            this.tENNVTextEdit.Location = new System.Drawing.Point(149, 69);
            this.tENNVTextEdit.Name = "tENNVTextEdit";
            this.tENNVTextEdit.Size = new System.Drawing.Size(176, 22);
            this.tENNVTextEdit.TabIndex = 3;
            // 
            // sDTTextEdit
            // 
            this.sDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "SDT", true));
            this.sDTTextEdit.Location = new System.Drawing.Point(149, 97);
            this.sDTTextEdit.Name = "sDTTextEdit";
            this.sDTTextEdit.Size = new System.Drawing.Size(176, 22);
            this.sDTTextEdit.TabIndex = 5;
            // 
            // nGAYSINHDateEdit
            // 
            this.nGAYSINHDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "NGAYSINH", true));
            this.nGAYSINHDateEdit.EditValue = null;
            this.nGAYSINHDateEdit.Location = new System.Drawing.Point(149, 125);
            this.nGAYSINHDateEdit.Name = "nGAYSINHDateEdit";
            this.nGAYSINHDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Size = new System.Drawing.Size(176, 22);
            this.nGAYSINHDateEdit.TabIndex = 7;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(149, 153);
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Size = new System.Drawing.Size(176, 22);
            this.dIACHITextEdit.TabIndex = 9;
            // 
            // qUEQUANTextEdit
            // 
            this.qUEQUANTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "QUEQUAN", true));
            this.qUEQUANTextEdit.Location = new System.Drawing.Point(149, 181);
            this.qUEQUANTextEdit.Name = "qUEQUANTextEdit";
            this.qUEQUANTextEdit.Size = new System.Drawing.Size(176, 22);
            this.qUEQUANTextEdit.TabIndex = 11;
            // 
            // bindingNavigatorNhanVien
            // 
            this.bindingNavigatorNhanVien.AddNewItem = this.toolStripButton1;
            this.bindingNavigatorNhanVien.BindingSource = this.nHANVIENBindingSource;
            this.bindingNavigatorNhanVien.CountItem = null;
            this.bindingNavigatorNhanVien.DeleteItem = this.toolStripButton2;
            this.bindingNavigatorNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigatorNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.bindingNavigatorNhanVien.Location = new System.Drawing.Point(0, 272);
            this.bindingNavigatorNhanVien.MoveFirstItem = null;
            this.bindingNavigatorNhanVien.MoveLastItem = null;
            this.bindingNavigatorNhanVien.MoveNextItem = null;
            this.bindingNavigatorNhanVien.MovePreviousItem = null;
            this.bindingNavigatorNhanVien.Name = "bindingNavigatorNhanVien";
            this.bindingNavigatorNhanVien.PositionItem = null;
            this.bindingNavigatorNhanVien.Size = new System.Drawing.Size(365, 35);
            this.bindingNavigatorNhanVien.TabIndex = 4;
            this.bindingNavigatorNhanVien.Text = "4";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(66, 32);
            this.toolStripButton1.Text = "Thêm";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(55, 32);
            this.toolStripButton2.Text = "Xóa";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(54, 32);
            this.toolStripButton3.Text = "Sữa";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(53, 32);
            this.toolStripButton4.Text = "Lưu";
            // 
            // FrmQLND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 656);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmQLND";
            this.Text = "FrmQLND";
            this.Load += new System.EventHandler(this.FrmQLND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKaraoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mANVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENNVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUEQUANTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorNhanVien)).EndInit();
            this.bindingNavigatorNhanVien.ResumeLayout(false);
            this.bindingNavigatorNhanVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QuanLyKaraoke quanLyKaraoke;
        private System.Windows.Forms.BindingSource nGUOIDUNGBindingSource;
        private QuanLyKaraokeTableAdapters.NGUOIDUNGTableAdapter nGUOIDUNGTableAdapter;
        private QuanLyKaraokeTableAdapters.TableAdapterManager tableAdapterManager;
        private QuanLyKaraokeTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DevExpress.XtraGrid.GridControl nGUOIDUNGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DevExpress.XtraGrid.GridControl nHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit mANVTextEdit;
        private DevExpress.XtraEditors.TextEdit tENNVTextEdit;
        private DevExpress.XtraEditors.TextEdit sDTTextEdit;
        private DevExpress.XtraEditors.DateEdit nGAYSINHDateEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.TextEdit qUEQUANTextEdit;
        private System.Windows.Forms.BindingNavigator bindingNavigatorNhanVien;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    }
}