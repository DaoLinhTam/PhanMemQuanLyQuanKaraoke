namespace GUI
{
    partial class FrmDoiMatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMatkhau));
            this.txtTenTK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.txtMKMoi2 = new DevExpress.XtraEditors.TextEdit();
            this.txtMKMoi = new DevExpress.XtraEditors.TextEdit();
            this.txtMKCU = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCU.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenTK
            // 
            this.txtTenTK.Enabled = false;
            this.txtTenTK.Location = new System.Drawing.Point(151, 24);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(140, 20);
            this.txtTenTK.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(70, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mật khẩu cũ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(65, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu mới:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(57, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Tên Tài Khoản :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 143);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Nhập lại mật khẩu:";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(151, 177);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 28);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(224, 177);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 28);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            // 
            // txtMKMoi2
            // 
            this.txtMKMoi2.Location = new System.Drawing.Point(151, 100);
            this.txtMKMoi2.Name = "txtMKMoi2";
            this.txtMKMoi2.Size = new System.Drawing.Size(140, 20);
            this.txtMKMoi2.TabIndex = 3;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(151, 140);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(140, 20);
            this.txtMKMoi.TabIndex = 2;
            // 
            // txtMKCU
            // 
            this.txtMKCU.Location = new System.Drawing.Point(151, 62);
            this.txtMKCU.Name = "txtMKCU";
            this.txtMKCU.Size = new System.Drawing.Size(140, 20);
            this.txtMKCU.TabIndex = 1;
            // 
            // FrmDoiMatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 246);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMKMoi2);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.txtMKCU);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmDoiMatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKCU.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTenTK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.TextEdit txtMKMoi2;
        private DevExpress.XtraEditors.TextEdit txtMKMoi;
        private DevExpress.XtraEditors.TextEdit txtMKCU;



    }
}