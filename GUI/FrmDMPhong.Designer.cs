namespace GUI
{
    partial class FrmDMPhong
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
            this.usctrTXS = new GUI.usctrThemXoaSua();
            this.usctrThemXoaSua1 = new GUI.usctrThemXoaSua();
            this.gbPhong = new System.Windows.Forms.GroupBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtKhuVuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gvPhong = new DevExpress.XtraGrid.GridControl();
            this.gCPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MALOAIPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KHUVUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TINHTRANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // usctrTXS
            // 
            this.usctrTXS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usctrTXS.Location = new System.Drawing.Point(3, 96);
            this.usctrTXS.Name = "usctrTXS";
            this.usctrTXS.Size = new System.Drawing.Size(599, 36);
            this.usctrTXS.TabIndex = 1;
            // 
            // usctrThemXoaSua1
            // 
            this.usctrThemXoaSua1.Location = new System.Drawing.Point(12, 8);
            this.usctrThemXoaSua1.Name = "usctrThemXoaSua1";
            this.usctrThemXoaSua1.Size = new System.Drawing.Size(599, 36);
            this.usctrThemXoaSua1.TabIndex = 2;
            // 
            // gbPhong
            // 
            this.gbPhong.Controls.Add(this.cbTinhTrang);
            this.gbPhong.Controls.Add(this.label1);
            this.gbPhong.Controls.Add(this.cbMaLoaiPhong);
            this.gbPhong.Controls.Add(this.label5);
            this.gbPhong.Controls.Add(this.label3);
            this.gbPhong.Controls.Add(this.txtMaPhong);
            this.gbPhong.Controls.Add(this.txtKhuVuc);
            this.gbPhong.Controls.Add(this.label4);
            this.gbPhong.Location = new System.Drawing.Point(12, 50);
            this.gbPhong.Name = "gbPhong";
            this.gbPhong.Size = new System.Drawing.Size(978, 91);
            this.gbPhong.TabIndex = 5;
            this.gbPhong.TabStop = false;
            this.gbPhong.Text = "Danh sách phòng";
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbTinhTrang.Location = new System.Drawing.Point(438, 51);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(144, 21);
            this.cbTinhTrang.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tình trạng";
            // 
            // cbMaLoaiPhong
            // 
            this.cbMaLoaiPhong.FormattingEnabled = true;
            this.cbMaLoaiPhong.Location = new System.Drawing.Point(438, 20);
            this.cbMaLoaiPhong.Name = "cbMaLoaiPhong";
            this.cbMaLoaiPhong.Size = new System.Drawing.Size(144, 21);
            this.cbMaLoaiPhong.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khu vực";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(143, 21);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(147, 21);
            this.txtMaPhong.TabIndex = 4;
            // 
            // txtKhuVuc
            // 
            this.txtKhuVuc.Location = new System.Drawing.Point(143, 51);
            this.txtKhuVuc.Name = "txtKhuVuc";
            this.txtKhuVuc.Size = new System.Drawing.Size(147, 21);
            this.txtKhuVuc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã phòng";
            // 
            // gvPhong
            // 
            this.gvPhong.Location = new System.Drawing.Point(12, 161);
            this.gvPhong.MainView = this.gCPhong;
            this.gvPhong.Name = "gvPhong";
            this.gvPhong.Size = new System.Drawing.Size(978, 276);
            this.gvPhong.TabIndex = 6;
            this.gvPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gCPhong});
            // 
            // gCPhong
            // 
            this.gCPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAPH,
            this.MALOAIPH,
            this.KHUVUC,
            this.TINHTRANG});
            this.gCPhong.GridControl = this.gvPhong;
            this.gCPhong.Name = "gCPhong";
            this.gCPhong.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gCPhong.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gCPhong_FocusedRowChanged_1);
            // 
            // MAPH
            // 
            this.MAPH.Caption = "Mã phòng";
            this.MAPH.FieldName = "MAPH";
            this.MAPH.Name = "MAPH";
            this.MAPH.Visible = true;
            this.MAPH.VisibleIndex = 0;
            // 
            // MALOAIPH
            // 
            this.MALOAIPH.Caption = "Mã loại phòng";
            this.MALOAIPH.FieldName = "MALOAIPH";
            this.MALOAIPH.Name = "MALOAIPH";
            this.MALOAIPH.Visible = true;
            this.MALOAIPH.VisibleIndex = 1;
            // 
            // KHUVUC
            // 
            this.KHUVUC.Caption = "Khu vực";
            this.KHUVUC.FieldName = "KHUVUC";
            this.KHUVUC.Name = "KHUVUC";
            this.KHUVUC.Visible = true;
            this.KHUVUC.VisibleIndex = 2;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.Caption = "Tình trạng";
            this.TINHTRANG.FieldName = "TINHTRANG";
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.Visible = true;
            this.TINHTRANG.VisibleIndex = 3;
            // 
            // FrmDMPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 449);
            this.Controls.Add(this.gvPhong);
            this.Controls.Add(this.gbPhong);
            this.Controls.Add(this.usctrThemXoaSua1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDMPhong";
            this.Text = "FrmDMPhong";
            this.gbPhong.ResumeLayout(false);
            this.gbPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private usctrThemXoaSua usctrTXS;
        private usctrThemXoaSua usctrThemXoaSua1;
        private System.Windows.Forms.GroupBox gbPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtKhuVuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaLoaiPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gvPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gCPhong;
        private DevExpress.XtraGrid.Columns.GridColumn MAPH;
        private DevExpress.XtraGrid.Columns.GridColumn MALOAIPH;
        private DevExpress.XtraGrid.Columns.GridColumn KHUVUC;
        private DevExpress.XtraGrid.Columns.GridColumn TINHTRANG;

    }
}