namespace GUI
{
    partial class usctrRoomKaraokeShow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usctrRoomKaraokeShow));
            this.picbox = new System.Windows.Forms.PictureBox();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMoPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mởPhòngĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.picbox.Image = global::GUI.Properties.Resources.icon_room_back;
            this.picbox.Location = new System.Drawing.Point(19, 26);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(53, 40);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.Location = new System.Drawing.Point(16, 69);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(56, 23);
            this.lblTenPhong.TabIndex = 1;
            this.lblTenPhong.Text = "102";
            this.lblTenPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltime
            // 
            this.lbltime.BackColor = System.Drawing.Color.OrangeRed;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(19, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(53, 23);
            this.lbltime.TabIndex = 2;
            this.lbltime.Text = "00:00";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltime.Visible = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoPhong,
            this.mởPhòngĐặtToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(152, 48);
            // 
            // btnMoPhong
            // 
            this.btnMoPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnMoPhong.Image")));
            this.btnMoPhong.Name = "btnMoPhong";
            this.btnMoPhong.Size = new System.Drawing.Size(151, 22);
            this.btnMoPhong.Text = "Mở Phòng";
            // 
            // mởPhòngĐặtToolStripMenuItem
            // 
            this.mởPhòngĐặtToolStripMenuItem.Name = "mởPhòngĐặtToolStripMenuItem";
            this.mởPhòngĐặtToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.mởPhòngĐặtToolStripMenuItem.Text = "Mở Phòng Đặt";
            // 
            // usctrRoomKaraokeShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblTenPhong);
            this.Controls.Add(this.picbox);
            this.Name = "usctrRoomKaraokeShow";
            this.Size = new System.Drawing.Size(90, 90);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnMoPhong;
        private System.Windows.Forms.ToolStripMenuItem mởPhòngĐặtToolStripMenuItem;
    }

        
    
}
