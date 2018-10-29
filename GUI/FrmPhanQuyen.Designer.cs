namespace GUI
{
    partial class FrmPhanQuyen
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
            this.qLKaraoke = new GUI.QLKaraoke();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMNGUOIDUNGTableAdapter = new GUI.QLKaraokeTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager = new GUI.QLKaraokeTableAdapters.TableAdapterManager();
            this.dgvPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.gvPhanQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAMANHINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMANHINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COQUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboNhomND = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.qLKaraoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // qLKaraoke
            // 
            this.qLKaraoke.DataSetName = "QLKaraoke";
            this.qLKaraoke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataMember = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGBindingSource.DataSource = this.qLKaraoke;
            // 
            // nHOMNGUOIDUNGTableAdapter
            // 
            this.nHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNG_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = this.nHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.QLKaraokeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.Location = new System.Drawing.Point(98, 121);
            this.dgvPhanQuyen.MainView = this.gvPhanQuyen;
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.Size = new System.Drawing.Size(252, 246);
            this.dgvPhanQuyen.TabIndex = 3;
            this.dgvPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhanQuyen});
            // 
            // gvPhanQuyen
            // 
            this.gvPhanQuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAMANHINH,
            this.TENMANHINH,
            this.COQUYEN});
            this.gvPhanQuyen.GridControl = this.dgvPhanQuyen;
            this.gvPhanQuyen.Name = "gvPhanQuyen";
            this.gvPhanQuyen.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // MAMANHINH
            // 
            this.MAMANHINH.Caption = "Mã Màn Hình";
            this.MAMANHINH.FieldName = "MAMANHINH";
            this.MAMANHINH.Name = "MAMANHINH";
            this.MAMANHINH.Visible = true;
            this.MAMANHINH.VisibleIndex = 0;
            // 
            // TENMANHINH
            // 
            this.TENMANHINH.Caption = "Mã màn hình";
            this.TENMANHINH.FieldName = "TENMANHINH";
            this.TENMANHINH.Name = "TENMANHINH";
            this.TENMANHINH.Visible = true;
            this.TENMANHINH.VisibleIndex = 1;
            // 
            // COQUYEN
            // 
            this.COQUYEN.Caption = "Có Quyền";
            this.COQUYEN.FieldName = "COQUYEN";
            this.COQUYEN.Name = "COQUYEN";
            this.COQUYEN.Visible = true;
            this.COQUYEN.VisibleIndex = 2;
            // 
            // cboNhomND
            // 
            this.cboNhomND.DataSource = this.qLKaraoke;
            this.cboNhomND.DisplayMember = "NHOMNGUOIDUNG.TENNHOM";
            this.cboNhomND.FormattingEnabled = true;
            this.cboNhomND.Location = new System.Drawing.Point(363, 26);
            this.cboNhomND.Name = "cboNhomND";
            this.cboNhomND.Size = new System.Drawing.Size(121, 21);
            this.cboNhomND.TabIndex = 4;
            this.cboNhomND.ValueMember = "NHOMNGUOIDUNG.MANHOM";
            this.cboNhomND.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 598);
            this.Controls.Add(this.cboNhomND);
            this.Controls.Add(this.dgvPhanQuyen);
            this.Name = "FrmPhanQuyen";
            this.Text = " Phân Quyền";
            this.Load += new System.EventHandler(this.FrmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLKaraoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLKaraoke qLKaraoke;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private QLKaraokeTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private QLKaraokeTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl dgvPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhanQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn MAMANHINH;
        private DevExpress.XtraGrid.Columns.GridColumn TENMANHINH;
        private DevExpress.XtraGrid.Columns.GridColumn COQUYEN;
        private System.Windows.Forms.ComboBox cboNhomND;



    }
}