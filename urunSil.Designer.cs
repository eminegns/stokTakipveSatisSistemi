namespace PROJE1
{
    partial class urunSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunSil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUrunSil = new System.Windows.Forms.DataGridView();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorselProgDataSet3 = new PROJE1.gorselProgDataSet3();
            this.bttnUrunSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtUrunSilme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gorselProgDataSet2 = new PROJE1.gorselProgDataSet2();
            this.gorselProgDataSet = new PROJE1.gorselProgDataSet();
            this.urunlerTablosuTableAdapter = new PROJE1.gorselProgDataSet3TableAdapters.urunlerTablosuTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(246)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.bttnUrunSil);
            this.panel1.Controls.Add(this.txtUrunSilme);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(152, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 465);
            this.panel1.TabIndex = 0;
            // 
            // dgvUrunSil
            // 
            this.dgvUrunSil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvUrunSil.AutoGenerateColumns = false;
            this.dgvUrunSil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunSil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunidDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dgvUrunSil.DataSource = this.urunlerTablosuBindingSource;
            this.dgvUrunSil.Location = new System.Drawing.Point(40, 193);
            this.dgvUrunSil.Name = "dgvUrunSil";
            this.dgvUrunSil.RowHeadersWidth = 51;
            this.dgvUrunSil.RowTemplate.Height = 24;
            this.dgvUrunSil.Size = new System.Drawing.Size(796, 302);
            this.dgvUrunSil.TabIndex = 6;
            this.dgvUrunSil.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // urunidDataGridViewTextBoxColumn
            // 
            this.urunidDataGridViewTextBoxColumn.DataPropertyName = "urun_id";
            this.urunidDataGridViewTextBoxColumn.HeaderText = "urun_id";
            this.urunidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunidDataGridViewTextBoxColumn.Name = "urunidDataGridViewTextBoxColumn";
            this.urunidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // renkDataGridViewTextBoxColumn
            // 
            this.renkDataGridViewTextBoxColumn.DataPropertyName = "renk";
            this.renkDataGridViewTextBoxColumn.HeaderText = "renk";
            this.renkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "kategori";
            this.kategoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "resim";
            this.resimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            // 
            // urunlerTablosuBindingSource
            // 
            this.urunlerTablosuBindingSource.DataMember = "urunlerTablosu";
            this.urunlerTablosuBindingSource.DataSource = this.gorselProgDataSet3;
            // 
            // gorselProgDataSet3
            // 
            this.gorselProgDataSet3.DataSetName = "gorselProgDataSet3";
            this.gorselProgDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bttnUrunSil
            // 
            this.bttnUrunSil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnUrunSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.bttnUrunSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnUrunSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnUrunSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnUrunSil.ImageIndex = 0;
            this.bttnUrunSil.ImageList = this.ımageList1;
            this.bttnUrunSil.Location = new System.Drawing.Point(326, 77);
            this.bttnUrunSil.Name = "bttnUrunSil";
            this.bttnUrunSil.Size = new System.Drawing.Size(192, 59);
            this.bttnUrunSil.TabIndex = 5;
            this.bttnUrunSil.Text = "Ürünü Sil";
            this.bttnUrunSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnUrunSil.UseVisualStyleBackColor = false;
            this.bttnUrunSil.Click += new System.EventHandler(this.bttnUrunSil_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "garbage_trash_bin_delete_icon_219529.png");
            // 
            // txtUrunSilme
            // 
            this.txtUrunSilme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUrunSilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.txtUrunSilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunSilme.Location = new System.Drawing.Point(167, 95);
            this.txtUrunSilme.Multiline = true;
            this.txtUrunSilme.Name = "txtUrunSilme";
            this.txtUrunSilme.Size = new System.Drawing.Size(134, 25);
            this.txtUrunSilme.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(225)))), ((int)(((byte)(175)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(193, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Silme";
            // 
            // gorselProgDataSet2
            // 
            this.gorselProgDataSet2.DataSetName = "gorselProgDataSet2";
            this.gorselProgDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gorselProgDataSet
            // 
            this.gorselProgDataSet.DataSetName = "gorselProgDataSet";
            this.gorselProgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerTablosuTableAdapter
            // 
            this.urunlerTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // urunSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(225)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(862, 684);
            this.Controls.Add(this.dgvUrunSil);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(275, 85);
            this.Name = "urunSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UrunSil";
            this.Load += new System.EventHandler(this.urunSil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorselProgDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunSilme;
        private System.Windows.Forms.Button bttnUrunSil;
        private System.Windows.Forms.ImageList ımageList1;
        private gorselProgDataSet2 gorselProgDataSet2;
        private gorselProgDataSet gorselProgDataSet;
        private System.Windows.Forms.DataGridView dgvUrunSil;
        private gorselProgDataSet3 gorselProgDataSet3;
        private System.Windows.Forms.BindingSource urunlerTablosuBindingSource;
        private gorselProgDataSet3TableAdapters.urunlerTablosuTableAdapter urunlerTablosuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
    }
}