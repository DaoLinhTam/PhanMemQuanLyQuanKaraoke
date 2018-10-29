namespace GUI
{
    partial class FrmThietBiPhong
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
            this.gCThietBiPhong = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MATHIETBI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENTHIETBI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gCThietBiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gCThietBiPhong
            // 
            this.gCThietBiPhong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gCThietBiPhong.Location = new System.Drawing.Point(11, 87);
            this.gCThietBiPhong.MainView = this.gridView1;
            this.gCThietBiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gCThietBiPhong.Name = "gCThietBiPhong";
            this.gCThietBiPhong.Size = new System.Drawing.Size(992, 353);
            this.gCThietBiPhong.TabIndex = 0;
            this.gCThietBiPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MATHIETBI,
            this.TENTHIETBI});
            this.gridView1.GridControl = this.gCThietBiPhong;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // MATHIETBI
            // 
            this.MATHIETBI.Caption = "Mã thiết bị";
            this.MATHIETBI.FieldName = "MATHIETBI";
            this.MATHIETBI.Name = "MATHIETBI";
            this.MATHIETBI.Visible = true;
            this.MATHIETBI.VisibleIndex = 0;
            // 
            // TENTHIETBI
            // 
            this.TENTHIETBI.Caption = "Tên thiết bị";
            this.TENTHIETBI.FieldName = "TENTHIETBI";
            this.TENTHIETBI.Name = "TENTHIETBI";
            this.TENTHIETBI.Visible = true;
            this.TENTHIETBI.VisibleIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPhong);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(296, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phòng";
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(71, 33);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(186, 21);
            this.cbPhong.TabIndex = 0;
            // 
            // FrmThietBiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gCThietBiPhong);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmThietBiPhong";
            this.Text = "FrmTrangBiThietBi";
            ((System.ComponentModel.ISupportInitialize)(this.gCThietBiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        

        private DevExpress.XtraGrid.GridControl gCThietBiPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPhong;
        private DevExpress.XtraGrid.Columns.GridColumn MATHIETBI;
        private DevExpress.XtraGrid.Columns.GridColumn TENTHIETBI;
    }
}