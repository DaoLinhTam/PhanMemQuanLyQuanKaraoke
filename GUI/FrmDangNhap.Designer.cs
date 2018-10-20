namespace GUI
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDN = new DevExpress.XtraEditors.SimpleButton();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkLuuMK = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLuuMK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(201, 188);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 28);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            // 
            // btnDN
            // 
            this.btnDN.Image = ((System.Drawing.Image)(resources.GetObject("btnDN.Image")));
            this.btnDN.Location = new System.Drawing.Point(97, 188);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(80, 28);
            this.btnDN.TabIndex = 3;
            this.btnDN.Text = "Đăng nhập";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(97, 119);
            this.txtMK.Name = "txtMK";
            this.txtMK.Properties.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(192, 20);
            this.txtMK.TabIndex = 1;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(97, 81);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(192, 20);
            this.txtTenTK.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(100, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(166, 33);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "ĐĂNG NHẬP";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Mật Khẩu :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 84);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tài Khoản :";
            // 
            // chkLuuMK
            // 
            this.chkLuuMK.Location = new System.Drawing.Point(97, 154);
            this.chkLuuMK.Name = "chkLuuMK";
            this.chkLuuMK.Properties.Caption = "Lưu đăng nhập";
            this.chkLuuMK.Size = new System.Drawing.Size(145, 19);
            this.chkLuuMK.TabIndex = 2;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 232);
            this.Controls.Add(this.chkLuuMK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLuuMK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDN;
        private DevExpress.XtraEditors.TextEdit txtMK;
        private DevExpress.XtraEditors.TextEdit txtTenTK;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkLuuMK;
    }
}