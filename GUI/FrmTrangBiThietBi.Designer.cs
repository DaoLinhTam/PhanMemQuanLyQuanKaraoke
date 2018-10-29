namespace GUI
{
    partial class FrmTrangBiThietBi
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
            this.gCChiTietTrangBi = new DevExpress.XtraGrid.GridControl();
            this.gvChiTietTrangBi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MATB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MATHIETBI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtngaytrangbi = new System.Windows.Forms.DateTimePicker();
            this.btnThemTrangBi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmatrangbi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btntrovekho = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.btnThemChitietThietbi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaTB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmathietbi = new System.Windows.Forms.TextBox();
            this.gCThietBi = new DevExpress.XtraGrid.GridControl();
            this.gvThietBi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENTHIETBI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtmatrangbithietbi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmatbtb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsoluongtrangbi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gCChiTietTrangBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietTrangBi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThietBi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gCChiTietTrangBi
            // 
            this.gCChiTietTrangBi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gCChiTietTrangBi.Location = new System.Drawing.Point(618, 155);
            this.gCChiTietTrangBi.MainView = this.gvChiTietTrangBi;
            this.gCChiTietTrangBi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gCChiTietTrangBi.Name = "gCChiTietTrangBi";
            this.gCChiTietTrangBi.Size = new System.Drawing.Size(352, 265);
            this.gCChiTietTrangBi.TabIndex = 0;
            this.gCChiTietTrangBi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChiTietTrangBi});
            this.gCChiTietTrangBi.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gvChiTietTrangBi
            // 
            this.gvChiTietTrangBi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MATB,
            this.MATHIETBI,
            this.SOLUONG});
            this.gvChiTietTrangBi.GridControl = this.gCChiTietTrangBi;
            this.gvChiTietTrangBi.Name = "gvChiTietTrangBi";
            this.gvChiTietTrangBi.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvChiTietTrangBi.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvChiTietTrangBi_FocusedRowChanged);
            // 
            // MATB
            // 
            this.MATB.Caption = "Mã trang bị";
            this.MATB.FieldName = "MATB";
            this.MATB.Name = "MATB";
            this.MATB.Visible = true;
            this.MATB.VisibleIndex = 0;
            // 
            // MATHIETBI
            // 
            this.MATHIETBI.Caption = "Mã thiết bị";
            this.MATHIETBI.FieldName = "MATHIETBI";
            this.MATHIETBI.Name = "MATHIETBI";
            this.MATHIETBI.Visible = true;
            this.MATHIETBI.VisibleIndex = 1;
            // 
            // SOLUONG
            // 
            this.SOLUONG.Caption = "Số lượng trang bị";
            this.SOLUONG.FieldName = "SOLUONGTRANGBI";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Visible = true;
            this.SOLUONG.VisibleIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtngaytrangbi);
            this.groupBox1.Controls.Add(this.btnThemTrangBi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMaPhong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtmatrangbi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(241, 402);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu trang bị phòng";
            // 
            // dtngaytrangbi
            // 
            this.dtngaytrangbi.Location = new System.Drawing.Point(98, 87);
            this.dtngaytrangbi.Name = "dtngaytrangbi";
            this.dtngaytrangbi.Size = new System.Drawing.Size(130, 21);
            this.dtngaytrangbi.TabIndex = 7;
            // 
            // btnThemTrangBi
            // 
            this.btnThemTrangBi.Location = new System.Drawing.Point(65, 156);
            this.btnThemTrangBi.Name = "btnThemTrangBi";
            this.btnThemTrangBi.Size = new System.Drawing.Size(89, 23);
            this.btnThemTrangBi.TabIndex = 6;
            this.btnThemTrangBi.Text = "Thêm trang bị";
            this.btnThemTrangBi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã phòng";
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(98, 26);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(130, 21);
            this.cbMaPhong.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Trang Bị";
            // 
            // txtmatrangbi
            // 
            this.txtmatrangbi.Location = new System.Drawing.Point(98, 57);
            this.txtmatrangbi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmatrangbi.Name = "txtmatrangbi";
            this.txtmatrangbi.Size = new System.Drawing.Size(130, 21);
            this.txtmatrangbi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Trang Bị :";
            // 
            // btntrovekho
            // 
            this.btntrovekho.Location = new System.Drawing.Point(239, 56);
            this.btntrovekho.Name = "btntrovekho";
            this.btntrovekho.Size = new System.Drawing.Size(102, 23);
            this.btntrovekho.TabIndex = 11;
            this.btntrovekho.Text = "Đưa lại về kho";
            this.btntrovekho.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(103, 85);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(130, 21);
            this.txtsoluong.TabIndex = 1;
            // 
            // btnThemChitietThietbi
            // 
            this.btnThemChitietThietbi.Enabled = false;
            this.btnThemChitietThietbi.Location = new System.Drawing.Point(243, 47);
            this.btnThemChitietThietbi.Name = "btnThemChitietThietbi";
            this.btnThemChitietThietbi.Size = new System.Drawing.Size(75, 23);
            this.btnThemChitietThietbi.TabIndex = 12;
            this.btnThemChitietThietbi.Text = "Thêm";
            this.btnThemChitietThietbi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbMaTB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmathietbi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnThemChitietThietbi);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Location = new System.Drawing.Point(260, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(352, 129);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thiết bị ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã thiết bị";
            // 
            // cbMaTB
            // 
            this.cbMaTB.FormattingEnabled = true;
            this.cbMaTB.Location = new System.Drawing.Point(103, 28);
            this.cbMaTB.Name = "cbMaTB";
            this.cbMaTB.Size = new System.Drawing.Size(130, 21);
            this.cbMaTB.TabIndex = 8;
            this.cbMaTB.SelectedIndexChanged += new System.EventHandler(this.cbMaTB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Trang Bị :";
            // 
            // txtmathietbi
            // 
            this.txtmathietbi.Location = new System.Drawing.Point(103, 57);
            this.txtmathietbi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmathietbi.Name = "txtmathietbi";
            this.txtmathietbi.Size = new System.Drawing.Size(130, 21);
            this.txtmathietbi.TabIndex = 15;
            // 
            // gCThietBi
            // 
            this.gCThietBi.Location = new System.Drawing.Point(260, 155);
            this.gCThietBi.MainView = this.gvThietBi;
            this.gCThietBi.Name = "gCThietBi";
            this.gCThietBi.Size = new System.Drawing.Size(352, 265);
            this.gCThietBi.TabIndex = 12;
            this.gCThietBi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThietBi});
            // 
            // gvThietBi
            // 
            this.gvThietBi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MTB,
            this.TENTHIETBI,
            this.SOLUONGTON});
            this.gvThietBi.GridControl = this.gCThietBi;
            this.gvThietBi.Name = "gvThietBi";
            this.gvThietBi.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvThietBi.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvThietBi_FocusedRowChanged);
            // 
            // MTB
            // 
            this.MTB.Caption = "Mã thiết bị";
            this.MTB.FieldNameSortGroup = "MATHIETBI";
            this.MTB.Name = "MTB";
            this.MTB.Visible = true;
            this.MTB.VisibleIndex = 0;
            // 
            // TENTHIETBI
            // 
            this.TENTHIETBI.Caption = "Tên thiết bị";
            this.TENTHIETBI.FieldName = "TENTHIETBI";
            this.TENTHIETBI.Name = "TENTHIETBI";
            this.TENTHIETBI.Visible = true;
            this.TENTHIETBI.VisibleIndex = 1;
            // 
            // SOLUONGTON
            // 
            this.SOLUONGTON.Caption = "Số lượng tồn";
            this.SOLUONGTON.FieldName = "SOLUONGTON";
            this.SOLUONGTON.Name = "SOLUONGTON";
            this.SOLUONGTON.Visible = true;
            this.SOLUONGTON.VisibleIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtmatrangbithietbi);
            this.groupBox3.Controls.Add(this.btntrovekho);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtmatbtb);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtsoluongtrangbi);
            this.groupBox3.Location = new System.Drawing.Point(618, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(352, 129);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết thiết bị trang bị";
            // 
            // txtmatrangbithietbi
            // 
            this.txtmatrangbithietbi.Location = new System.Drawing.Point(103, 28);
            this.txtmatrangbithietbi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmatrangbithietbi.Name = "txtmatrangbithietbi";
            this.txtmatrangbithietbi.Size = new System.Drawing.Size(130, 21);
            this.txtmatrangbithietbi.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã thiết bị";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã Trang Bị :";
            // 
            // txtmatbtb
            // 
            this.txtmatbtb.Location = new System.Drawing.Point(103, 57);
            this.txtmatbtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmatbtb.Name = "txtmatbtb";
            this.txtmatbtb.Size = new System.Drawing.Size(130, 21);
            this.txtmatbtb.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng";
            // 
            // txtsoluongtrangbi
            // 
            this.txtsoluongtrangbi.Location = new System.Drawing.Point(103, 85);
            this.txtsoluongtrangbi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoluongtrangbi.Name = "txtsoluongtrangbi";
            this.txtsoluongtrangbi.Size = new System.Drawing.Size(130, 21);
            this.txtsoluongtrangbi.TabIndex = 1;
            // 
            // FrmTrangBiThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 449);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gCThietBi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gCChiTietTrangBi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTrangBiThietBi";
            this.Text = "FrmThietBiPhong";
            ((System.ComponentModel.ISupportInitialize)(this.gCChiTietTrangBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietTrangBi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThietBi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gCChiTietTrangBi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietTrangBi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmatrangbi;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn MATB;
        private DevExpress.XtraGrid.Columns.GridColumn MATHIETBI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.Button btnThemTrangBi;
        private System.Windows.Forms.Button btnThemChitietThietbi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtngaytrangbi;
        private System.Windows.Forms.ComboBox cbMaTB;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmathietbi;
        private System.Windows.Forms.Button btntrovekho;
        private DevExpress.XtraGrid.GridControl gCThietBi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn MTB;
        private DevExpress.XtraGrid.Columns.GridColumn TENTHIETBI;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONGTON;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtmatrangbithietbi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmatbtb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsoluongtrangbi;
    }
}