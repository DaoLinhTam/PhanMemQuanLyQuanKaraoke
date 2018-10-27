namespace GUI
{
    partial class FrmQuanLyNguoiDung
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
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.nGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource();
            this.quanLyKaraokeDataSet = new GUI.QuanLyKaraokeDataSet();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.nGUOIDUNGTableAdapter = new GUI.QuanLyKaraokeDataSetTableAdapters.NGUOIDUNGTableAdapter();
            this.tableAdapterManager = new GUI.QuanLyKaraokeDataSetTableAdapters.TableAdapterManager();
            this.vIEW_NGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource();
            this.vIEW_NGUOIDUNGTableAdapter = new GUI.QuanLyKaraokeDataSetTableAdapters.VIEW_NGUOIDUNGTableAdapter();
            this.vIEW_NGUOIDUNGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENDANGNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKaraokeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_NGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_NGUOIDUNGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Nhân Viên";
            this.gridColumn2.FieldName = "TENNHANVIEN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 364;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Đăng Nhập";
            this.gridColumn3.FieldName = "TENDANGNHAP";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 364;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tình Trạng";
            this.gridColumn4.FieldName = "TINHTRANG";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 369;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.vIEW_NGUOIDUNGGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(108, 363, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1332, 709);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // nGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGBindingSource.DataMember = "NGUOIDUNG";
            this.nGUOIDUNGBindingSource.DataSource = this.quanLyKaraokeDataSet;
            // 
            // quanLyKaraokeDataSet
            // 
            this.quanLyKaraokeDataSet.DataSetName = "QuanLyKaraokeDataSet";
            this.quanLyKaraokeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1332, 709);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1312, 345);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // nGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = this.nGUOIDUNGTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.QuanLyKaraokeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vIEW_NGUOIDUNGBindingSource
            // 
            this.vIEW_NGUOIDUNGBindingSource.DataMember = "VIEW_NGUOIDUNG";
            this.vIEW_NGUOIDUNGBindingSource.DataSource = this.quanLyKaraokeDataSet;
            // 
            // vIEW_NGUOIDUNGTableAdapter
            // 
            this.vIEW_NGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // vIEW_NGUOIDUNGGridControl
            // 
            this.vIEW_NGUOIDUNGGridControl.DataSource = this.vIEW_NGUOIDUNGBindingSource;
            this.vIEW_NGUOIDUNGGridControl.Location = new System.Drawing.Point(12, 357);
            this.vIEW_NGUOIDUNGGridControl.MainView = this.gridView2;
            this.vIEW_NGUOIDUNGGridControl.Name = "vIEW_NGUOIDUNGGridControl";
            this.vIEW_NGUOIDUNGGridControl.Size = new System.Drawing.Size(1308, 340);
            this.vIEW_NGUOIDUNGGridControl.TabIndex = 5;
            this.vIEW_NGUOIDUNGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MANV,
            this.TENNHANVIEN,
            this.TENDANGNHAP,
            this.TINHTRANG});
            this.gridView2.GridControl = this.vIEW_NGUOIDUNGGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.vIEW_NGUOIDUNGGridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 345);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1312, 344);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // MANV
            // 
            this.MANV.Caption = "Mã Nhân Viên";
            this.MANV.FieldName = "MANV";
            this.MANV.Name = "MANV";
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 0;
            // 
            // TENNHANVIEN
            // 
            this.TENNHANVIEN.Caption = "Tên Nhân Viên";
            this.TENNHANVIEN.FieldName = "TENNV";
            this.TENNHANVIEN.Name = "TENNHANVIEN";
            this.TENNHANVIEN.Visible = true;
            this.TENNHANVIEN.VisibleIndex = 1;
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.Caption = "Tên Người Dùng";
            this.TENDANGNHAP.FieldName = "TENDANGNHAP";
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.Visible = true;
            this.TENDANGNHAP.VisibleIndex = 2;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.Caption = "Tình Trạng";
            this.TINHTRANG.FieldName = "TINHTRANG";
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.Visible = true;
            this.TINHTRANG.VisibleIndex = 3;
            // 
            // FrmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 709);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmQuanLyNguoiDung";
            this.Text = "Quản Lý Người Dùng";
            this.Load += new System.EventHandler(this.FrmQuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKaraokeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_NGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIEW_NGUOIDUNGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private QuanLyKaraokeDataSet quanLyKaraokeDataSet;
        private System.Windows.Forms.BindingSource nGUOIDUNGBindingSource;
        private QuanLyKaraokeDataSetTableAdapters.NGUOIDUNGTableAdapter nGUOIDUNGTableAdapter;
        private QuanLyKaraokeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vIEW_NGUOIDUNGBindingSource;
        private QuanLyKaraokeDataSetTableAdapters.VIEW_NGUOIDUNGTableAdapter vIEW_NGUOIDUNGTableAdapter;
        private DevExpress.XtraGrid.GridControl vIEW_NGUOIDUNGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn TENNHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn TENDANGNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn TINHTRANG;






    }
}