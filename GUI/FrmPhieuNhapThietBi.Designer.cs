namespace GUI
{
    partial class FrmPhieuNhapThietBi
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

         private void InitializeComponent()
        {
            this.dgvCTPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gvCTPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvPhieuNhapMH = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuNhapMH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usctrTSX = new GUI.usctrThemXoaSua();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuNhapMH)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCTPhieuNhap
            // 
            this.dgvCTPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPhieuNhap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCTPhieuNhap.Location = new System.Drawing.Point(509, 36);
            this.dgvCTPhieuNhap.MainView = this.gvCTPhieuNhap;
            this.dgvCTPhieuNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCTPhieuNhap.Name = "dgvCTPhieuNhap";
            this.dgvCTPhieuNhap.Size = new System.Drawing.Size(501, 411);
            this.dgvCTPhieuNhap.TabIndex = 0;
            this.dgvCTPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPhieuNhap});
            this.dgvCTPhieuNhap.Click += new System.EventHandler(this.dgvCTPhieuNhap_Click);
            // 
            // gvCTPhieuNhap
            // 
            this.gvCTPhieuNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn9,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn10});
            this.gvCTPhieuNhap.GridControl = this.dgvCTPhieuNhap;
            this.gvCTPhieuNhap.Name = "gvCTPhieuNhap";
            this.gvCTPhieuNhap.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên Thiết Bị";
            this.gridColumn6.FieldName = "TENTHIETBI";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Đơn Vị Tính";
            this.gridColumn9.FieldName = "DVT";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Đơn Giá Nhập";
            this.gridColumn7.FieldName = "DGIANHAP";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Số Lượng";
            this.gridColumn8.FieldName = "SLNHAP";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Thành Tiền";
            this.gridColumn10.FieldName = "THANHTIEN";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            // 
            // dgvPhieuNhapMH
            // 
            this.dgvPhieuNhapMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhapMH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPhieuNhapMH.Location = new System.Drawing.Point(3, 36);
            this.dgvPhieuNhapMH.MainView = this.gvPhieuNhapMH;
            this.dgvPhieuNhapMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPhieuNhapMH.Name = "dgvPhieuNhapMH";
            this.dgvPhieuNhapMH.Size = new System.Drawing.Size(500, 411);
            this.dgvPhieuNhapMH.TabIndex = 0;
            this.dgvPhieuNhapMH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuNhapMH});
            // 
            // gvPhieuNhapMH
            // 
            this.gvPhieuNhapMH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvPhieuNhapMH.GridControl = this.dgvPhieuNhapMH;
            this.gvPhieuNhapMH.Name = "gvPhieuNhapMH";
            this.gvPhieuNhapMH.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvPhieuNhapMH.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvPhieuNhapMH_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Nhập";
            this.gridColumn1.FieldName = "MAPHIEUNHAP";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nhân Viên";
            this.gridColumn2.FieldName = "TENNV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày Nhập";
            this.gridColumn3.FieldName = "NGAYNHAP";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tông Tiền ";
            this.gridColumn4.FieldName = "TONGTIEN";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // usctrTSX
            // 
            this.usctrTSX.Location = new System.Drawing.Point(3, 3);
            this.usctrTSX.Name = "usctrTSX";
            this.usctrTSX.Size = new System.Drawing.Size(477, 28);
            this.usctrTSX.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvCTPhieuNhap, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.usctrTSX, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvPhieuNhapMH, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.7951F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.2049F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 449);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // FrmPhieuNhapThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPhieuNhapThietBi";
            this.Text = "Phiếu Nhập Thiết Bị";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuNhapMH)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        private DevExpress.XtraGrid.GridControl dgvCTPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.GridControl dgvPhieuNhapMH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuNhapMH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private usctrThemXoaSua usctrTSX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}