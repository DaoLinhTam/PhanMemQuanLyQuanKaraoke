namespace GUI
{
    partial class FrmCauHinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCauHinh));
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboTenServer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboCSDL = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCSDL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(235, 221);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(72, 28);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(115, 221);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 28);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "Lưu";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(115, 146);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(192, 20);
            this.txtMK.TabIndex = 22;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(115, 106);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(192, 20);
            this.txtTenDN.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(129, 23);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(140, 33);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "CẤU HÌNH";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(51, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Mật Khẩu :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 13);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "Tên Đăng Nhập :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(40, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Tên Server : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(29, 185);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Cơ Sở Dữ Liệu :";
            // 
            // cboTenServer
            // 
            this.cboTenServer.Location = new System.Drawing.Point(115, 71);
            this.cboTenServer.Name = "cboTenServer";
            this.cboTenServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTenServer.Size = new System.Drawing.Size(192, 20);
            this.cboTenServer.TabIndex = 28;
            // 
            // cboCSDL
            // 
            this.cboCSDL.Location = new System.Drawing.Point(115, 182);
            this.cboCSDL.Name = "cboCSDL";
            this.cboCSDL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCSDL.Size = new System.Drawing.Size(192, 20);
            this.cboCSDL.TabIndex = 29;
            // 
            // FrmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 269);
            this.Controls.Add(this.cboCSDL);
            this.Controls.Add(this.cboTenServer);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmCauHinh";
            this.Text = "Cấu Hình";
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCSDL.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.TextEdit txtMK;
        private DevExpress.XtraEditors.TextEdit txtTenDN;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cboTenServer;
        private DevExpress.XtraEditors.ComboBoxEdit cboCSDL;

    }
}