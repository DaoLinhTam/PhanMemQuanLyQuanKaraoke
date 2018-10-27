namespace GUI
{
    partial class demo
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
            this.usctrRoomKaraokeShow1 = new GUI.usctrRoomKaraokeShow();
            this.SuspendLayout();
            // 
            // usctrRoomKaraokeShow1
            // 
            this.usctrRoomKaraokeShow1.BackColor = System.Drawing.Color.Transparent;
            this.usctrRoomKaraokeShow1.Location = new System.Drawing.Point(113, 124);
            this.usctrRoomKaraokeShow1.Name = "usctrRoomKaraokeShow1";
            this.usctrRoomKaraokeShow1.Size = new System.Drawing.Size(100, 100);
            this.usctrRoomKaraokeShow1.TabIndex = 0;
            // 
            // demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 332);
            this.Controls.Add(this.usctrRoomKaraokeShow1);
            this.Name = "demo";
            this.Text = "demo";
            this.Load += new System.EventHandler(this.demo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private usctrRoomKaraokeShow usctrRoomKaraokeShow1;




    }
}